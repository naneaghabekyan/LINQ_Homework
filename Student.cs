using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 1․ Հաշվել միջին գնահատականը
/* 2․ (Բոնուս) Գրիր ծրագիր, որը GroupBy-ի միջոցով ուսանողներին խմբավորում է ըստ գնահատականի և տպում․
      Grade 90: 2 students
      Grade 75: 1 student
*/
namespace LINQ_Homework
{
    public class Student
    {
        public string Name { get; set; }
        public double Grade { get; set; }

        public Student(string name, double grade)
        {
            Name=name;
            Grade=grade;
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>
            {
                new Student("Jack",98),
                new Student("Aren",98),
                new Student("Lucy",76),
                new Student("Anna",89),
                new Student("Alena",98),
                new Student("Eva", 67.5),
                new Student("Lucy",76),
            };

            double avgGrade = students.Average(i => i.Grade);
            Console.WriteLine($"Average grade:{avgGrade}");
   
            var groupStudents = students.GroupBy(i => i.Grade);
            foreach (var student in groupStudents)
            {
                Console.WriteLine($"Grade {student.Key}: {student.Count()} students");
            }

        }
    }

}
