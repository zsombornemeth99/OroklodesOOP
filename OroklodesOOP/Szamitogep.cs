using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OroklodesOOP
{
    class Szamitogep
    {
        private Dictionary<char, HatterTarolo> meghajtok;

        public Szamitogep()
        {
            this.meghajtok = new Dictionary<char, HatterTarolo>();
        }

        public void Felcsatol(char betujel, HatterTarolo ht)
        {
            this.meghajtok.Add(betujel, ht);
        }

        public long osszKapacitas()
        {
            long s = 0;
            foreach (HatterTarolo ht in this.meghajtok.Values)
            {
                s += ht.maximalisKapacitas();
            }
            return s;
        }

        public long foglaltKapacitas()
        {
            long s = 0;
            foreach (var ht in this.meghajtok.Values)
            {
                s += ht.foglaltKapacitas();
            }
            return s;
        }

        public long szabadKapacitas()
        {
            return this.osszKapacitas() - this.foglaltKapacitas();
        }

        public void archival(string fajlnev, char meghajto)
        {
            
        }

        public override string ToString()
        {
            string s = "";
            foreach (var c in this.meghajtok.Keys)
            {
                s += c + " " + "meghajtó:\n\n";
                s += "Max. kapacitás:\n\t" + this.meghajtok[c].maximalisKapacitas() + " Byte\n";
                s += "Foglalt kapacitás:\n\t" + this.meghajtok[c].foglaltKapacitas() + " Byte\n";
                s += "Szabad kapacitás:\n\t" + this.meghajtok[c].szabadKapacitas() + " Byte\n";
                s += "\n";
            }

            return s;
        }
    }
}
