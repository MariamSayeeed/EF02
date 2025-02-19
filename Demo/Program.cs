using Demo.Entities;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Revision
            //EF Core : ORM in .Net
            // ORM Object relation Mapping 

            // 1. Mapping 
            //    Code First [ Generate Table Per Class ].
            //     DB  First [ Generate Class Per Table  ].

            // 2.  L2E [ C# Code (LINQ) ----> EF Core ----> SQL DB] 

            // 3 Ways Generate 
            // 1. TPC : Table per Class (There will be repetition)
            // 2. TPH : Table per Hierarichy 
            // 3. TPCC : Table per Concret  Class

            // AppDbContext  context = new AppDbContext(); 
            #endregion

            #region CRUD Operation 

            // CRUD Operation 
            // Create - Read - Update - Delete

            //AppDbContext context = new AppDbContext();

            //try
            //{
            //    // code
            //}

            //finally
            //{
            //    context.Dispose();
            //}

            //using (AppDbContext context = new AppDbContext)
            //{
            //    // CRUD

            //}

            // using AppDbContext context = new AppDbContext();

            #region  // Create - Insert 

            // Create - Insert 

            //var employee = new Employee()
            //{
            //    Name = " Mohammed Ali",
            //    Salary = 12000,
            //    Address = "Cairo",
            //    Age = 25
            //};

            // Console.WriteLine(context.Entry(employee).State); //Detached

            // employee.Name = "Khaled";
            // 
            //Console.WriteLine(context.Entry(employee).State); //Detached
                                                              ////  context.Add(employee);
                                                              // context.Employees.Add(employee);
                                                              // Console.WriteLine(context.Entry(employee).State); //Added
                                                              //var Result = context.SaveChanges();
                                                              // Console.WriteLine(context.Entry(employee).State); //Unchanged

            // employee.Name = "Omer";
            // Console.WriteLine(context.Entry(employee).State); //Unchanged


            // Console.WriteLine(Result);

            //context.Employees.Add(employee);
            //context.SaveChanges();

            //Console.WriteLine(context.Entry(employee).State); // Detached
            //context.Entry(employee).State = EntityState.Added; 
            //Console.WriteLine(context.Entry(employee).State);  // Added

            //context.SaveChanges ();

            #endregion

            #region Read - Select 
            //// Read - Select 

            //// var Result = context.Employees.Where(E => E.Id == 40).FirstOrDefault();
            //var Result = context.Employees.FirstOrDefault(E => E.Id == 40);
            //////var Result = context.Employees.Select(E =>E.Name);

            //Console.WriteLine(context.Entry(Result).State); //Unchanged

            //Result.Name = "Ali";

            //Console.WriteLine(context.Entry(Result).State); //Modified


            ////foreach (var item in Result)
            ////{
            ////    Console.WriteLine(item);


            ////}

            ////Console.WriteLine(Result?.Name);
            ////Console.WriteLine(Result?.Id); 
            #endregion
            #region Update
            //// Update 

            //var Result = context.Employees.FirstOrDefault(E => E.Id == 40);
            //Console.WriteLine(context.Entry(Result).State);//Unchanged
            //Result.Name = "Omer Mohammed ";
            //Console.WriteLine(context.Entry(Result).State);//Modified

            //context.Update(Result);
            //Console.WriteLine(context.Entry(Result).State);// Modified

            ////  context.SaveChanges();
            ////  Console.WriteLine(context.Entry(Result).State);//Unchanged

            #endregion

            #region Delete 
            // Delete 

            // var Result = context.Employees.FirstOrDefault(E => E.Id == 10);
            //Console.WriteLine( context.Entry(Result).State); // UnChanged

            // context.Employees.Remove(Result);
            // 
            // Console.WriteLine(context.Entry(Result).State); // Deleted 
            // context.SaveChanges();
            // Console.WriteLine(context.Entry(Result).State); //  //Detached

            #endregion

            #endregion

            Employee employee = new Employee();

            Department department = new Department();

            // department.Manager.



        }
    }
}
