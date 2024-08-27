using DemoEF01.Context;
using DemoEF01.Models;

namespace DemoEF01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CRUD Operations
            //First we need to Create Connection between vs code and Database
            /*
             * What is Tracker and Status??
             * When we make a Crud Operation [Add-update-delete-retreive]
             * context or the file that establish the connection will make object for any object goes to db 
             * or retreieve from db 
             * Ex : if we retrieve record from database the context will make an object from entry class and put
             * some infromation of this record on it like the reference for the record 
             * if we change or modife any this object the the object in the context will be changed to 
             * now when we save changes the compiler chek for the object in the entry class for this object
             * if any changes will Flag => Modified , if not => Unchanged , Deleted => Deleted localy but not in DB
             */

            CompanyContext context = new CompanyContext();


            Employee emp01 = new Employee()
            { Fname = "Ebrahem", Lname = "Ashraf", Age = 26, Email = "ebrahem@gmail.com", salary = 3000 };

            #region Insert
            //Console.WriteLine(context.Entry(emp01).State); //Befor Addigng => Detached

            //context.Employees.Add(emp01);

            //Console.WriteLine(context.Entry(emp01).State); //After Adding => Status will be Added

            //context.SaveChanges();

            //Console.WriteLine(context.Entry(emp01).State); //Status => Unchanged 
            #endregion
            #region Update
            //If we need to Update an ojbect first we need to catch this object
            //This will return an IQueryable result 
            //var empObj = (from emp in context.Employees
            //             where emp.Fname == "Ebrahem"
            //             select emp).FirstOrDefault();

            //if(empObj != null)
            //    empObj.Fname = "Hema";


            //context.SaveChanges();




            #endregion
            #region Delete
            var empObj = (from emp in context.Employees
                          where emp.Fname == "Ots"
                          select emp).FirstOrDefault();


            if (empObj != null)
            {
                context.Employees.Remove(empObj);
                Console.WriteLine("Removed Sucssesfuly");
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("We can't Find this Employee");
            }



            #endregion 
            #endregion

        }
    }
}
