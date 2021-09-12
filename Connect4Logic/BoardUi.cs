using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4Logic
{
    public class BoardUi
    {
        private const string mk_PositiveAnswer = "y";
        private const string mk_NegativeAnswer = "n";
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

        public bool GamePlayCheckIfPlayerWantsAnotherRound() 
        {
            bool isAnotherRound = true;
            string userInput;
            do
            {
                Console.WriteLine(string.Format("Please enter '{0}' if you want to play another round and '{1}' if you want to finish the game", mk_PositiveAnswer, mk_NegativeAnswer));
                userInput = Console.ReadLine();
            } while (!GamePlayCheckUserInputForYesNo(userInput));

            if (userInput.ToLower().Equals(mk_NegativeAnswer))
            {
                isAnotherRound = false;
            }

            return isAnotherRound;
        }
        public bool GamePlayCheckIfPlayAgainstAi()
        {
            bool isAgainstAi = true;
            string userInput;
            do
            {
                Console.WriteLine(string.Format("Please enter '{0}' if you want to play against AI and '{1}' if you want to play against a human", mk_PositiveAnswer, mk_NegativeAnswer));
                userInput = Console.ReadLine();
            } while (!GamePlayCheckUserInputForYesNo(userInput));

            if (userInput.ToLower().Equals(mk_NegativeAnswer))
            {
                isAgainstAi = false;
            }

            return isAgainstAi;
        }
        public bool GamePlayCheckUserInputForYesNo(string i_UserInput)
        {
            bool checkInput = true;
            if (!(i_UserInput.ToLower().Equals(mk_PositiveAnswer) || i_UserInput.ToLower().Equals(mk_NegativeAnswer)))
            {
                checkInput = false;
            }

            return checkInput;
        }

        public void GamePlayPrintTie(Player i_Player1, Player i_Player2)
        {
            Console.WriteLine(string.Format("It's a Tie! Score {0}: {1} | Score {2}: {3}", i_Player1.Name, i_Player1.Score, i_Player2.Name, i_Player2.Score));
        }

        public void GamePlayPrintScore(Player i_Player1, Player i_Player2)
        {
            Console.WriteLine(string.Format("Score {0}: {1} | Score {2}: {3}", i_Player1.Name, i_Player1.Score, i_Player2.Name, i_Player2.Score));
        }

        public string PlayerInitPlayerName()
        {
            Console.WriteLine("Please enter your name");
            return Console.ReadLine();
        }

        public string PlayerChoosePlayerSymbol(List<string> i_ChipsList)
        {
            Console.WriteLine("Please choose your symbol from the list by entering the corresponding symbol");
            i_ChipsList.ForEach(Console.Write);
            Console.WriteLine();
            return Console.ReadLine();
        }

        public string BoardUserInput(int i_MaxSize, int i_MinSize)
        {
            if (Board.Rows <= i_MaxSize && Board.Rows >= i_MinSize)
            {
                Console.WriteLine(string.Format("Input your choice for width size, should be atleast {0} and no more than {1}:", i_MinSize, i_MaxSize));
            }
            else
            {
                Console.WriteLine(string.Format("Input your choice for height size, should be atleast {0} and no more than {1}:", i_MinSize, i_MaxSize));
            }

            return Console.ReadLine();
        }
        public void PrintBoard()
        {
            Console.Write(string.Format(" "));

            for (int column = 0; column < Board.Columns; column++)
            {
                Console.Write(string.Format(" {0}  ", column + 1));
            }

            Console.WriteLine();

            for (int row = 0; row < Board.Rows; row++)
            {
                for (int column = 0; column < Board.Columns; column++)
                {
                    Console.Write(Board.BoardMatrix[row, column].ToString());
                }
                
                Console.WriteLine("|");
                string seperator = new string('=', (Board.Columns * 4) + 1);
                Console.WriteLine(seperator);
            }
        }
    }
}