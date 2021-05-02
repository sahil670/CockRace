using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CockRace
{
    class Mary : Punter
    {
        public override string Name { get; set; }
        public override CockBet MyCockBet { get; set; }
        public override int Cash { get; set; }
        public override RadioButton mrdbtn { get; set; }
        public override Label mlbl { get; set; }
        public override void SetPunter(CockBet cock, int cash, RadioButton radioButton, Label label)
        {
            MyCockBet = cock;
            Cash = cash;
            mrdbtn = radioButton;
            mlbl = label;
        }
    }
}
