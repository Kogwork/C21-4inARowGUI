using System;
using System.Windows.Forms;

namespace Connect4GUI
{
    partial class SettingsWindow : Form
    {
        public static Connect4Logic.Board s_Board = new Connect4Logic.Board();
        public static Connect4Logic.GamePlay S_Gameplay = new Connect4Logic.GamePlay(s_Board);
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.ButtonStart = new System.Windows.Forms.Button();
            this.LabelPlayers = new System.Windows.Forms.Label();
            this.LabelPlayer1 = new System.Windows.Forms.Label();
            this.CheckBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.TextBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.LabelBoardSize = new System.Windows.Forms.Label();
            this.LabelRows = new System.Windows.Forms.Label();
            this.LabelCols = new System.Windows.Forms.Label();
            this.NumericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownCols = new System.Windows.Forms.NumericUpDown();
            this.TextBoxPlayer2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownCols)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(11, 158);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(187, 23);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // LabelPlayers
            // 
            this.LabelPlayers.AutoSize = true;
            this.LabelPlayers.Location = new System.Drawing.Point(11, 8);
            this.LabelPlayers.Name = "LabelPlayers";
            this.LabelPlayers.Size = new System.Drawing.Size(44, 13);
            this.LabelPlayers.TabIndex = 1;
            this.LabelPlayers.Text = "Players:";
            // 
            // LabelPlayer1
            // 
            this.LabelPlayer1.AutoSize = true;
            this.LabelPlayer1.Location = new System.Drawing.Point(25, 33);
            this.LabelPlayer1.Name = "LabelPlayer1";
            this.LabelPlayer1.Size = new System.Drawing.Size(48, 13);
            this.LabelPlayer1.TabIndex = 2;
            this.LabelPlayer1.Text = "Player 1:";
            // 
            // CheckBoxPlayer2
            // 
            this.CheckBoxPlayer2.AutoSize = true;
            this.CheckBoxPlayer2.Location = new System.Drawing.Point(26, 58);
            this.CheckBoxPlayer2.Name = "CheckBoxPlayer2";
            this.CheckBoxPlayer2.Size = new System.Drawing.Size(67, 17);
            this.CheckBoxPlayer2.TabIndex = 3;
            this.CheckBoxPlayer2.Text = "Player 2:";
            this.CheckBoxPlayer2.UseVisualStyleBackColor = true;
            this.CheckBoxPlayer2.CheckedChanged += new System.EventHandler(this.CheckBoxPlayer2_CheckedChanged);
            // 
            // TextBoxPlayer1
            // 
            this.TextBoxPlayer1.Location = new System.Drawing.Point(93, 30);
            this.TextBoxPlayer1.Name = "TextBoxPlayer1";
            this.TextBoxPlayer1.Size = new System.Drawing.Size(106, 20);
            this.TextBoxPlayer1.TabIndex = 4;
            // 
            // LabelBoardSize
            // 
            this.LabelBoardSize.AutoSize = true;
            this.LabelBoardSize.Location = new System.Drawing.Point(11, 95);
            this.LabelBoardSize.Name = "LabelBoardSize";
            this.LabelBoardSize.Size = new System.Drawing.Size(61, 13);
            this.LabelBoardSize.TabIndex = 6;
            this.LabelBoardSize.Text = "Board Size:";
            // 
            // LabelRows
            // 
            this.LabelRows.AutoSize = true;
            this.LabelRows.Location = new System.Drawing.Point(25, 119);
            this.LabelRows.Name = "LabelRows";
            this.LabelRows.Size = new System.Drawing.Size(37, 13);
            this.LabelRows.TabIndex = 7;
            this.LabelRows.Text = "Rows:";
            // 
            // LabelCols
            // 
            this.LabelCols.AutoSize = true;
            this.LabelCols.Location = new System.Drawing.Point(130, 119);
            this.LabelCols.Name = "LabelCols";
            this.LabelCols.Size = new System.Drawing.Size(30, 13);
            this.LabelCols.TabIndex = 8;
            this.LabelCols.Text = "Cols:";
            // 
            // NumericUpDownRows
            // 
            this.NumericUpDownRows.Location = new System.Drawing.Point(64, 117);
            this.NumericUpDownRows.Name = "NumericUpDownRows";
            this.NumericUpDownRows.Size = new System.Drawing.Size(35, 20);
            this.NumericUpDownRows.TabIndex = 9;
            this.NumericUpDownRows.Maximum = Connect4Logic.Board.sr_MaxSize;
            this.NumericUpDownRows.Minimum = Connect4Logic.Board.sr_MinSize;
            // 
            // NumericUpDownCols
            // 
            this.NumericUpDownCols.Location = new System.Drawing.Point(165, 117);
            this.NumericUpDownCols.Name = "NumericUpDownCols";
            this.NumericUpDownCols.Size = new System.Drawing.Size(33, 20);
            this.NumericUpDownCols.TabIndex = 10;
            this.NumericUpDownCols.Maximum = Connect4Logic.Board.sr_MaxSize;
            this.NumericUpDownCols.Minimum = Connect4Logic.Board.sr_MinSize;

            // 
            // TextBoxPlayer2
            // 
            this.TextBoxPlayer2.Enabled = false;
            this.TextBoxPlayer2.Location = new System.Drawing.Point(93, 58);
            this.TextBoxPlayer2.Name = "TextBoxPlayer2";
            this.TextBoxPlayer2.Size = new System.Drawing.Size(106, 20);
            this.TextBoxPlayer2.TabIndex = 11;
            this.TextBoxPlayer2.Text = "[Computer]";
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 192);
            this.Controls.Add(this.TextBoxPlayer2);
            this.Controls.Add(this.NumericUpDownCols);
            this.Controls.Add(this.NumericUpDownRows);
            this.Controls.Add(this.LabelCols);
            this.Controls.Add(this.LabelRows);
            this.Controls.Add(this.LabelBoardSize);
            this.Controls.Add(this.TextBoxPlayer1);
            this.Controls.Add(this.CheckBoxPlayer2);
            this.Controls.Add(this.LabelPlayer1);
            this.Controls.Add(this.LabelPlayers);
            this.Controls.Add(this.ButtonStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsWindow";
            this.Text = "Game Settings";
            S_Gameplay.Player2.IsAi = true;
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            s_Board.Rows = (int)NumericUpDownRows.Value;
            s_Board.Columns = (int)NumericUpDownCols.Value;
            s_Board.InitializeArray();
            s_Board.InitializeMatrix();
            S_Gameplay.Player1.Name = TextBoxPlayer1.Text;
            S_Gameplay.Player2.Name = TextBoxPlayer2.Text;

            if (this.TextBoxPlayer1.TextLength == 0 || this.TextBoxPlayer1.TextLength == 0)
            {
                MessageBox.Show("Player names can't be empty!", "Empty Names", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Hide();
                new GameBoardGUI().Show();
            }
        }
  
        private void CheckBoxPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxPlayer2.Enabled = CheckBoxPlayer2.Checked;
            TextBoxPlayer2.Text = string.Empty;
            S_Gameplay.IsAgainstAi = false;
            S_Gameplay.Player2.IsAi = false;

            if (!TextBoxPlayer2.Enabled)
            {
                TextBoxPlayer2.Text = Connect4Logic.Player.sr_DeafultComputerName;
                S_Gameplay.IsAgainstAi = true;
            }
        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label LabelPlayers;
        private System.Windows.Forms.Label LabelPlayer1;
        private System.Windows.Forms.CheckBox CheckBoxPlayer2;
        private System.Windows.Forms.TextBox TextBoxPlayer1;
        private System.Windows.Forms.Label LabelBoardSize;
        private System.Windows.Forms.Label LabelRows;
        private System.Windows.Forms.Label LabelCols;
        private System.Windows.Forms.NumericUpDown NumericUpDownRows;
        private System.Windows.Forms.NumericUpDown NumericUpDownCols;
        private System.Windows.Forms.TextBox TextBoxPlayer2;
    }
}

