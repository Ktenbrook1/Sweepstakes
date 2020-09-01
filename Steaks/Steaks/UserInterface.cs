using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steaks
{
    public static class UserInterface
    {
        
        public static string GetFirstName()
        {
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();
            if (string.IsNullOrEmpty(firstName))
            {
                Console.WriteLine("Name can't be empty! Input your name once more");
                firstName = Console.ReadLine();
            }
            return firstName;
        }
        public static string GetLastName()
        {
            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();
            if (string.IsNullOrEmpty(lastName))
            {
                Console.WriteLine("Name can't be empty! Input your name once more");
                lastName = Console.ReadLine();
            }
            return lastName;
        }

        public static string GetEmail()
        {
            Console.WriteLine("Please enter your email: ");
            string email = Console.ReadLine();
            if (string.IsNullOrEmpty(email))
            {
                Console.WriteLine("Name can't be empty! Input your name once more");
                email = Console.ReadLine();
            }
            //make sure its a email if it ends with a proper @
            return email;
        }

        public static int GetRegistationNumber()
        {
            numOfRegistered++;
            Console.WriteLine("Here is your registration number : {0}", numOfRegistered);
        }

        public static string PrintContestantWinner(Contestant contestant)
        {
            
            Console.WriteLine("CONGRATULATIONS {0}, ", contestant.);
        }
    }
}
