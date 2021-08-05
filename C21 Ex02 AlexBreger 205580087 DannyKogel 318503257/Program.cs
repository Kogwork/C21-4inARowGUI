using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C21_Ex02_AlexBreger_205580087_DannyKogel_318503257
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            BoardUi boardUi = new BoardUi(board);
            GamePlay gamePlay = new GamePlay(board);
            Console.ReadKey();
        }
        // Board Class - done
        // Chip Class (options to pick from) - done
        // Initiate GamePlay method (that indicates if the game is on) ('Q' stops the game and gives a point to the oponnent) - done
        // Intiate board size method - done
        // PVE or PVP game (if pve, user starts) - done
        // Print board method - done
        // Insert into board method
        // Check if column full method
        // Check if win condition is true (WIN OR TIE)
        // Initiate player's turn method?
        // If game ends, ask for another round. If another round, continue with same board size and score.

    }
}
