using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C21_Ex02_AlexBreger_205580087_DannyKogel_318503257
{
    class BoardNode
    {
        private bool m_Occupied;
        private char m_PlayerSymbol;
        
        public BoardNode()
        {
            m_Occupied = false;
            m_PlayerSymbol = ' ';
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

        public char PlayerSymbol
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
