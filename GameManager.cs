using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Vezbanje.Models
{
    public class GameManager 
    {
        private IPlayer _player1;
        private IPlayer _player2;

        public GameManager(IPlayer player1, IPlayer player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public IResult.RoundResult PlayRound()
        {
            IChoice.Choice p1 = _player1.GetChoice();
            IChoice.Choice p2 = _player2.GetChoice();

            Console.WriteLine($"Player 1 picks {p1.ToString()} and Player 2 picks {p2.ToString()}");

            if(Equals(p1, p2))
            {
               return IResult.RoundResult.Draw;
            }
            if(p1 == IChoice.Choice.Rock && p2 == IChoice.Choice.Scissors ||
               p1 == IChoice.Choice.Paper && p2 == IChoice.Choice.Rock ||
               p1 == IChoice.Choice.Scissors && p2 == IChoice.Choice.Paper)
            {
                return IResult.RoundResult.Player1Win;
            }

            return IResult.RoundResult.Player2Win;
        }
    }
}
