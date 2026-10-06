using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("part1");

            string studentName = "Anas";
            int Age = 22, StudentGrade = 88, avg = 90;
            string studentGender = "Male";
            bool isStudentActive = true;


            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Student Grade: " + StudentGrade);
            Console.WriteLine("Average: " + avg);
            Console.WriteLine("Gender: " + studentGender);
            Console.WriteLine("Is Active: " + isStudentActive);
            Console.WriteLine("////////////////////////////////////////////");

            //part2
            Console.WriteLine("part2");

            string[] students = { "Anas", "Ali", "Ahmed", "Aisha" };
            Console.WriteLine("Students:"+ students[0]);
            Console.WriteLine("Students:"+ students[1]);
            Console.WriteLine("Students:"+ students[2]);
            Console.WriteLine("Students:"+ students[3]);
            Console.WriteLine("////////////////////////////////////////////");


            //part3
            Console.WriteLine("part3");

            Console.WriteLine("First Student: " + students[0]);
            Console.WriteLine("Last Student: " + students[3]);
            students[0] = "Hassan";
            Console.WriteLine("Students:" + students[0]);
            Console.WriteLine("Students:" + students[1]);
            Console.WriteLine("Students:" + students[2]);
            Console.WriteLine("Students:" + students[3]);
        }
    }
}
