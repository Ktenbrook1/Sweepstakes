﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Steaks
{
    class Simulation
    {
        public Simulation()
        {

        }
        public void CreatMarketingFirmWithManager()
        {
            MarketingFirm firm = new MarketingFirm();
            firm.CreateSweepsteaks();
            
        }
    }
}
