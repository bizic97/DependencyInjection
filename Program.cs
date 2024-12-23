using DI.Vezbanje.Models;
using System.Threading.Channels;

GameManager gm = new GameManager(new HumanPlayer(), new ComputerPlayer());

do
{
    IResult.RoundResult roundResult = gm.PlayRound();

    if (roundResult == IResult.RoundResult.Player1Win)
    {
        Console.WriteLine("Player 1 wins!");
    }
    else if (roundResult == IResult.RoundResult.Player2Win)
    {
        Console.WriteLine("Player 2 wins!");
    }
    else
    {
        Console.WriteLine("It's a draw!");
    }

    Console.WriteLine("Play again? (Y/N)");
} while (Console.ReadLine().ToUpper() == "Y");