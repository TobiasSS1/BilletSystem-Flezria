using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Bil : Køretøj
    {

		//Fillip, hvor er den brobizz? Tag dig sammen! Du skal lave den brobizz!
        public override int Pris()
        {
            return 240;
        }

        public override string KøretøjType()
        {
            return "Bil";
        }
    }
}
