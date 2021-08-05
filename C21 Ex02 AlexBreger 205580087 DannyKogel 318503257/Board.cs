using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C21_Ex02_AlexBreger_205580087_DannyKogel_318503257
{
    
    class Board
    {
        private const byte mk_MaxSize = 8;
        private const byte mk_MinSize = 4;
        private static byte m_Rows;
        private static byte m_Columns;
        BoardNode[,] m_BoardMatrix;
        //BoardNode m_BoardNode;
        //Ex02.ConsoleUtils.Screen m_Screen = new Ex02.ConsoleUtils.Screen();

        public Board()
        {
            Rows = userInput();
            Columns = userInput();
            BoardMatrix = initializeMatrix(Rows, Columns);
            
        }

        private BoardNode[,] initializeMatrix(int i_Rows, int i_Columns)
        {
            BoardMatrix = new BoardNode[Rows, Columns];
            for (int row = 0; row < i_Rows; row++)
            {
                for (int column = 0; column < i_Columns; column++)
                {
                    BoardMatrix[row, column] = new BoardNode();
                }
            }

            return BoardMatrix;
        }

        public static byte Rows
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

        public static byte Columns
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

        private static bool checkBoardSizeLimits(byte value)
        {
            bool isSizeLimitOk = true;
            if(value > mk_MaxSize || value < mk_MinSize)
            {
                isSizeLimitOk = false;
            }

            return isSizeLimitOk;
        }

        private byte userInput()
        {
            string input;
            byte inputInByte;

            do
            {
                if (Rows <= mk_MaxSize && Rows >= mk_MinSize)
                {
                    Console.WriteLine(string.Format("Input your choice for column size, should be atleast {0} and no more than {1}:", mk_MinSize, mk_MaxSize));
                }
                else
                {
                    Console.WriteLine(string.Format("Input your choice for row size, should be atleast {0} and no more than {1}:", mk_MinSize, mk_MaxSize));
                }
                input = Console.ReadLine();
            } while (!(Byte.TryParse(input, out inputInByte) && checkBoardSizeLimits(inputInByte)));

            return inputInByte;
        }

        /*public BoardNode BoardNode
        {
            get
            {
                return m_BoardNode;
            }

            set
            {
                m_BoardNode = value;
            }
        }*/

        /*private static bool checkInputInteger(string i_UserInput)
        {
            string regexPatternForNumbersInputCheck = @"^\d+$";

            return Regex.IsMatch(i_UserInput, regexPatternForNumbersInputCheck);
        }*/
    }
}
