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
        private BoardNode[,] m_BoardMatrix;
        private int[] m_ArrayToCheckUserInsertion;
        //BoardNode m_BoardNode;
        

        public Board()
        {
            Rows = userInput();
            Columns = userInput();
            BoardMatrix = InitializeMatrix();
            ArrayToCheckUserInsertion = initializeArray();
        }

        private int[] initializeArray()
        {
            int[] arrayToCheckUserInsertion = new int[Columns];
            for (int i = 0; i < arrayToCheckUserInsertion.Length; i++){
                arrayToCheckUserInsertion[i] = Rows;
            }

            return arrayToCheckUserInsertion;
        }

        public BoardNode[,] InitializeMatrix()
        {
            BoardMatrix = new BoardNode[Rows, Columns];
            for (int row = 0; row < Rows; row++)
            {
                for (int column = 0; column < Columns; column++)
                {
                    BoardMatrix[row, column] = new BoardNode();
                }
            }

            return BoardMatrix;
        }

        public bool checkUserInputIntoBoard(int i_UserInput)
        {
            return i_UserInput < Columns + 1 && ArrayToCheckUserInsertion[i_UserInput - 1] > 0 && i_UserInput > 0;
        }

        public bool IsBoardFull()
        {
            bool flagToCheckZeroesInArray = true;
            for (int i = 0; i < ArrayToCheckUserInsertion.Length; i++)
            {
                if (ArrayToCheckUserInsertion[i] != 0)
                {
                    flagToCheckZeroesInArray = false;
                    break;
                }
            }

            return flagToCheckZeroesInArray;
        }

        private static bool checkBoardSizeLimits(byte value)
        {
            bool isSizeLimitOk = true;
            if (value > mk_MaxSize || value < mk_MinSize)
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
                    Console.WriteLine(string.Format("Input your choice for width size, should be atleast {0} and no more than {1}:", mk_MinSize, mk_MaxSize));
                }
                else
                {
                    Console.WriteLine(string.Format("Input your choice for height size, should be atleast {0} and no more than {1}:", mk_MinSize, mk_MaxSize));
                }
                input = Console.ReadLine();
            } while (!(Byte.TryParse(input, out inputInByte) && checkBoardSizeLimits(inputInByte)));

            return inputInByte;
        }

        public Screen Screen
        {
            get
            {
                return m_Screen;
            }

            set
            {
                m_Screen = value;
            }
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
