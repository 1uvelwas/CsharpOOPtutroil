using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelLib
{
    public class StajyerPer : PersonelBase
    {
        int saat;
        int saatlik;

        public StajyerPer(int id , string name , string surname ,int saat , int saatlik):base(id,name,surname)
        {
            Saat = saat;
            Saatlik = saatlik;
        }
        public StajyerPer()
        {

        }
        public int Saat
        {
            get
            {
                return saat;
            }

            set
            {
                saat = value;
            }
        }

        public int Saatlik
        {
            get
            {
                return saatlik;
            }

            set
            {
                saatlik = value;
            }
        }

        public override double AylikHesapla()
        {
            return (saat * saatlik);
        }
    }
}
