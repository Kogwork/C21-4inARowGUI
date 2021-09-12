using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4Logic
{
    public class Program
    {
        public static void notMian()
        {
            Board board = new Board();
            BoardUi boardUi = new BoardUi(board);
            GamePlay gamePlay = new GamePlay(board);
            gamePlay.GameOn();
            Console.ReadKey();
        }
    }
}
