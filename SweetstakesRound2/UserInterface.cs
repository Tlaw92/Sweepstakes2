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
            contestantToGetInfoFor.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            contestantToGetInfoFor.LastName = Console.ReadLine();

            Console.WriteLine("What is your E-Mail Address?");
            contestantToGetInfoFor.EmailAddress = Console.ReadLine();
        }

        public static void GiveUserInformation(int regNumber, string contestantName, string sweepstakesName)
        {
            Console.WriteLine($"Thank you for Registering for {sweepstakesName}, {contestantName}!\n" +
                $"Your registration number is {regNumber}.");
        }

        public static void PrintContestantInformaton(Contestant contestant)
        {
            Console.WriteLine($"{contestant.FirstName} {contestant.LastName} {contestant.EmailAddress} {contestant.RegistrationNumber}");
        }

    }
}
