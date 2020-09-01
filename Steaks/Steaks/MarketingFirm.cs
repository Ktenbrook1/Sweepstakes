using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steaks
{
    class MarketingFirm
    {
        ISweepstakesManager _manager;

        public MarketingFirm()
        {
            
        }
        public void Marketingfirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }
        public void CreateSweepsteaks()
        {
           string collection = UserInterface.GetCollection();
            if(collection == "Q")
            {
                _manager = new SweepstakesQueueManager();
            }
            else if(collection == "S")
            {
                _manager = new SweepstakesStackManager();
            }
        }
    }
}
