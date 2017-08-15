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

    class ConversionOption
    {
        VideoOption videoOption;
        AudioOption audioOption;

        //the following parameters are general options
        private string outputPath;

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

        public string GetInvokeString()
        {
            return "";
        }
    }
}