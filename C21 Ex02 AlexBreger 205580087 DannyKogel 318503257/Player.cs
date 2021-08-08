using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C21_Ex02_AlexBreger_205580087_DannyKogel_318503257
{
    class Player
    {
        private string m_Name;
        private int m_NumberOfWins;
        private Board m_Board;
        private string m_PlayerSymbol;
        private bool m_IsAi;
        private bool m_PlayerTurn;

        public Player(Board board)
        {
            Name = initPlayerName();
            Board = board;
        }

        private string initPlayerName()
        {
            Console.WriteLine("Please enter your name");
            return Console.ReadLine();
        }

        private void insertIntoBoard()
        {
            byte inputInByte;
            string userInput;
            do
            {
                Console.WriteLine(string.Format("{0} please choose a column number to insert the token into", Name));
                userInput = Console.ReadLine();
            } while (!(Byte.TryParse(userInput, out inputInByte) && Board.checkUserInputIntoBoard(inputInByte)));

            Board.BoardMatrix[Board.ArrayToCheckUserInsertion[inputInByte - 1], inputInByte - 1].PlayerSymbol = PlayerSymbol;
        }

       

        public bool PlayerTurn
        {
            get
            {
                return m_PlayerTurn;
            }

            set
            {
                m_PlayerTurn = value;
            }
        }
        
        public bool IsAi
        {
            get
            {
                return m_IsAi;
            }

            set
            {
                m_IsAi = value;
            }
        }
        public string PlayerSymbol
        {
            get
            {
                return m_PlayerSymbol;
            }

            set
            {
                m_PlayerSymbol = value;
            }
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
        public string Name
        {
            get
            {
                return m_Name;
            }

            set
            {
                m_Name = value;
            }
        }

        public int Score
        {
            get
            {
                return m_NumberOfWins;
            }

            set
            {
                m_NumberOfWins = value;
            }
        }
    }
}
