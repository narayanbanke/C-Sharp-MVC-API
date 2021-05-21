using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_AccessingListusingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"}
            };
            Student item1 = new Student();
            item1.Id = 5;
            item1.Name = "Shobha";
            students.Add(item1);


            Student item2 = new Student() { Id=5,Name="np" };
            students.Add(item2);
            //get all students whose name is Bill
            var result = from s in students
                         where s.Name.ToUpper() == "NP"
                         select s;

            foreach (var student in result)
                Console.WriteLine(student.Id + ", " + student.Name);
            Console.ReadLine();

        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        
    }
}
