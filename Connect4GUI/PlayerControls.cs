using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4GUI
{
    public class PlayerControls
    {
        GameBoardGUI m_BoardGUI;
        Connect4Logic.GamePlay m_GameBoard;
        Connect4Logic.Player m_Player1;
        Connect4Logic.Player m_Player2;
        Connect4Logic.Player m_CurrentPlayer;
        List<ControlButton> m_ControlList = new List<ControlButton>();

        public PlayerControls(
            Connect4Logic.GamePlay i_GameBoard,
            Connect4Logic.Player i_Player1,
            Connect4Logic.Player i_Player2)
        {
            GameBoard = i_GameBoard;
            Player1 = i_Player1;
            Player2 = i_Player2;
            Player1.changeTurnState();
            SwapTurn();
        }

        public void SwapTurn() 
        {
            Player1.changeTurnState();
            Player2.changeTurnState();

            if (Player1.PlayerTurn) 
            {
                CurrentPlayer = Player1;
            }
            else 
            {
                CurrentPlayer = Player2;
            }

            foreach (ControlButton control in ControlList) 
            {
                control.CurrentPlayer = CurrentPlayer;
                DisableFullControls(control.ControlsColumn - 1);
            }

        }

        public void DisableFullControls(int i_Column)
        {
            if (!GameBoard.Board.checkUserInputIntoBoard(i_Column))
            {
                ControlList[i_Column].Enabled = false;
                ControlList[i_Column].Text = ControlList[i_Column].Text = string.Format("{0}\n✖", i_Column);
                ControlList[i_Column].BackColor = System.Drawing.Color.IndianRed;
            }
        }

        public Connect4Logic.Player CurrentPlayer
        {
            get
            {
                return m_CurrentPlayer;
            }

            set
            {
                m_CurrentPlayer = value;
            }
        }

        public GameBoardGUI BoardGUI
        {
            get
            {
                return m_BoardGUI;
            }

            set
            {
                m_BoardGUI = value;
            }
        }

        public Connect4Logic.GamePlay GameBoard
        {
            get
            {
                return m_GameBoard;
            }

            set
            {
                m_GameBoard = value;
            }
        }

        public Connect4Logic.Player Player1
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

        public Connect4Logic.Player Player2
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

        public List<ControlButton> ControlList
        {
            get
            {
                return m_ControlList;
            }

            set
            {
                m_ControlList = value;
            }
        }
    }
}
