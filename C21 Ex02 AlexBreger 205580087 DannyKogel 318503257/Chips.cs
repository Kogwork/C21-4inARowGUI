using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C21_Ex02_AlexBreger_205580087_DannyKogel_318503257
{
    class Chips
    {
        List<string> m_Chips;
        public Chips()
        {
            ChipsList = listOfChips();
        }

        private List<string> listOfChips()
        {
            List<string> chips = new List<string>() { "X", "O"};
            return chips;
        }

        public List<string> ChipsList
        {
            get
            {
                return m_Chips;
            }

            set
            {
                m_Chips = value;
            }
        }
    }
}
