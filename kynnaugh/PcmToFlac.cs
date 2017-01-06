using CSCore;
using CSCore.Codecs.RAW;
using FlacBox;
using System.IO;

namespace kynnaugh
{
	public class PcmToFlac
	{
		public static byte[] Convert(byte[] input, int channels)
		{
			using (var dest = new MemoryStream())
			{
				using (var resampledSource = new MemoryStream())
				{
					using (var source = new RawDataReader(new MemoryStream(input, false), new WaveFormat(48000, 16, channels)))
					{
						source
							.ToMono()
							.ChangeSampleRate(16000)
							.ToSampleSource()
							.ToWaveSource(16)
							.WriteToWaveStream(resampledSource);
					}

					using (var encStream = new WaveOverFlacStream(dest, WaveOverFlacStreamMode.Encode, true))
					{
						var buf = resampledSource.ToArray();
						encStream.Write(buf, 0, buf.Length);
					}

					return dest.ToArray();
				}
			}
		}
	}
}
