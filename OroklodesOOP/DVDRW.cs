using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OroklodesOOP
{
    class DVDRW : DVD
    {
        public DVDRW() : base()
        {

        }

        public void megnyit()
        {
            base.lezart = true;
            base.format();
        }


    }
}
