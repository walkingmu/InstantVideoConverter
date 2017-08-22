using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantVideoConverter
{
    enum HardwareAcceleration
    {
        Disabled,
        cuvid, //H264_CUDA,
        d3d11va, //d3d11va 
        dxva2, //DirectX Video Acceleration
        qsv, //H264_Intel,
    }

    class VideoOption : ICloneable
    {
        private uint rotation;
        private uint width;
        private uint height;

        private HardwareAcceleration hardwareAcceleration;

        public VideoOption(uint width, uint height, uint rotation)
        {
            this.width = width;
            this.height = height;
            this.rotation = rotation;
        }
        public VideoOption(VideoOption videoOption)
        {
            this.rotation = videoOption.rotation;
            this.width = videoOption.width;
            this.height = videoOption.height;
            this.hardwareAcceleration = videoOption.hardwareAcceleration;
        }

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

        public HardwareAcceleration HardwareAcceleration
        {
            get
            {
                return hardwareAcceleration;
            }

            set
            {
                hardwareAcceleration = value;
            }
        }

        public string GetInvokeString()
        {
            StringBuilder sb = new StringBuilder();
            //Size
            sb.AppendFormat("-s {0}x{1}", width, height);
            //Rotate currently not supported yet
            if(rotation != 0)
                sb.AppendFormat(" -transpose clock");
            
            
            return sb.ToString();
        }
        public object Clone()
        {
            return new VideoOption(this);
        }
    }
}
