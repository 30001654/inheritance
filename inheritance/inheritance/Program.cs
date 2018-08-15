using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Jeremy", "Slayers", 30001673);
            Student student2 = new Student("Jeremy", "Slayers", 30001673);
            Student student3 = new Student("Jeremy", "Slayers", 30001673);
            Student student4 = new Student("Jeremy", "Slayers", 30001673);
            Student student5 = new Student("Jeremy", "Slayers", 30001673);

            Teacher teacher1 = new Teacher("Jeremy", "Slayers","514y3r5", "DT69");
            Teacher teacher2 = new Teacher("Jeremy", "Slayers", "514y3r5", "DT69");
            Teacher teacher3 = new Teacher("Jeremy", "Slayers", "514y3r5", "DT69");
            Teacher teacher4 = new Teacher("Jeremy", "Slayers", "514y3r5", "DT69");
            Teacher teacher5 = new Teacher("Jeremy", "Slayers", "514y3r5", "DT69");

            Console.WriteLine("Enter your First Name:");
            student1.Fname = Console.ReadLine();

            Console.WriteLine(student1.GetStudentDeets());
            Console.WriteLine(student2.GetStudentDeets());
            Console.WriteLine(student3.GetStudentDeets());
            Console.WriteLine(student4.GetStudentDeets());
            Console.WriteLine(student5.GetStudentDeets());

            Console.WriteLine(teacher1.GetTeachDeets());
            Console.WriteLine(teacher2.GetTeachDeets());
            Console.WriteLine(teacher3.GetTeachDeets());
            Console.WriteLine(teacher4.GetTeachDeets());
            Console.WriteLine(teacher5.GetTeachDeets());
            Console.ReadLine();
        }
    }
}
