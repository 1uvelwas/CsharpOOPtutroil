using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PersonelLib
{
    public abstract class  PersonelBase
    {
        int id;
        string name;
        string surname;

        public PersonelBase(int id , string name , string  surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
        public PersonelBase()
        {

        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value.Trim().ToUpper();
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value.Trim().ToUpper();
            }
        }

        public string GetNameSurname()
        {
            return string.Format("{0} {1}", Name, Surname);
        }

        public abstract double AylikHesapla();   
    }
}
