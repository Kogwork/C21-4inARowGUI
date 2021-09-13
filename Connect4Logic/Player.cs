using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4Logic
{
    public class Player
    {
        public static readonly string sr_DeafultComputerName = "[Computer]";
        private string m_Name;
        private int m_NumberOfWins;
        private Board m_Board;
        private string m_PlayerSymbol;
        private bool m_IsAi;
        private bool m_PlayerTurn;
        private int m_LastRowInsertion;
        private int m_LastColumnInsertion;
        private Chips m_Chips;
        private bool m_IsGameTerminatedByPlayer;
        private BoardUi m_BoardUi;

        public Player()
        {
        }

        public Player(Board i_Board, bool i_IsAi, Chips i_Chips)
        {
            IsAi = i_IsAi;
            initPlayerName();
            Board = i_Board;
            PlayerTurn = false;
            IsGameTerminatedByPlayer = false;
            Chips = i_Chips;
        }

        public bool IsGameTerminatedByPlayer
        {
            get
            {
                return m_IsGameTerminatedByPlayer;
            }

            set
            {
                m_IsGameTerminatedByPlayer = value;
            }
        }

        public Chips Chips
        {
            get
            {
                return m_Chips;
            }

            set
            {
                m_Chips = value;
            }
        }

        public int LastRowInsertion
        {
            get
            {
                return m_LastRowInsertion;
            }

            set
            {
                m_LastRowInsertion = value;
            }
        }

        public int LastColumnInsertion
        {
            get
            {
                return m_LastColumnInsertion;
            }

            set
            {
                m_LastColumnInsertion = value;
            }
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

        public BoardUi BoardUi
        {
            get
            {
                return m_BoardUi;
            }

            set
            {
                m_BoardUi = value;
            }
        }

        private void initPlayerName()
        {
            if (!IsAi)
            {
                Name = BoardUi.PlayerInitPlayerName();
            }
            else
            {
                Name = sr_DeafultComputerName;
            }
        }

        public void InsertIntoBoard(int i_UserInput)
        {
            i_UserInput--;

            LastColumnInsertion = i_UserInput;
            LastRowInsertion = Board.ArrayToCheckUserInsertion[i_UserInput];
            Board.BoardMatrix[Board.ArrayToCheckUserInsertion[i_UserInput], i_UserInput].PlayerSymbol = PlayerSymbol;
            Board.ArrayToCheckUserInsertion[i_UserInput] = Board.ArrayToCheckUserInsertion[i_UserInput] - 1;
        }

        public void changeTurnState()
        {
            PlayerTurn = !PlayerTurn;
        }
    }
}
