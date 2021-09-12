using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4GUI
{
    public class ControlButton : Button
    {
        public static readonly int sr_ControlButtonDeafultSize = 40;

        private int m_ControlsColumn;
        private GameBoardGUI m_CurrentGameBoard;
        private Connect4Logic.GamePlay m_GameBoard;
        private Connect4Logic.Player m_CurrentPlayer;

        public ControlButton(int i_count, GameBoardGUI i_CurrentGameBoard, Connect4Logic.GamePlay i_GameBoard) 
        {
            ControlsColumn = i_count;
            CurrentGameBoard = i_CurrentGameBoard;
            GameBoard = i_GameBoard;
            ControlButtonDesign();
        }

        private void ControlButtonDesign() 
        {
            this.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.FlatAppearance.BorderSize = 2;
            this.FlatStyle = FlatStyle.Flat;
            this.Name = string.Format("ControlButton{0}", ControlsColumn);
            this.Size = new System.Drawing.Size(sr_ControlButtonDeafultSize, sr_ControlButtonDeafultSize);
            this.Text = string.Format("{0}\n⇩", ControlsColumn);
            this.Click += new EventHandler(this.ControlButton_Click);
        }

        private void ControlButton_Click(object sender, EventArgs e)
        {
            CurrentGameBoard.UpdateBoardCells(GameBoard.Board.ArrayToCheckUserInsertion[ControlsColumn - 1], ControlsColumn - 1);
            CurrentPlayer.InsertIntoBoard(ControlsColumn);
            CurrentGameBoard.CheckIfThereIsAWinner();

            if (!GameBoard.Board.checkUserInputIntoBoard(ControlsColumn - 1)) 
            {
                this.Enabled = false;
                this.Text = this.Text = string.Format("{0}\n✖", ControlsColumn);
                this.BackColor = System.Drawing.Color.IndianRed;
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

        public GameBoardGUI CurrentGameBoard
        {
            get
            {
                return m_CurrentGameBoard;
            }

            set
            {
                m_CurrentGameBoard = value;
            }
        }

        public int ControlsColumn
        {
            get
            {
                return m_ControlsColumn;
            }

            set
            {
                m_ControlsColumn = value;
            }
        }
    }
}
