using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("////////////////////////////////////////////////part1");
            string name,gender;
            int age, cls, avg;

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your gender: ");
            gender = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your class: ");
            cls = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your average: ");
            avg = int.Parse(Console.ReadLine());

            Console.WriteLine("////////////////////////////////////////////////part2");


            Console.WriteLine("Report student information:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Class: {cls}");
            Console.WriteLine($"Average: {avg}");


            Console.WriteLine("////////////////////////////////////////////////part3");

            Console.WriteLine($"student name: {name}");
            Console.WriteLine($"capitalName: {name.ToUpper()}");
            Console.WriteLine($"firstLetter capital: {name.Substring(0, 1).ToUpper() + name.Substring(1)}");
            Console.WriteLine($"lowercase name: {name.ToLower()}");
            Console.WriteLine($"first letter: {name.Substring(0, 1)}");

        }
    }
}
