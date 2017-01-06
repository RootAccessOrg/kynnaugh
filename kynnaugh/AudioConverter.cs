using CSCore;
using CSCore.Codecs.RAW;
using FlacBox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kynnaugh
{
    class AudioConverter
    {
        public byte[] Convert(byte[] input, int inSampleRate, int outSampleRate, int inBitRate, int outBitRate, int inChannels, int outChannels)
        {
            using (var dest = new MemoryStream())
            {
                using (var resampledSource = new MemoryStream())
                {
                    using (var s = new RawDataReader(new MemoryStream(input, false), new WaveFormat(inSampleRate, inBitRate, inChannels)))
                    {
                        var source = outChannels == 1 ? s.ToMono() : s.ToStereo();
                        source
                            .ChangeSampleRate(outSampleRate)
                            .ToSampleSource()
                            .ToWaveSource(outBitRate)
                            .WriteToWaveStream(resampledSource);
                    }


                    using (var encStream = new WaveOverFlacStream(dest, WaveOverFlacStreamMode.Encode, true))
                    {
                        var buf = resampledSource.ToArray();
                        encStream.Write(buf, 0, buf.Length);
                    }
                }

                return dest.ToArray();
            }
        }
    }
}
