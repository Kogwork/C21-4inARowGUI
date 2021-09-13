namespace Connect4GUI
{
    public class CelllButton : System.Windows.Forms.Button
    {
        public static readonly int sr_CellButtonDeafultSize = 40;

        private Connect4Logic.BoardNode m_Cell;

        public CelllButton(Connect4Logic.BoardNode i_Cell)
        {
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enabled = false;
            this.Size = new System.Drawing.Size(sr_CellButtonDeafultSize, sr_CellButtonDeafultSize);
            Cell = i_Cell;
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
