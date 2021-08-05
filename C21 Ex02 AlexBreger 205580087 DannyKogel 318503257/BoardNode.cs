using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C21_Ex02_AlexBreger_205580087_DannyKogel_318503257
{
    class BoardNode
    {
        private const string mk_DefaultEmptySpaceValue = "X";
        private bool m_Occupied;
        private string m_PlayerSymbol;
        
        public BoardNode()
        {
            Occupied = false;
            PlayerSymbol = mk_DefaultEmptySpaceValue;
        }

        public bool Occupied
        {
            get
            {
                return m_Occupied;
            }

            set
            {
                m_Occupied = value;
            }
        }

        public string PlayerSymbol
        {
            get
            {
                return m_PlayerSymbol;
            }

            set
            {
                m_PlayerSymbol = value;
            }
        }

    }
}
