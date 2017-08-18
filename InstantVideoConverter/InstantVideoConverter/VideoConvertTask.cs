using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace InstantVideoConverter
{
    class VideoConvertTask : ffmpegEngine
    {
        private ConversionOption conversionOption;
        
        public VideoConvertTask(int taskID, string file, string outputPath)
            : base(taskID, file)
        {
            conversionOption = new ConversionOption(GetMetaData(), outputPath);
        }

        public ConversionOption ConversionOption
        {
            get
            {
                return conversionOption;
            }
        }
        public string VideoFilePath
        {
            get
            {
                return filePath;
            }
        }
        public void Start()
        {
            this.Start(conversionOption);
        }
        public string Progress
        {
            get
            {
                if (IsCompleted)
                    return "100%";
                return string.Format("{0:00.00}%", GetProgress());
            }
        }

        public override bool Equals(object obj)
        {
            return base.GetHashCode() == (obj.GetHashCode());
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public Metadata VideoMetaData
        {
            get
            {
                if (metadata == null)
                    GetMetaData();
                return metadata;
            }
        }
    }
}
