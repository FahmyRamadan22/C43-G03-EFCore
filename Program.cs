using Assignment.Contexts;
using Assignment.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            using ITIDbContext context = new ITIDbContext();

      

            #region  INSERT
            // Insert
            Instructor instructor = new Instructor { Name = "Fahmy", Bonus = 1000, Salary = 10_000, HourRate = 100 };

            Console.WriteLine(context.Entry(instructor).State); // Detached


            context.Instructors.Add(instructor);

            Department department = new Department { Name = "Backend", ManagerId = 202504 };

            context.Departments.Add(department);


            context.SaveChanges();
            #endregion

            #region  SELECT

            //Instructor instructor1 = context.Instructors.FirstOrDefault(I => I.Id == 202502)!;

            //if (instructor1 is not null)
            //{
            //    Console.WriteLine(instructor1.Name);
            //    Console.WriteLine(instructor1.Salary);

            //}


            #endregion

            #region  UPDATE

            //instructor1.Name = "Fahmy Ashraf";

            //Console.WriteLine(context.Entry(instructor1).State); 

            //context.SaveChanges();

            //Console.WriteLine(context.Entry(instructor1).State); 


            #endregion

            #region  DELETE

            //Console.WriteLine(context.Entry(instructor1).State); 
            //context.Instructors.Remove(instructor1);

            //Console.WriteLine(context.Entry(instructor1).State); 

            //context.SaveChanges();

            //Console.WriteLine(context.Entry(instructor1).State); 

            #endregion

           
        }

    }
}
