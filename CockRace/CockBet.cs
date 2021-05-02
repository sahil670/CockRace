using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CockRace
{
    public class CockBet
    {
        //global variables declaration
        public int Price;
        public int Cock;
        public CockClient cockClient;

        public CockBet(int Price, int Cock, CockClient cockClient)//this is constructor
        {
            this.Price = Price;
            this.Cock = Cock;
            this.cockClient = cockClient;
        }

        public string Description()//this function is for setting the description of labels when bet is placed and Price is changed
        {
            string description = "";

            if (Price > 0)
            {
                description = String.Format("{0} bets ${1} on Cock #{2}", cockClient.Name, Price, Cock);
            }
            else
            {
                description = String.Format("{0} hasn't placed any bets", cockClient.Name);
            }


            return description;
        }

        public int PayOut(int Winner)//this function is for payout to those who win the race
        {
            if (Cock == Winner)
            {
                return Price;
            }
            return -Price;
        }
    }
}
