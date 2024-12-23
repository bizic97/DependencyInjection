using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Vezbanje.Models
{
    public class ComputerPlayer : IPlayer
    {
        private Random _rnd = new Random();
        public IChoice.Choice GetChoice()
        {
            IChoice.Choice p2 = (IChoice.Choice)_rnd.Next(0, 3);
            return p2;
        }
    }
}
