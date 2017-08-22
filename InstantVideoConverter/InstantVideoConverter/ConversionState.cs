using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantVideoConverter
{
    public enum ConversionState
    {
        Queued,
        Started,
        Paused,
        Completed,
    }
}
