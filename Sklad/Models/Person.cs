using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad.Models
{
    public static class Person
    {
        public static string Name { get; set; } = "Aziz";
        public static string Lastname { get; set; } = "Akhunov";
        public static int Age { get; set; } = 17;

        public static void GetPerson()
        {
            Console.WriteLine($"Name: {Name},LastName: {Lastname},Age: {Age}");
        }
    }

}
