using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuzla_Final_Homework_Sandy_Smajic
{
    class Program
    {
        public static List<Student> students = new List<Student>(); // List for students
        static void Main(string[] args)
        {
            students.Add(new Student("John", "Last", email: "mail"));
            students.Add(new Student("Chris", "Last", location: "lo"));
            students.Add(new Student("Seth", "Last", "adresa"));


            students.Sort();
            foreach (Student n in students)
            {
                Console.WriteLine(n.name);
            }
            Console.ReadLine();
        }
    }
}
