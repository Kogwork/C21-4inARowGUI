
using System;

namespace Connect4GUI
{
    partial class GameBoardGUI
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoardGUI));
            this.LabelPlayer1WinCount = new System.Windows.Forms.Label();
            this.LabelPlayer2WinCount = new System.Windows.Forms.Label();
            this.LabelCurrentTurn = new System.Windows.Forms.Label();
            this.LabelCurrentRound = new System.Windows.Forms.Label();
            this.GridGameBoard = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // LabelPlayer1WinCount
            // 
            this.LabelPlayer1WinCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelPlayer1WinCount.AutoSize = true;
            this.LabelPlayer1WinCount.Location = new System.Drawing.Point(19, 332);
            this.LabelPlayer1WinCount.Name = "LabelPlayer1WinCount";
            this.LabelPlayer1WinCount.Size = new System.Drawing.Size(42, 13);
            this.LabelPlayer1WinCount.TabIndex = 0;
            this.LabelPlayer1WinCount.Text = "Sample";
            // 
            // LabelPlayer2WinCount
            // 
            this.LabelPlayer2WinCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPlayer2WinCount.AutoSize = true;
            this.LabelPlayer2WinCount.Location = new System.Drawing.Point(203, 332);
            this.LabelPlayer2WinCount.Name = "LabelPlayer2WinCount";
            this.LabelPlayer2WinCount.Size = new System.Drawing.Size(42, 13);
            this.LabelPlayer2WinCount.TabIndex = 1;
            this.LabelPlayer2WinCount.Text = "Sample";
            this.LabelPlayer2WinCount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LabelPlayer2WinCount.Click += new System.EventHandler(this.LabelPlayer2WinCount_Click);
            // 
            // LabelCurrentTurn
            // 
            this.LabelCurrentTurn.AutoSize = true;
            this.LabelCurrentTurn.Location = new System.Drawing.Point(32, 42);
            this.LabelCurrentTurn.Name = "LabelCurrentTurn";
            this.LabelCurrentTurn.Size = new System.Drawing.Size(42, 13);
            this.LabelCurrentTurn.TabIndex = 2;
            this.LabelCurrentTurn.Text = "Sample";
            this.LabelCurrentTurn.Click += new System.EventHandler(this.LabelCurrentTurn_Click);
            // 
            // LabelCurrentRound
            // 
            this.LabelCurrentRound.AutoSize = true;
            this.LabelCurrentRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelCurrentRound.Location = new System.Drawing.Point(19, 16);
            this.LabelCurrentRound.Name = "LabelCurrentRound";
            this.LabelCurrentRound.Size = new System.Drawing.Size(55, 17);
            this.LabelCurrentRound.TabIndex = 3;
            this.LabelCurrentRound.Text = "Sample";
            // 
            // GridGameBoard
            // 
            this.GridGameBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridGameBoard.AutoSize = true;
            this.GridGameBoard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GridGameBoard.BackColor = System.Drawing.SystemColors.Highlight;
            this.GridGameBoard.ColumnCount = 1;
            this.GridGameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.GridGameBoard.Location = new System.Drawing.Point(128, 156);
            this.GridGameBoard.Name = "GridGameBoard";
            this.GridGameBoard.RowCount = 1;
            this.GridGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GridGameBoard.Size = new System.Drawing.Size(0, 0);
            this.GridGameBoard.TabIndex = 4;
            // 
            // GameBoardGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.GridGameBoard);
            this.Controls.Add(this.LabelCurrentRound);
            this.Controls.Add(this.LabelCurrentTurn);
            this.Controls.Add(this.LabelPlayer1WinCount);
            this.Controls.Add(this.LabelPlayer2WinCount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameBoardGUI";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Text = "4 in a Row !!";
            this.Load += new System.EventHandler(this.GameBoardGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void IntalizeControlButtons(System.Windows.Forms.TableLayoutPanel i_Grid)
        {
            for (int i = 0; i < SettingsWindow.S_Gameplay.Board.Columns; i++)
            {
                ControlButton control = new ControlButton(i+1, this, SettingsWindow.S_Gameplay);
                control.CurrentPlayer = SettingsWindow.S_Gameplay.Player1;
                i_Grid.Controls.Add(control);
                PlayerControls.ControlList.Add(control);
            }
        }

        private void IntalizeCellButtons(System.Windows.Forms.TableLayoutPanel i_Grid) 
        {
            int columnIndex = 0;
            int rowIndex = 0;
            foreach (Connect4Logic.BoardNode node in SettingsWindow.S_Gameplay.Board.BoardMatrix) 
            {
                CelllButton cell = new CelllButton(columnIndex + 1, rowIndex + 1, node);
                BoardCells[rowIndex, columnIndex] = cell;
                columnIndex++;
                columnIndex %= SettingsWindow.s_Board.Columns;
                if (columnIndex == 0) 
                {
                    rowIndex++;
                }
                i_Grid.Controls.Add(cell);
            }
        }

        #endregion

        private System.Windows.Forms.Label LabelPlayer1WinCount;
        private System.Windows.Forms.Label LabelPlayer2WinCount;
        private System.Windows.Forms.Label LabelCurrentTurn;
        private System.Windows.Forms.Label LabelCurrentRound;
        private System.Windows.Forms.TableLayoutPanel GridGameBoard;
    }
}