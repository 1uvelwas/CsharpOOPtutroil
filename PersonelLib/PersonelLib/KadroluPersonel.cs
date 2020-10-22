using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelLib
{
    public class KadroluPersonel : PersonelBase
    {
        double aylik;
        double rapor;

        public KadroluPersonel(int id , string name, string surname,double aylik,double rapor ):base(id,name,surname)
        {
            Aylik = aylik;
            Rapor = rapor;
        }
        public KadroluPersonel()
        {

        }

        public double Aylik
        {
            get
            {
                return aylik;
            }

            set
            {
                aylik = value;
            }
        }

        public double Rapor
        {
            get
            {
                return rapor;
            }

            set
            {
                rapor = value;
            }
        }

        public override double AylikHesapla()
        {
            if (Rapor<=5)
            {
                return Aylik;

            }
            else
            {
                return Aylik - (Aylik / 30) * (Rapor - 5);
            }
        }
    }
}
