using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C21_Ex02_AlexBreger_205580087_DannyKogel_318503257
{
    class BoardUi
    {
        private Board m_Board;
       
        public BoardUi(Board board)
        {
            Board = board;
        }

        public Board Board
        {
            get
            {
                return m_Board;
            }

            set
            {
                m_Board = value;
            }
        }

        public void PrintBoard()
        {
            Console.Write(string.Format(" "));

            for (int column = 0; column < Board.Columns; column++)
            {
                Console.Write(string.Format(" {0} ", column + 1));
            }
            Console.WriteLine();

            for(int row = 0; row < Board.Rows; row++)
            {
                for(int column = 0; column < Board.Columns; column++)
                {
                    Console.Write(string.Format("| {0} ", Board.BoardMatrix[row,column].PlayerSymbol));
                }
                
                Console.WriteLine("|");
                string seperator = new String('=', Board.Columns * 3 + 1);
                Console.WriteLine(seperator);
            }
        }
    }
}