using D.R.School.DAL;
using D.R.School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.R.School
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new SchoolContext())
            {
              dbContext.Courses.Add(new Course()
                {
                    Name = ".NET Starter",
                    Code = "dotNet150",
                    Description = ".NET Course by Software Development Academy"
                });                
                dbContext.SaveChanges();

                var kurs = dbContext.Courses.First();

                foreach (var student in dbContext.Students)
                {
                    kurs.Students.Add(student);
                   
                }
                dbContext.SaveChanges();
                foreach (var student in kurs.Students)
                {
                    Console.WriteLine(student.Surname);
                }
            }
            Console.WriteLine("Wykonano program.");
            Console.ReadLine();
        }
    }
}
