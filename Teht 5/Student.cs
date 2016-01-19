using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_5
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public string Lname { get; set; }
        public string Ad { get; set; }

        public override string ToString()
        {
            return "- Nimi : " + Name + " " + Lname + " - Ikä : " + Age + " - Osoite : " + Ad + "pituus: " + Height;
        }


    }
}
