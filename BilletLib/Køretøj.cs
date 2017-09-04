using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public abstract class Køretøj
    {
        private String _nummerPlade;

        public String NummerPlade
        {
            get { return _nummerPlade; }
            set { 
                if (!TestNummerplade(_nummerPlade))
                    throw new System.FormatException();

                _nummerPlade = value;
            }
        }

        public DateTime Dato { get; set; }

        public abstract int Pris();
        public abstract String KøretøjType();

        public bool TestNummerplade(String nummerplade)
        {
            if(nummerplade.Length <= 7)
            {
                return true;
            }
            return false;
        }
    }
}
