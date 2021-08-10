using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C21_Ex02_AlexBreger_205580087_DannyKogel_318503257
{
    class Player
    {
        private const string mk_StopRound = "q";
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

        public Player(Board i_Board, bool i_IsAi, Chips i_Chips, BoardUi i_BoardUi)
        {
            BoardUi = i_BoardUi;
            IsAi = i_IsAi;
            initPlayerName();
            Board = i_Board;
            PlayerTurn = false;
            IsGameTerminatedByPlayer = false;
            Chips = i_Chips;
            choosePlayerSymbol();
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
                Name = "CPU";
            }
        }

        public void InsertIntoBoard()
        {
            Random randomInputForAi = new Random();
            int inputInInt = -1;
            string userInput;

            if (!IsAi)
            {
                do
                {
                    userInput = BoardUi.PlayerInsertIntoBoard(Name);
                    if (userInput.ToLower() == mk_StopRound)
                    {
                        IsGameTerminatedByPlayer = true;
                        return;
                    }
                } while (!(int.TryParse(userInput, out inputInInt) && Board.checkUserInputIntoBoard(inputInInt - 1)));
            }
            else
            {
                do
                {
                    inputInInt = randomInputForAi.Next(1, Board.Columns + 1);
                } while (!Board.checkUserInputIntoBoard(inputInInt - 1));
            }

            inputInInt--;

            LastColumnInsertion = inputInInt;
            LastRowInsertion = Board.ArrayToCheckUserInsertion[inputInInt];
            Board.BoardMatrix[Board.ArrayToCheckUserInsertion[inputInInt], inputInInt].PlayerSymbol = PlayerSymbol;
            Board.ArrayToCheckUserInsertion[inputInInt] = Board.ArrayToCheckUserInsertion[inputInInt] - 1;
        }

        public void changeTurnState()
        {
            PlayerTurn = !PlayerTurn;
        }

        private void choosePlayerSymbol()
        {
            string userInput;

            if (!IsAi)
            {
                do
                {
                    userInput = BoardUi.PlayerChoosePlayerSymbol(Chips.ChipsList);
                } while (!Chips.ChipsList.Contains(userInput));

                Chips.ChipsList.Remove(userInput);
                PlayerSymbol = userInput;
            }
            else
            {
                PlayerSymbol = Chips.ChipsList.Last();
            }
        }
    }
}
