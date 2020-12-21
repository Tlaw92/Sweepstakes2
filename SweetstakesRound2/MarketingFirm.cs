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


        //Constructor
        public MarketingFirm()
        {

        }

        //Methods
        public MarketingFirm(ISweepstakesManager manager)
        {

        }

        public void CreateSweepstake()
        {
            Contestant contestant = new Contestant();
            UserInterface.GetUserInputFor(contestant);

        }

    }
}
