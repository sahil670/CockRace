using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CockRace
{
    public class CockClient
    {
        //gloabl variables declaration
        public string Name;
        public CockBet MyCockBet;
        public int Cash;

        public RadioButton mrdbtn;
        public Label mlbl;
        public ComboBox cmb { get; set; }
        //public Button MyButton;

        public CockClient(string Name, CockBet MyCockBet, int Cash, RadioButton mrdbtn, Label mlbl) //this is constructor
        {
            this.Name = Name;
            this.MyCockBet = MyCockBet;
            this.Cash = Cash;
            this.mrdbtn = mrdbtn;
            this.mlbl = mlbl;
        }

        public void UpdateLabels()//this function is for update the vales of the labels 
        {
            if (MyCockBet == null)
            {
                mlbl.Text = String.Format("{0} hasn't placed any CockBets", Name);
            }
            else
            {
                mlbl.Text = MyCockBet.Description();
            }
            mrdbtn.Text = Name + " has " + Cash + " bucks";

            if (Cash == 0)//Code When CockBettor has no money to CockBet then it gets destroy
            {
                mlbl.Text = String.Format("BUSTED");
                mlbl.ForeColor = System.Drawing.Color.Red;
                mrdbtn.Enabled = false;
            }

        }

        public void ClearCockBet() //this is for clearing the CockBet and reset the value of CockBet as 0
        {
            MyCockBet.Price = 0;
        }

        public bool PlaceCockBet(int Amount, int Bike)//this function is for placing the CockBet 
        {
            if (Amount <= Cash)
            {
                //mlbl.Text = "Busted";
                MyCockBet = new CockBet(Amount, Bike, this);
                return true;
            }

            return false;
        }

        public void Collect(int Winner)//this function is for collecting the cash of winner
        {
            Cash += MyCockBet.PayOut(Winner);
        }
    }
}
