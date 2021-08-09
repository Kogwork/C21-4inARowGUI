using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C21_Ex02_AlexBreger_205580087_DannyKogel_318503257
{
    class GamePlay
    {
        private const string mk_PositiveAnswer = "y";
        private const string mk_NegativeAnswer = "n";
        private int m_RoundCounter;
        private Board m_Board;
        private bool m_IsAgainstAi;
        private bool m_IsAnotherRound;
        private bool m_IsGameOn;
        private Player m_Player1;
        private Player m_Player2;
        private Chips m_Chips;
        private BoardUi m_BoardUi;

        public GamePlay(Board board)
        {
            Board = board;
            IsGameOn = true;
            RoundCounter = 0;
            Chips = new Chips();
        }

        private bool checkIfPlayerWantsAnotherRound()
        {
            bool isAnotherRound = true;
            string userInput;
            do
            {
                Console.WriteLine(string.Format("Please enter '{0}' if you want to play another round and '{1}' if you want to finish the game", mk_PositiveAnswer, mk_NegativeAnswer));
                userInput = Console.ReadLine();
            } while (!checkUserInputForYesNo(userInput));

            if (userInput.ToLower().Equals(mk_NegativeAnswer))
            {
                isAnotherRound = false;
            }

            return isAnotherRound;
        }

        private bool checkIfPlayAgainstAi()
        {
            bool isAgainstAi = true;
            string userInput;
            do
            {
                Console.WriteLine(string.Format("Please enter '{0}' if you want to play against AI and '{1}' if you want to play against a human", mk_PositiveAnswer, mk_NegativeAnswer));
                userInput = Console.ReadLine();
            } while (!checkUserInputForYesNo(userInput));

            if (userInput.ToLower().Equals(mk_NegativeAnswer))
            {
                isAgainstAi = false;
            }

            return isAgainstAi;
        }

        private bool checkUserInputForYesNo(string i_UserInput)
        {
            bool checkInput = true;
            if(!(i_UserInput.ToLower().Equals(mk_PositiveAnswer) || i_UserInput.ToLower().Equals(mk_NegativeAnswer)))
            {
                checkInput = false;
            }
            return checkInput;
        }

        public void GameOn()
        {
            Player currentPlayer;
            Player1 = new Player(Board, !IsAgainstAi);
            IsAgainstAi = true;

            if (checkIfPlayAgainstAi())
            {
                Player2 = new Player(Board, IsAgainstAi);
                Player1.PlayerTurn = true;
            }
            else
            {
                Random randomTurnGenerator = new Random();
                bool randomTurnIndicator;
                Player2 = new Player(Board, !IsAgainstAi);
                randomTurnIndicator = randomTurnGenerator.NextDouble() > 0.5;
                Player1.PlayerTurn = randomTurnIndicator;
                Player2.PlayerTurn = !randomTurnIndicator;
            }


            while (IsGameOn)
            {
                if (Player1.PlayerTurn)
                {
                    currentPlayer = Player1;
                }
                else
                {
                    currentPlayer = Player2;
                }

                makeAMove(currentPlayer);
                BoardUi.PrintBoard();
                //clear board

                if (checkWinCondition(currentPlayer))
                {
                    if (!checkIfPlayerWantsAnotherRound())
                    {
                        IsGameOn = false;
                        break;
                    }
                }
            }
        }

        private void makeAMove(Player i_Player)
        {
            i_Player.InsertIntoBoard();
        }

        private bool checkWinCondition(Player i_Player)
        {
            bool winCondition = false;
            byte counterOfChips = 0;

            /*for (int j = 0; j < Board.Columns - 3; j++)
            {
                for (int i = 0; i < Board.Rows; i++)
                {
                    if (Board.BoardMatrix[i_Player.LastRowInsertion, j].PlayerSymbol == player && Board.BoardMatrix[i_Player.LastRowInsertion, j + 1].PlayerSymbol == player && Board.BoardMatrix[i_Player.LastRowInsertion, j + 2].PlayerSymbol == player && Board.BoardMatrix[i_Player.LastRowInsertion, j + 3].PlayerSymbol == player)
                    {
                        return true;
                    }
                }
            }

            for (int i = 0; i < Board.Columns - 3; i++)
            {
                for (int j = 0; j < Board.Rows; j++)
                {
                    if (Board.BoardMatrix[i_Player.LastRowInsertion, i].PlayerSymbol == player && this.board[i + 1][j] == player && this.board[i + 2][j] == player && this.board[i + 3][j] == player)
                    {
                        return true;
                    }
                }
            }

            for (int i = 3; i < Board.Columns; i++)
            {
                for (int j = 0; j < Board.Rows - 3; j++)
                {
                    if (this.board[i][j] == player && this.board[i - 1][j + 1] == player && this.board[i - 2][j + 2] == player && this.board[i - 3][j + 3] == player)
                        return true;
                }
            }

            for (int i = 3; i < Board.Columns; i++)
            {
                for (int j = 3; j < Board.Rows; j++)
                {
                    if (Board.BoardMatrix[i_Player.LastRowInsertion, i].PlayerSymbol == player && this.board[i - 1][j - 1] == player && this.board[i - 2][j - 2] == player && this.board[i - 3][j - 3] == player)
                        return true;
                }
            }
            return false;
            ===========================================================================================================================*/
            for (int i = 0; i < Board.Columns; i++)
            {
                if(Board.BoardMatrix[i_Player.LastRowInsertion,i].PlayerSymbol == i_Player.PlayerSymbol)
                {
                    counterOfChips++;
                    if (counterOfChips == 4)
                    {
                        Console.WriteLine(string.Format("{0} won!", i_Player.Name));
                        winCondition = true;
                        break;
                    }
                }
                else
                {
                    counterOfChips = 0;
                }
            }

            counterOfChips = 0;
            for (int i = 0; !winCondition && i < Board.Rows; i++)
            {
                if (Board.BoardMatrix[i, i_Player.LastColumnInsertion].PlayerSymbol == i_Player.PlayerSymbol)
                {
                    counterOfChips++;
                    if (counterOfChips == 4)
                    {
                        Console.WriteLine(string.Format("{0} won!", i_Player.Name));
                        winCondition = true;
                        break;
                    }
                }
                else
                {
                    counterOfChips = 0;
                } 
            }

            for (int i = 3; i < Board.Columns; i++)
            {
                for (int j = 0; j < Board.Rows - 3; j++)
                {
                    if (Board.BoardMatrix[i, i_Player.LastColumnInsertion].PlayerSymbol == i_Player.PlayerSymbol)
                    {
                        counterOfChips++;
                        if (counterOfChips == 4)
                        {
                            Console.WriteLine(string.Format("{0} won!", i_Player.Name));
                            winCondition = true;
                            break;
                        }
                        else
                        {
                            counterOfChips = 0;
                        }
                    }
                }
            }

            for (int i = 3; i < Board.Rows; i++)
            {
                for (int j = 3; j < Board.Columns; j++)
                {
                    if (Board.BoardMatrix[i, i_Player.LastColumnInsertion].PlayerSymbol == i_Player.PlayerSymbol)
                    {
                        counterOfChips++;
                        if (counterOfChips == 4)
                        {
                            Console.WriteLine(string.Format("{0} won!", i_Player.Name));
                            winCondition = true;
                            break;
                        }
                        else
                        {
                            counterOfChips = 0;
                        }
                    }
                }
            }
            return winCondition;
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

        public Player Player1
        {
            get
            {
                return m_Player1;
            }

            set
            {
                m_Player1 = value;
            }
        }

        public Player Player2
        {
            get
            {
                return m_Player2;
            }

            set
            {
                m_Player2 = value;
            }
        }
        public bool IsAgainstAi
        {
            get
            {
                return m_IsAgainstAi;
            }

            set
            {
                m_IsAgainstAi = value;
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
        public int RoundCounter
        {
            get
            {
                return m_RoundCounter;
            }

            set
            {
                m_RoundCounter = value;
            }
        }
        public bool IsGameOn
        {
            get
            {
                return m_IsGameOn;
            }

            set
            {
                m_IsGameOn = value;
            }
        }
        public bool IsAnotherRound
        {
            get
            {
                return m_IsAnotherRound;
            }

            set
            {
                m_IsAnotherRound = value;
            }
        }
    }
}