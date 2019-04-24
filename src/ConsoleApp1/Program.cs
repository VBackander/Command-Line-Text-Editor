using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] Oldlines;
            string Oldtext;

            List<string> Newlines = new List<string>();

            Console.WriteLine("VEditor v.0.01.");
            Console.WriteLine("Type a file path ^^.");
            string path = Console.ReadLine();

            if (path != null)
            {
                Oldtext = System.IO.File.ReadAllText(@path);
                Oldlines = System.IO.File.ReadAllLines(@path);
                // Display the file contents by using a foreach loop.
                System.Console.WriteLine("Your old  text file:");
                foreach (string line in Oldlines)
                {
                    // Use a tab to indent each line of the file.
                    Console.WriteLine("\t" + line);                   
                }
            }

            Newlines.Add(Console.ReadLine());


            Console.WriteLine("Line1:" + Newlines.ToArray()[0]);
            Newlines.Add(Console.ReadLine());

            Console.WriteLine("Line2:" + Newlines.ToArray()[1]);
            Newlines.Add(Console.ReadLine());

            Console.WriteLine("Line3:" + Newlines.ToArray()[2]);
            Newlines.Add(Console.ReadLine());

            Console.WriteLine("Line4:" + Newlines.ToArray()[3]);
            Newlines.Add(Console.ReadLine());

            Console.WriteLine("Press Anykey to save.");
            System.IO.File.WriteAllLines(@path, Newlines);
            Console.ReadLine();

        }
    }
}
