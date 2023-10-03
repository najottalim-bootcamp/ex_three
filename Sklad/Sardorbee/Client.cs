using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad.Sardorbee
{
    public static class Client
    {
        public static int Id { get; set; }

        public static string Name { get; set; } = "Sardor";

        public static int Age { get; set; } = 20;

        public static string Description { get; set; } = "This is description";

        public static string Adress { get; set; } = "This is Adress";

        public static void GetClientIfo()
        {
            Console.WriteLine($"Name: {Name},Age: {Age},Description: {Description}");
        }
    }
}
