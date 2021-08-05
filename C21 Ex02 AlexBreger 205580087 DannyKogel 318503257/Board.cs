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
        private const byte mk_MaxSize = 7;
        private const byte mk_MinSize = 4;
        private static byte m_Rows;
        private static byte m_Columns;
        BoardNode m_BoardNode;
        //Ex02.ConsoleUtils.Screen m_Screen = new Ex02.ConsoleUtils.Screen();

        public Board()
        {
            Rows = userInput();
            Columns = userInput();
            BoardNode[,] board = new BoardNode[Rows, Columns];
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

        public BoardNode BoardNode
        {
            get
            {
                return m_BoardNode;
            }

            set
            {
                m_BoardNode = value;
            }
        }

        private static bool checkBoardSizeLimits(byte value)
        {
            bool isSizeLimitOk = true;
            if(value > 7 || value < 4)
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
                Console.WriteLine(string.Format("Please insert the size of the coulmns and rows. should be atleast {0} and no more than {1}", mk_MinSize, mk_MaxSize));
                input = Console.ReadLine();
            } while (!(Byte.TryParse(input, out inputInByte) && checkBoardSizeLimits(inputInByte)));

            return inputInByte;
        }

        /*private static bool checkInputInteger(string i_UserInput)
        {
            string regexPatternForNumbersInputCheck = @"^\d+$";

            return Regex.IsMatch(i_UserInput, regexPatternForNumbersInputCheck);
        }*/
    }
}
