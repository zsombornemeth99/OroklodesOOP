using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OroklodesOOP
{
    class DVD : HatterTarolo
    {
        protected bool lezart;

        public DVD() : base(4700000)
        {
            this.lezart = false;
        }

        public void leZar()
        {
            this.lezart = true;
        }

        public override void hozzaad(Fajl f)
        {
            if (!this.lezart)
            {
                base.hozzaad(f);
            }
        }

        public override long szabadKapacitas()
        {
            long szk = 0;

            if (!this.lezart)
            {
                szk = base.szabadKapacitas();
            }

            return szk;
        }


    }
}
