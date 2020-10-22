using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonelLib;
namespace PersonelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonelBase[] personeller =
            {
                new KadroluPersonel(1,"RT","E",10000,6),
                new SozlesmeliPer(2, "Adnan", "Oktar", 30, 85),
                new StajyerPer(3,"Fetullah","Gülen",50,15)
            };
            
            foreach (var presonelcik in personeller)
            {
                Console.WriteLine("{0} - {1} ",presonelcik.GetNameSurname(),presonelcik.AylikHesapla());
            }
            Console.ReadKey();
        }
    }
}