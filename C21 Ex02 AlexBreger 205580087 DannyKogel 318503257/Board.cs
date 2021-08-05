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
        private static string m_Rows;
        private static string m_Columns;
        //BoardNode boardNode;
        //Ex02.ConsoleUtils.Screen m_Screen = new Ex02.ConsoleUtils.Screen();

        public Board()
        {
            Rows = "10";
            Columns = "10";
            BoardNode[,] board = new BoardNode[byte.Parse(Board.Rows), byte.Parse(Board.Columns)];
        }

        public static string Rows
        {
            get
            {
                return m_Rows;
            }

            set
            {
                do
                {
                    Console.WriteLine(string.Format("Please insert the size of the rows. Should be atleast {0} and no more than {1}"), mk_MinSize, mk_MaxSize);
                    value = Console.ReadLine();
                } while (!(checkInputInteger(value) && checkBoardSizeLimits(value)));
                m_Rows = value;
            }
        }

        public static string Columns
        {
            get
            {
                return m_Columns;
            }

            set
            {
                do
                {
                    Console.WriteLine(string.Format("Please insert the size of the coulmns. should be atleast {0} and no more than {1}"), mk_MinSize, mk_MaxSize);
                    value = Console.ReadLine();
                } while (!(checkInputInteger(value) && checkBoardSizeLimits(value)));
                m_Columns = value;
            }
        }

        private static bool checkBoardSizeLimits(string value)
        {
            bool isSizeLimitOk = true;
            if(int.Parse(value) > 7 || int.Parse(value) < 4)
            {
                isSizeLimitOk = false;
            }

            return isSizeLimitOk;
        }

        private static bool checkInputInteger(string i_UserInput)
        {
            string regexPatternForNumbersInputCheck = @"^\d+$";

            return Regex.IsMatch(i_UserInput, regexPatternForNumbersInputCheck);
        }
    }
}
