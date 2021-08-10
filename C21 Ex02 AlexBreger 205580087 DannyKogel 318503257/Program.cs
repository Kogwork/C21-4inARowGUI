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
            GamePlay gamePlay = new GamePlay(board, boardUi);
            gamePlay.GameOn();
            Console.ReadKey();
        }
    }
}
