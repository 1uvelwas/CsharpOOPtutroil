using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelLib
{
    public class SozlesmeliPer : PersonelBase
    {
        int gun;
        int gunluk;

        public SozlesmeliPer(int id , string name , string surname,int gun ,int gunluk):base(id,name,surname)
        {
            Gun = gun;
            Gunluk = gunluk;
        }
        public SozlesmeliPer()
        {

        }

        public int Gunluk
        {
            get
            {
                return gunluk;
            }

            set
            {
                gunluk = value;
            }
        }

        public int Gun
        {
            get
            {
                return gun;
            }

            set
            {
                gun = value;
            }
        }


        public override double AylikHesapla()
        {
            return (Gun * Gunluk);
        }
    }
}
