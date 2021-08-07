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
        private static int m_playerId = 0;
        
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
            do
            {
                Console.WriteLine("Please choose a column to insert the toekn into");
            } while (!checkUserInput())

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
