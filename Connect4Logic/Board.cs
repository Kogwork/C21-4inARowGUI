using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Connect4Logic
{
    public class Board
    {
        public static readonly int sr_MaxSize = 8;
        public static readonly int sr_MinSize = 4;
        private static int m_Rows;
        private static int m_Columns;
        private BoardNode[,] m_BoardMatrix;
        private int[] m_ArrayToCheckUserInsertion;

        public Board()
        {
        }

        public int[] ArrayToCheckUserInsertion
        {
            get
            {
                return m_ArrayToCheckUserInsertion;
            }

            set
            {
                m_ArrayToCheckUserInsertion = value;
            }
        }

        public int Rows
        {
            get
            {
                return m_Rows;
            }

            set
            {
                m_Rows = value;
            }
        }

        public int Columns
        {
            get
            {
                return m_Columns;
            }

            set
            {
                m_Columns = value;
            }
        }

        public BoardNode[,] BoardMatrix
        {
            get
            {
                return m_BoardMatrix;
            }

            set
            {
                m_BoardMatrix = value;
            }
        }

        public void InitializeArray()
        {
            ArrayToCheckUserInsertion = new int[Columns];
            for (int i = 0; i < ArrayToCheckUserInsertion.Length; i++)
            {
                ArrayToCheckUserInsertion[i] = Rows - 1;
            }
        }

        public void InitializeMatrix()
        {
            BoardMatrix = new BoardNode[Rows, Columns];
            for (int row = 0; row < Rows; row++)
            {
                for (int column = 0; column < Columns; column++)
                {
                    BoardMatrix[row, column] = new BoardNode();
                }
            }
        }

        public bool checkUserInputIntoBoard(int i_UserInput)
        {
            return ArrayToCheckUserInsertion[i_UserInput] > -1;
        }

        public bool IsBoardFull()
        {
            bool flagToCheckZeroesInArray = true;
            for (int i = 0; i < ArrayToCheckUserInsertion.Length; i++)
            {
                if (ArrayToCheckUserInsertion[i] != -1)
                {
                    flagToCheckZeroesInArray = false;
                    break;
                }
            }

            return flagToCheckZeroesInArray;
        }
    }
}
