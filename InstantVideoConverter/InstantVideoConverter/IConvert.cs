using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantVideoConverter
{
    interface IConvert
    {
        Metadata GetMetaData(string filePath);
        void Start(ConversionOption opt);
        void Pause();
        void Stop();
        float GetProgress();
        bool IsStarted();
    }
}
