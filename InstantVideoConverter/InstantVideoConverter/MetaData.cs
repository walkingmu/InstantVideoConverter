using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantVideoConverter
{
    public class Metadata
    {
        internal Metadata() { }
        public TimeSpan Duration { get; internal set; }
        public Video VideoData { get; internal set; }
        public Audio AudioData { get; internal set; }

        public class Video
        {
            internal Video() { }
            private uint frameHeight;
            private uint frameWidth;
            private string frameSize;
            public uint FrameWidth
            {
                get { return frameWidth; }
            }
            public uint FrameHeight
            {
                get
                {
                    return frameHeight;
                }
            }
            public string Format { get; internal set; }
            public string ColorModel { get; internal set; }
            public string FrameSize {
                get
                {
                    return frameSize;
                }
                internal set
                {
                    frameSize = value;
                    string []spts = frameSize.Split('x');
                    frameWidth = uint.Parse(spts[0]);
                    frameHeight = uint.Parse(spts[1]);
                }
            }
            public int? BitRateKbs { get; internal set; }
            public double Fps { get; internal set; }
        }

        public class Audio
        {
            internal Audio() { }

            public string Format { get; internal set; }
            public string SampleRate { get; internal set; }
            public string ChannelOutput { get; internal set; }
            public int BitRateKbs { get; internal set; }
        }
    }
}