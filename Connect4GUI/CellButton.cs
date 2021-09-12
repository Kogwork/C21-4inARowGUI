using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4GUI
{
    public class CelllButton : System.Windows.Forms.Button
    {
        public static readonly int sr_CellButtonDeafultSize = 40;

        private int m_PositionColumn;
        private int m_PositionRows;
        private Connect4Logic.BoardNode m_Cell;

        public CelllButton(int i_PositionColumn, int i_PositionRows, Connect4Logic.BoardNode i_Cell)
        {
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enabled = false;
            this.Name = string.Format("CellButton{0}at{1}", i_PositionColumn, i_PositionRows);
            this.Size = new System.Drawing.Size(sr_CellButtonDeafultSize, sr_CellButtonDeafultSize);
            Cell = i_Cell;
        }

        public int PositionColumn
        {
            get
            {
                return m_PositionColumn;
            }

            set
            {
                m_PositionColumn = value;
            }
        }

        public int NumberOfRowsPossible
        {
            get
            {
                return m_PositionRows;
            }

            set
            {
                m_PositionRows = value;
            }
        }

        public Connect4Logic.BoardNode Cell
        {
            get
            {
                return m_Cell;
            }

            set
            {
                m_Cell = value;
            }
        }
    }
}

