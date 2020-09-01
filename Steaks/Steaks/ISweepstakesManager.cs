using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steaks
{
    interface ISweepstakesManager
    {
        void InsertSweepsteaks(Sweepstakes sweepsteaks);
        Sweepstakes GetSweepsteak();
    }
}
