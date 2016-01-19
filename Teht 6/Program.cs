using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_6
{
    class Program
    {
        static void Main(string[] args)
        {

        
            // create one Car instance
            Motorc motorc = new Motorc();
            motorc.Model = "Kawasaki";
            motorc.Color = "Black";
            motorc.Engine = 16;
            motorc.Speed = 270;
            motorc.PrintData();

           
        }
    }
}
