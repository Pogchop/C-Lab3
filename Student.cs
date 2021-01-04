using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentCW
{
    class lol
    {
        int id;
        string name;
        DateTime dob;
        float gpa;
        public void Read()
        {
            Console.Write("Student ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Student name: ");
            name = Console.ReadLine();
            Console.Write("GPA: ");
            gpa = float.Parse(Console.ReadLine());
            Console.Write("Datetime: ");
            dob = Convert.ToDateTime(Console.ReadLine());
        }
        public void Display()
        {
            int age = (DateTime.Today.Subtract(dob)).Days / 365;
            Console.WriteLine("Student name: " + name);
            Console.WriteLine("Student id: " + id);
            Console.WriteLine("GPA: " + gpa);
            Console.WriteLine("Age: " + age);
            Console.ReadKey();
        }
    }
    class Student { 
        static void Main(string[] args)
        {
            lol lasa = new lol();
            lasa.Read();
            lasa.Display();
            
        }
    }
}
