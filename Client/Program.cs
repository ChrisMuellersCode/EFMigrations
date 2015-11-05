using System;
using De.Brickmakers.Tutorials.EF.DatabaseLayer;
using De.Brickmakers.Tutorials.EF.DatabaseLayer.Entities;

namespace De.Brickmakers.Tutorials.EF.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                Student stud = new Student
                {
                    StudentName = "Christian Müller", 
                    DateOfBirth = new DateTime(1984,1,8)
                };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }

            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}
