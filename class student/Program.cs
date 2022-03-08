using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_student
{
    internal class Program
    {
        private static string name;

        static void Main(string[] args)
        {
            int a,b,c,d,e;
            for(int i = 0; i < 4; i++)
            Console.WriteLine("please enter student's name");
            string name = Console.ReadLine();
            Console.WriteLine("please enter the student's ID");
            int ID = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 5 grades of the student's");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            int grade = (a + b + c + d + e) / 5;
        }
    }
}
