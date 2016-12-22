using kynnaugh.TS3Api;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace kynnaugh
{
    internal class SampleHandler
    {
        public TS3Functions TS3Functions { get; set; }

        private ConcurrentDictionary<SampleId, SampleInfo> sampleStore = new ConcurrentDictionary<SampleId, SampleInfo>();

        // must be field to prevent GC
        private Timer timer;

        public SampleHandler()
        {
            timer = new Timer(state => CheckSamples(), null, TimeSpan.Zero, TimeSpan.FromMilliseconds(500));
        }

        public void AddSample(UInt64 serverConnectionHandlerID, UInt16 clientID, short[] samples, int channels)
        {
            SampleId key = new SampleId(serverConnectionHandlerID, clientID, channels);

            SampleInfo info = sampleStore.GetOrAdd(key, new SampleInfo());

            lock (info)
            {
                info.LastUpdatedTime = DateTime.UtcNow;
                info.Samples.AddRange(samples);
            }
            
        }

        public void CheckSamples()
        {
            var threshold = DateTime.UtcNow - TimeSpan.FromMilliseconds(1250);
            foreach (var kvp in sampleStore)
            {
                lock (kvp.Value)
                {
                    Console.WriteLine("Checking kvp set " + kvp.Value.LastUpdatedTime + " against threshold " + threshold);
                    if (threshold > kvp.Value.LastUpdatedTime)
                    {
                        var samples = kvp.Value.Samples.ToArray();
                        kvp.Value.Samples.Clear();
                        kvp.Value.LastUpdatedTime = DateTime.MaxValue;

                        var id = kvp.Key;


                        Console.WriteLine("Transcribing sample " + id.ClientID);

                        var task = Task.Run(() => TranscribeSamplesAsync(samples, id.Channels));

                        task.Wait();
                    }
                }
            }
        }

        public async void TranscribeSamplesAsync(short[] samples, int channels)
        {
            byte[] sampleData = new byte[samples.Length * 2];
            Buffer.BlockCopy(samples, 0, sampleData, 0, samples.Length * 2);

            Console.WriteLine("Converting " + samples.Length + " samples to FLAC");
            byte[] speechData = PcmToFlac.PcmToFlac.Convert(sampleData, channels);
            Console.WriteLine(speechData.Length + " bytes of FLAC received");

            SpeechTranscriber transcriber = new SpeechTranscriber();
            string text = await transcriber.TranscribeSpeechAsync(speechData);

            if (text != null)
            {
                // TODO: UTF-8-ify
                TS3Functions.printMessageToCurrentTab(text);
            }
        }
    }

    internal class SampleId : System.Tuple<UInt64, UInt16, int>
    {
        public UInt64 ServerConnectionHandlerID => this.Item1;

        public UInt16 ClientID => this.Item2;

        public int Channels => this.Item3;

        public SampleId(UInt64 serverConnectionHandlerID, UInt16 clientID, int channels) : base(serverConnectionHandlerID, clientID, channels) { }
    }

    internal class SampleInfo
    {
        public DateTime LastUpdatedTime { get; set; }

        public List<short> Samples { get; } = new List<short>();
    }
}
