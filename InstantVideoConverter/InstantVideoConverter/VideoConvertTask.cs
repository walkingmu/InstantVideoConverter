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
        private string filePath;
        private ConversionOption conversionOption;
        
        public VideoConvertTask(string file, ConversionOption option)
        {
            this.filePath = file;
            conversionOption = option;
        }

        public int Progress
        {
            get
            {
                return GetProgress();
            }
        }
        
    }
}
