using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OroklodesOOP
{
    class Fajl
    {
        private string nev;
        private int meret;

        public Fajl(string nev, int meret)
        {
            this.nev = nev;
            this.meret = meret;
        }

        public string getNev()
        {
            return this.nev;
        }

        public int getMeret()
        {
            return this.meret;
        }

        public override string ToString()
        {
            return string.Format("{0,-20} {1,7} byte", this.nev, this.meret);
        }


    }
}
