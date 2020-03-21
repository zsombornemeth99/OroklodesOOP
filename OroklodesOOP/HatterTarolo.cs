using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OroklodesOOP
{
    class HatterTarolo
    {
        private List<Fajl> fajlRendszer;
        private long kapacitas;

        public HatterTarolo(long kapacitas)
        {
            this.fajlRendszer = new List<Fajl>();

            this.kapacitas = kapacitas;
        }

        //Van egy Format() metódusa, mely üríti a fájlok listáját
        public virtual void format()
        {
            this.fajlRendszer.Clear();
        }

        public long maximalisKapacitas()
        {
            return this.kapacitas;
        }

        public long foglaltKapacitas()
        {
            long s = 0;
            for (int i = 0; i < this.fajlRendszer.Count; i++)
            {
                s += this.fajlRendszer[i].getMeret();
            }

            return s;
        }

        public virtual long szabadKapacitas()
        {
            return this.maximalisKapacitas() - this.foglaltKapacitas();
        }

        public virtual void hozzaad(Fajl f)
        {
            this.fajlRendszer.Add(f);
        }

        public Fajl keres(string fajlNev)
        {

            int ind = 0;
            while (ind < this.fajlRendszer.Count && !this.fajlRendszer[ind].getNev().Equals(fajlNev))
            {
                ind++;
            }

            return ind < this.fajlRendszer.Count ? this.fajlRendszer[ind] : null;
        }

        public virtual void torol(Fajl f)
        {
            Fajl keresettFajl = this.keres(f.getNev());
            if (keresettFajl != null)
            {
                this.fajlRendszer.Remove(keresettFajl);
            }
        }

        public override string ToString()
        {
            string s = "";

            foreach (Fajl f in this.fajlRendszer)
            {
                s += f + "\n";
            }

            return s;
        }


    }
}
