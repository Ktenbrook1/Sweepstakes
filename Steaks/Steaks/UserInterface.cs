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
            Console.WriteLine("Please choose your registration number");
            string num = Console.ReadLine();
            int registrationNum = 0;
            bool success;
            do
            {
                success = int.TryParse(num, out int registarNum);
            } while (!success);
            return registrationNum;
        }

        public static string PrintContestantWinner(Contestant contestant)
        {
            string message = $"CONGRATULATIONS {contestant.firstName}, YOU HAVE WON THE SWEEPSTAKES";
            return message;
        }

        public static string GetCollection()
        {
            Console.WriteLine("Would you like to use the Queue collection or the Stack collection?" +
                "'Q' for Queue and 'S' for Stack");
            string collectionType;
            do
            {
                collectionType = Console.ReadLine();
                if(collectionType != "Q" && collectionType != "S")
                {
                    Console.WriteLine("That was not correct input, please try again...");
                }
            } while (collectionType != "Q" && collectionType != "S");
         
            return collectionType;
        }
    }
}
