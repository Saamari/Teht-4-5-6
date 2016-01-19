using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student[] students = new Student[5];
            students[0] = new Student();


            students[0] = new Student();
            students[0].Name = "Pekka";
            students[0].Lname = "Porilainen";
            students[0].Age = 18;
            students[0].Ad = "Hunajakatu 15";
            students[0].Height = 1.88;

            students[1] = new Student();
            students[1] = new Student();
            students[1].Name = "Matti";
            students[1].Lname = "Teppolainen";
            students[1].Age = 19;
            students[1].Ad = "Kehrääjänkatu 17";
            students[1].Height = 1.75;

            students[2] = new Student();
            students[2].Name = "Jorma";
            students[2].Lname = "Ruotsalainen";
            students[2].Age = 20;
            students[2].Ad = "Muillauttajakuja 69";
            students[2].Height = 1.48;

            students[3] = new Student();
            students[3].Name = "Raisa";
            students[3].Lname = "Kallio";
            students[3].Age = 23;
            students[3].Ad = "Utsjoentie 22 ";
            students[3].Height = 1.68;

            students[4] = new Student();
            students[4].Name = "Kyllikki";
            students[4].Lname = "Tellervo ";
            students[4].Age = 68;
            students[4].Ad = "Teollisuuskatu 99 ";
            students[4].Height = 1.50;


            for (int i = 0; i < 5; i++) Console.WriteLine(students[i]);




        }
    }
}
