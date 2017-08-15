using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantVideoConverter
{
    interface IConvert
    {
        void Start(ConversionOption opt);
        void Pause();
        void Stop();
        int GetProgress();
        bool IsStarted();
    }
}
