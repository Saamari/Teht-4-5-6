using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// MORO
/// </summary>
namespace Teht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Name = "Ferrari";
            vehicle.Speed = 250;
            vehicle.Tyres = 205;
            vehicle.PrintData();
            Console.WriteLine(vehicle.ToString());
            //Console.WriteLine("Cars Name is =" +vehicle.Name);
            //Console.WriteLine("Cars speed is =" + vehicle.Speed);
            //Console.WriteLine("Cars Tyres are =" + vehicle.Tyres);


        }
    }
}
