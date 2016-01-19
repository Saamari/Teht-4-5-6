using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_6
{
    class Motorc
    {
       
            //field member

            // Properties = ominaisuudet
            public string Model { get; set; }
            public string Color { get; set; }
            public double Engine { get; set; }
            public int Speed { get; set; }
            


        

            // parametric constructor
          

            // method display car data
            public void PrintData()
            {
                Console.WriteLine("Motorcycle data");
                Console.WriteLine(" - model: " + Model);
                Console.WriteLine(" - color: " + Color);
                Console.WriteLine(" - engine: " + Engine);
                Console.WriteLine(" - speed: " + Speed);
             
            }

            //method gives more speed
            public void Accelerate(int newSpeed)
            {
                Speed += newSpeed;
            }
        }
    }


