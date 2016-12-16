using kynnaugh.TS3Api;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace kynnaugh
{
    internal class SampleHandler
    {
        public TS3Functions TS3Functions { get; set; }

        private ConcurrentDictionary<SampleId, SampleInfo> sampleStore = new ConcurrentDictionary<SampleId, SampleInfo>();

        public SampleHandler()
        {
            Timer timer = new Timer(state => CheckSamples(), null, Timeout.InfiniteTimeSpan, TimeSpan.FromMilliseconds(500));
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
                    if (threshold > kvp.Value.LastUpdatedTime)
                    {
                        var samples = kvp.Value.Samples.ToArray();
                        kvp.Value.Samples.Clear();

                        var id = kvp.Key;

                        Task.Run(() => TranscribeSamples(samples));
                    }
                }
            }
        }

        public void TranscribeSamples(short[] samples)
        {

        }
    }

    internal class SampleId : System.Tuple<UInt64, UInt16, int>
    {
        public SampleId(UInt64 serverConnectionHandlerID, UInt16 clientID, int channels) : base(serverConnectionHandlerID, clientID, channels) { }
    }

    internal class SampleInfo
    {
        public DateTime LastUpdatedTime { get; set; }

        public List<short> Samples { get; } = new List<short>();
    }
}
