using Google.Cloud.Speech.V1Beta1;
using Google.Protobuf;
using Grpc.Auth;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Cloud.Speech.V1Beta1.Speech;

namespace kynnaugh
{
    class SpeechTranscriber
    {
        public SpeechTranscriber()
        {
        }

        public async Task<string> TranscribeSpeechAsync(byte[] speechData)
        {
            Channel channel = new Channel("speech.googleapis.com:443", await GoogleGrpcCredentials.GetApplicationDefaultAsync());
            SpeechClient client = new SpeechClient(channel);
            RecognitionConfig config = new RecognitionConfig
            {
                ProfanityFilter = false,
                Encoding = RecognitionConfig.Types.AudioEncoding.Flac,
                SampleRate = 16000,
                LanguageCode = "en-US",
                MaxAlternatives = 1
            };
            RecognitionAudio audio = new RecognitionAudio
            {
                Content = ByteString.CopyFrom(speechData)
            };

            SyncRecognizeRequest req = new SyncRecognizeRequest
            {
                Audio = audio,
                Config = config
            };

            SyncRecognizeResponse resp = await client.SyncRecognizeAsync(req);

            if (resp.Results.Count > 0)
            {
                SpeechRecognitionResult res = resp.Results.First();
                if (res.Alternatives.Count > 0)
                {
                    SpeechRecognitionAlternative alt = res.Alternatives[0];
                    return alt.Transcript;
                }
            }

            return null;
        }
    }
}
