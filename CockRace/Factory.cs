using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CockRace
{
    static class Factory
    {
        public static Punter CreatePunter(string name)
        {
            if(name == "Jo")
            {
                return new Jo();
            }
            if(name == "Ali")
            {
                return new Ali();
            }
            if (name == "Mary")
            {
                return new Mary();
            }

            return null;
            

        }

    }
}
