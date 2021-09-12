﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4GUI
{
    public partial class GameBoardGUI : Form
    {
        private PlayerControls m_PlayerControls;
        private CelllButton[,] m_BoardCells;

        public PlayerControls PlayerControls
        {
            get
            {
                return m_PlayerControls;
            }

            set
            {
                m_PlayerControls = value;
            }
        }

        public CelllButton[,] BoardCells
        {
            get
            {
                return m_BoardCells;
            }

            set
            {
                m_BoardCells = value;
            }
        }

        public GameBoardGUI()
        {
            InitializeComponent();
        }

        private void GameBoardGUI_Load(object sender, EventArgs e)
        {
            UpdateBoardGui();
        }

        public void UpdateBoardGui()
        {
            LabelCurrentTurn.Text = string.Format(
                "Current Turn: {0}", SettingsWindow.S_Gameplay.Player1.Name);
            LabelCurrentRound.Text = string.Format(
                "Round #{0}", SettingsWindow.S_Gameplay.RoundCounter + 1);
            LabelPlayer1WinCount.Text = string.Format(
                "{0}: {1}", SettingsWindow.S_Gameplay.Player1.Name, SettingsWindow.S_Gameplay.Player1.Score);
            LabelPlayer2WinCount.Text = string.Format(
                "{0}: {1}", SettingsWindow.S_Gameplay.Player2.Name, SettingsWindow.S_Gameplay.Player2.Score);
            BoardCells = new CelllButton[SettingsWindow.S_Gameplay.Board.Rows, SettingsWindow.S_Gameplay.Board.Columns];
            PlayerControls = new PlayerControls(
            SettingsWindow.S_Gameplay, SettingsWindow.S_Gameplay.Player1, SettingsWindow.S_Gameplay.Player2);
            GridGameBoard.ColumnCount = SettingsWindow.s_Board.Columns;
            GridGameBoard.RowCount = SettingsWindow.s_Board.Rows;
            PlayerControls.BoardGUI = this;
            IntalizeControlButtons(GridGameBoard);
            IntalizeCellButtons(GridGameBoard);
        }

        public void UpdateBoardCells(int i_Row, int i_Col) 
        {
            m_BoardCells[i_Row, i_Col].Text = PlayerControls.CurrentPlayer.PlayerSymbol;
            if (PlayerControls.CurrentPlayer == PlayerControls.Player1) 
            {
                m_BoardCells[i_Row, i_Col].BackColor = Color.Red;
            }
            else 
            {
                m_BoardCells[i_Row, i_Col].BackColor = Color.Yellow;
            }
        }

        public void CheckIfThereIsAWinner() 
        {
            if (SettingsWindow.S_Gameplay.checkWinCondition(PlayerControls.CurrentPlayer))
            {
                PlayerControls.CurrentPlayer.Score += 1;
                DialogResult winMsg = MessageBox.Show(string.Format("{0} Won!!\nAnother Round?", PlayerControls.CurrentPlayer.Name), "A Win!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (winMsg == DialogResult.Yes)
                {
                    SettingsWindow.s_Board.InitializeArray();
                    SettingsWindow.s_Board.InitializeMatrix();
                    SettingsWindow.S_Gameplay.RoundCounter++;
                    GridGameBoard.Controls.Clear();
                    UpdateBoardGui();
                }
                else if (winMsg == DialogResult.No)
                {
                    Application.Exit();
                }
                return;
            }
            PlayerControls.SwapTurn();
            LabelCurrentRoundUpdate();
        }

        public void LabelCurrentRoundUpdate()
        {
            LabelCurrentTurn.Text = string.Format("Current Turn: {0}", PlayerControls.CurrentPlayer.Name);
        }

        private void LabelPlayer2WinCount_Click(object sender, EventArgs e)
        {

        }

        private void LabelCurrentTurn_Click(object sender, EventArgs e)
        {

        }
    }
}