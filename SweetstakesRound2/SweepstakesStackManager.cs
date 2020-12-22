using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetstakesRound2
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //Variables
        private Stack<Sweepstakes> stack;

        //Constructor
        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }

        //Methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return stack.Pop();
        }
    }
}
