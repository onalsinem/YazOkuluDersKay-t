using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgretmen
    {
        private int ogrtid;
        private string ogrtad;
        private int ogrtbrans;

        public int OgrtId
        {
            get { return ogrtid; }
            set { ogrtid = value; }
        }

        public string OgrtAd
        {
            get { return ogrtad; }
            set { ogrtad = value; }
        }

        public int OgrtBrans
        {
            get { return ogrtbrans; }
            set { ogrtbrans = value; }
        }
    }
}
