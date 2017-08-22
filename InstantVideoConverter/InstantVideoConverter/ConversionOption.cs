using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantVideoConverter
{
    enum OverwriteOption
    {
        OverWrite, //A file with same name will be overwritten
        Rename, //Rename the conflict file with (1), (2)....
    }

    class ConversionOption : ICloneable
    {
        VideoOption videoOption;
        AudioOption audioOption;
        public OverwriteOption ConflictFileOption { get; set;}

        //the following parameters are general options
        private string outputPath;

        public ConversionOption(Metadata mData, string outputPath)
        {//This will generate a default Conversion option basically changes nothing
            videoOption = new VideoOption(mData.VideoData.FrameWidth, mData.VideoData.FrameHeight, 0);
            audioOption = new AudioOption(AudioOption.VOLUME_NORMAL);
            this.outputPath = outputPath;
            ConflictFileOption = OverwriteOption.OverWrite;
        }
        public ConversionOption(ConversionOption conversionOption)
        {
            this.videoOption = conversionOption.videoOption.Clone() as VideoOption;
            this.audioOption = conversionOption.audioOption.Clone() as AudioOption;
            this.outputPath = conversionOption.outputPath.Clone().ToString();
            
        }

        public string OutputPath
        {
            get
            {
                return outputPath;
            }
            set
            {
                outputPath = value;
            }
        }
        public VideoOption VideoOption
        {
            get
            {
                return videoOption;
            }
            set
            {
                videoOption = value;
            }
        }

        public AudioOption AudioOption
        {
            get
            {
                return audioOption;
            }
            set
            {
                audioOption = value;
            }
        }

        public string GetInvokeString(string inputFile)
        {
            StringBuilder sb = new StringBuilder();
            /*
             * Hardware acceleration methods:
                d3d11va
                dxva2
                qsv
                cuvid
            */
            if (this.videoOption.HardwareAcceleration != HardwareAcceleration.Disabled)
            {
                //this parameter must before the input file
                sb.AppendFormat("-hwaccel {0}", this.videoOption.HardwareAcceleration);
            }
            sb.AppendFormat(" -i \"{0}\" {1} {2}", inputFile, videoOption.GetInvokeString(), audioOption.GetInvokeString());

            if (this.videoOption.HardwareAcceleration == HardwareAcceleration.qsv)
            {
                sb.AppendFormat(" -c:v h264_qsv");
            }
            else if (this.videoOption.HardwareAcceleration == HardwareAcceleration.cuvid)
            {
                sb.AppendFormat(" -c:v h264_nvenc");
            }
            //Output file
            sb.AppendFormat(" \"{0}\"", outputPath);
            return sb.ToString();
        }

        public object Clone()
        {
            return new ConversionOption(this);
        }
    }
}