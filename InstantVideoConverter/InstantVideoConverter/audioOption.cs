using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantVideoConverter
{
    class AudioOption : ICloneable
    {
        private uint volume;
        public const uint VOLUME_NORMAL = 256;
        public AudioOption(uint volume)
        {
            this.volume = volume;
        }
        public AudioOption(AudioOption audioOption)
        {
            this.volume = audioOption.volume;
        }

        public uint Volume
        {
            get
            {
                return volume;
            }

            set
            {
                volume = value;
            }
        }

        public string GetInvokeString()
        {
            /*
             * Audio options:
-aframes number     set the number of audio frames to output
-aq quality         set audio quality (codec-specific)
-ar rate            set audio sampling rate (in Hz)
-ac channels        set number of audio channels
-an                 disable audio
-acodec codec       force audio codec ('copy' to copy stream)
-vol volume         change audio volume (256=normal)
-af filter_graph    set audio filters
             * */
            return "-vol 256";
        }
        public object Clone()
        {
            return new AudioOption(this);
        }
    }
}
