using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OroklodesOOP
{
    class Floppy : HatterTarolo
    {

        private bool irasVedettAllapot;

        public Floppy() : base(1440000)
        {
            this.irasVedettAllapot = false;
        }

        public void atBillent()
        {
            this.irasVedettAllapot = !this.irasVedettAllapot;
        }

        public override void format()
        {
            if (!this.irasVedettAllapot)
            {
                base.format();
            }
        }

        public override void hozzaad(Fajl f)
        {
            if (!this.irasVedettAllapot)
            {
                base.hozzaad(f);
            }
        }

        public override void torol(Fajl f)
        {
            if (!this.irasVedettAllapot)
            {
                base.torol(f);
            }
        }

    }
}
