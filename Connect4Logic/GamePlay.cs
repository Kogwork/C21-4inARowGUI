using System;


namespace Connect4Logic
{
    public class GamePlay
    {
        private int m_RoundCounter;
        private Board m_Board;
        private bool m_IsAnotherRound;
        private bool m_IsGameOn;
        private Player m_Player1;
        private Player m_Player2;
        private Chips m_Chips;

        public GamePlay(Board i_Board)
        {
            Board = i_Board;
            IsGameOn = true;
            RoundCounter = 0;
            Chips = new Chips();
            Player1 = new Player();
            Player1.PlayerSymbol = Chips.ChipsList[0];
            Player1.Board = Board;
            Player1.changeTurnState();
            Player2 = new Player();
            Player2.PlayerSymbol = Chips.ChipsList[1];
            Player2.Board = Board;
            Player2.IsAi = true;
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

        public void makeAMove(Player i_Player,int i_Input)
        {
            i_Player.InsertIntoBoard(i_Input);
        }

        public bool checkWinCondition(Player i_Player)
        {
            bool winCondition = false;
            byte counterOfChips = 0;

            for (int i = 0; i < Board.Columns; i++)
            {
                if (Board.BoardMatrix[i_Player.LastRowInsertion, i].PlayerSymbol == i_Player.PlayerSymbol)
                {
                    counterOfChips++;
                    if (counterOfChips == 4)
                    {
                        //Console.WriteLine(string.Format("{0} won with a row!", i_Player.Name));
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
                        //Console.WriteLine(string.Format("{0} won with a column!", i_Player.Name));
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

            for (int i = -3; !winCondition && i < 4; i++)
            {
                    if (i_Player.LastColumnInsertion + i < Board.Columns && i_Player.LastColumnInsertion + i >= 0 && i_Player.LastRowInsertion + i < Board.Rows && i_Player.LastRowInsertion + i >= 0)
                    {
                        if (Board.BoardMatrix[i_Player.LastRowInsertion + i, i_Player.LastColumnInsertion + i].PlayerSymbol == i_Player.PlayerSymbol)
                        {
                            counterOfChips++;
                            if (counterOfChips == 4)
                            {
                                //Console.WriteLine(string.Format("{0} won with a diagonal!", i_Player.Name));
                                winCondition = true;
                                break;
                            }
                        }
                        else
                        {
                            counterOfChips = 0;
                        }
                    }
                    else
                    {
                        continue;
                    }
            }

            counterOfChips = 0;
            for (int i = -3; !winCondition && i < 4; i++)
            {
                if (i_Player.LastColumnInsertion + i < Board.Columns && i_Player.LastColumnInsertion + i >= 0 && i_Player.LastRowInsertion - i < Board.Rows && i_Player.LastRowInsertion - i >= 0)
                {
                    if (Board.BoardMatrix[i_Player.LastRowInsertion - i, i_Player.LastColumnInsertion + i].PlayerSymbol == i_Player.PlayerSymbol)
                    {
                        counterOfChips++;
                        if (counterOfChips == 4)
                        {
                            //Console.WriteLine(string.Format("{0} won with a diagonal!", i_Player.Name));
                            winCondition = true;
                            break;
                        }
                    }
                    else
                    {
                        counterOfChips = 0;
                    }
                }
                else
                {
                    continue;
                }
            }

            return winCondition;
        }
    }
}