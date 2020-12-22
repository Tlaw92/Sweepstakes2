using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetstakesRound2
{
    class MarketingFirm
    {
        //Variables
        private ISweepstakesManager _manager;


        //Constructor
        public MarketingFirm(ISweepstakesManager manager) //dependancy injection in order to filter managers choice of ordering sweepstakes, either stack(push, pop) or queue(onqueue, dequeue)
        {
            _manager = manager;
        }

        //Methods
        public void CreateSweepstake(string name)
        {
            Sweepstakes sweepstakes = new Sweepstakes(name);
            _manager.InsertSweepstakes(sweepstakes);
            //Contestant contestant = new Contestant();
            //UserInterface.GetUserInputFor(contestant);
            //UserInterface.GetRegNumber(contestant);
        }

    }
}