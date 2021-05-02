using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CockRace
{
    abstract class Punter
    {
        public abstract string Name { get; set; }
        public abstract CockBet MyCockBet { get; set; }
        public abstract int Cash { get; set; }
        public abstract RadioButton mrdbtn { get; set; }
        public abstract Label mlbl { get; set; }
        public abstract void SetPunter(CockBet cock, int cash, RadioButton radioButton, Label label);

        internal void SetPunter(object p, RadioButton AliRadioButton, Label AliBetLabel)
        {
            throw new NotImplementedException();
        }
    }

}
