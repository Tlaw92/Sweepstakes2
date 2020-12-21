using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetstakesRound2
{
    // For all information the application would need to get from the user.
    //  Like the functionality to assign a Contestant object a..
    // - first name
    // - last name
    // - email address 
    // - and registration number
    static class UserInterface

    {
        //variables

        //constructor

        //methods
        public static void GetUserInputFor(Contestant contestantToGetInfoFor)
        {
            Console.WriteLine("Please enter in your information below. \n What is your first name?");
            contestantToGetInfoFor.Firstname = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string userLastName = Console.ReadLine();

            Console.WriteLine("What is your E-Mail Address?");
            string userEmail = Console.ReadLine();

        }

        public static void GetRegNumber()
        {
            Random rnd = new Random();
            int regNum = rnd.Next(1000, 1999);
        }

    }
}
