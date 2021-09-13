using System;
using System.Drawing;
using System.Windows.Forms;

namespace Connect4GUI
{
    public partial class GameBoardGUI : Form
    {
        private PlayerControls m_PlayerControls;
        private CelllButton[,] m_BoardCells;

        public GameBoardGUI()
        {
            InitializeComponent();
        }

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

        public void UpdateBoardGui()
        {
            LabelCurrentTurn.Text = string.Format(
                "Current Turn: {0}", SettingsWindow.s_Gameplay.Player1.Name);
            LabelCurrentRound.Text = string.Format(
                "Round #{0}", SettingsWindow.s_Gameplay.RoundCounter + 1);
            LabelPlayer1WinCount.Text = string.Format(
                "{0}: {1}", SettingsWindow.s_Gameplay.Player1.Name, SettingsWindow.s_Gameplay.Player1.Score);
            LabelPlayer2WinCount.Text = string.Format(
                "{0}: {1}", SettingsWindow.s_Gameplay.Player2.Name, SettingsWindow.s_Gameplay.Player2.Score);
            BoardCells = new CelllButton[SettingsWindow.s_Gameplay.Board.Rows, SettingsWindow.s_Gameplay.Board.Columns];
            PlayerControls = new PlayerControls(
            SettingsWindow.s_Gameplay, SettingsWindow.s_Gameplay.Player1, SettingsWindow.s_Gameplay.Player2);
            GridGameBoard.ColumnCount = SettingsWindow.s_Board.Columns;
            GridGameBoard.RowCount = SettingsWindow.s_Board.Rows;
            PlayerControls.BoardGUI = this;
            intalizeControlButtons(GridGameBoard);
            intalizeCellButtons(GridGameBoard);
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

        public bool CheckIfThereIsAWinner() 
        {
            bool endGame = false;

            if (SettingsWindow.s_Gameplay.checkWinCondition(PlayerControls.CurrentPlayer))
            {
                PlayerControls.CurrentPlayer.Score += 1;
                endGamePromptWin();
                endGame = true;
            }

            if (SettingsWindow.s_Gameplay.Board.IsBoardFull()) 
            {
                endGamePromptTie();
                endGame = true;
            }

            PlayerControls.SwapTurn();
            LabelCurrentRoundUpdate();

            return endGame;
        }

        public void LabelCurrentRoundUpdate()
        {
            LabelCurrentTurn.Text = string.Format("Current Turn: {0}", PlayerControls.CurrentPlayer.Name);
        }

        private void endGamePromptWin() 
        {
            DialogResult winMsg = MessageBox.Show(string.Format("{0} Won!!\nAnother Round?", PlayerControls.CurrentPlayer.Name), "A Win!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (winMsg == DialogResult.Yes)
            {
                resetBoardAndGame();
            }
            else if (winMsg == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void endGamePromptTie()
        {
            DialogResult winMsg = MessageBox.Show("Tie!!\nAnother Round?", "A Tie!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (winMsg == DialogResult.Yes)
            {
                resetBoardAndGame();
            }
            else if (winMsg == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void resetBoardAndGame() 
        {
            SettingsWindow.s_Board.InitializeArray();
            SettingsWindow.s_Board.InitializeMatrix();
            SettingsWindow.s_Gameplay.RoundCounter++;
            SettingsWindow.s_Gameplay.Player1.PlayerTurn = false;
            GridGameBoard.Controls.Clear();
            UpdateBoardGui();
        }

        private void GameBoardGUI_Load(object sender, EventArgs e)
        {
            UpdateBoardGui();
        }
    }
}
