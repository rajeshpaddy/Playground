using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using ConsoleApp2.test;
using Civilization;

namespace ConsoleApp2
{
    internal class Program
    {
        //hack:
        public static string TestbitS;

        static string Concat(params string[] test)
        {
            Class1 c = new Class1();            
            string slo = "";
            foreach (var s in test)
            {
                
                slo += s;
            }

            return slo;

        }

        private static void Main(string[] args)
        {
            TestbitS = "90";
            var yeardold = 0;
            string name = Console.ReadLine();
            //Regex is gold mine of text extraction
            MatchCollection k = Regex.Matches(name, "(?i)(<)([a-z0-9]+>)([\\d,\\D,\\s,\\W,\\w]*)(\\1)/(\\2)");
            foreach (Match match in k)
            {
                Console.WriteLine(match.Groups[3].ToString());
            }
            
            IHouse house = new House();
            house.Address = "22621 SE 13th Street, Sammamish, WA 98075";
            //house.Name = name;
            house.Value = 1100000;
            int numberOfRooms = 5;
            house.AddRooms(numberOfRooms);
            house.AddRooms(new Room(170,FloorType.Carpet,5,10));
            int numberOfGarages = 3;
            house.AddGarages(numberOfGarages);
            Console.WriteLine((house.ToString()));
            foreach (var room in house.Rooms())
            {
                Console.WriteLine((room.ToString()));
            }
            Console.Read();
            var test = new List<int>();
            var n = test.Capacity;
            if (args.Length > 0)
            {
            }
        }
    }
}
