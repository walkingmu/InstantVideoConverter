using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InstantVideoConverter
{
    class ffmpegEngine :IConvert
    {
        private Thread conversionThread;

        private void ConversionWork(object opt)
        {
            ConversionOption conversionOption = opt as ConversionOption;
            string invokeString = conversionOption.GetInvokeString();

        }

        public void Start(ConversionOption opt)
        {
            conversionThread = new Thread(ConversionWork);
            conversionThread.Start(opt);
        }

        public void Stop()
        {

        }
        public void Pause()
        {
            //not supported yet
        }

        public int GetProgress()
        {
            throw new NotImplementedException();
        }

        public bool IsStarted()
        {
            throw new NotImplementedException();
        }
    }
}
