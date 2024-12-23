using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Vezbanje.Models
{
    public class HumanPlayer : IPlayer
    {
        public IChoice.Choice GetChoice()
        {
            IChoice.Choice p1;
            do
            {
                Console.Write("Enter choice: (R)ock, (P)aper or (S)cissors: ");
                string input = Console.ReadLine().ToUpper();
                if (Equals(input, "R"))
                {
                    p1 = IChoice.Choice.Rock;
                    break;
                }
                else if (Equals(input, "P"))
                {
                    p1 = IChoice.Choice.Paper;
                    break;
                }
                else if (Equals(input, "S"))
                {
                    p1 = IChoice.Choice.Scissors;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter 'R', 'P' or 'S'!");
                }
            } while (true);

            return p1;
        }
    }
}
