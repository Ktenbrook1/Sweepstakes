using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steaks
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string email;
        public int registrationNumber;
        public Contestant()
        {
            firstName = UserInterface.GetFirstName();
            lastName = UserInterface.GetLastName();
            email = UserInterface.GetEmail();
            registrationNumber = UserInterface.GetRegistationNumber();
        }
    }
}
