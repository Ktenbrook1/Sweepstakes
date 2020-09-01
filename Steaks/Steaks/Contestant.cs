using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steaks
{
    class Contestant
    {
        public string firstName;
        string lastName;
        string email;
        int registrationNumber;
        public Contestant()
        {
            //is this ok
            firstName = UserInterface.GetFirstName();
            lastName = UserInterface.GetLastName();
            email = UserInterface.GetEmail();
            registrationNumber = UserInterface.GetRegistationNumber();
        }
    }
}
