using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetstakesRound2
{
    // Use the Dictionary data structure as an underlying structure.
    class Sweepstakes
    {
        //Variables
        public Contestant bigWinner;
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name { get { return name; } } 
        
        //Constructor
        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        //Methods
        public int MakeRandomNumber()
        {
            Random rnd = new Random();
            int rando = rnd.Next(1000, 1999);
            return rando;
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant.RegistrationNumber = MakeRandomNumber();
            UserInterface.GetUserInputFor(contestant);
            UserInterface.GiveUserInformation(contestant.RegistrationNumber, contestant.FirstName, name); //or Name?

        }


        public Contestant PickWinner()
        {
            int winningNumber = MakeRandomNumber();
            // a random number is drawn
            // compare against every contestant reg number
            foreach (KeyValuePair<int, Contestant> winner in contestants)
            {
                if (winningNumber == winner.Key) 
                {
                    bigWinner = winner.Value;
                }
            }
            return bigWinner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.PrintContestantInformaton(contestant);
        }
    }
}
