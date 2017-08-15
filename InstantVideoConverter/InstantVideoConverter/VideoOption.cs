using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantVideoConverter
{
    enum HardwareAcceleration
    {
        H264_CUDA,
        H264_Intel,
        H265_CUDA,
        H265_Intel,
    }
    class VideoOption
    {
        private uint rotation;
        private uint width;
        private uint height;
        private string metadata;

        private HardwareAcceleration hardwareAcceleration;

        private string bitRate; //format of b:a

        public uint Rotation
        {
            get
            {
                return rotation;
            }

            set
            {
                rotation = value;
            }
        }

        public uint Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public uint Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public string Metadata
        {
            get
            {
                return metadata;
            }

            set
            {
                metadata = value;
            }
        }
    }
}
