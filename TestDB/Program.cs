using System;

namespace TestDB
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inProgram = true;

            do {
                Console.WriteLine("Enter selection:");
                Console.WriteLine("1) Create a new TestModel.(Create)");
                Console.WriteLine("2) Display all TestModels.(Read)");
                Console.WriteLine("3) Update a TestModel.    (Update)");
                Console.WriteLine("4) Delete a TestModel.    (Delete)");
                Console.WriteLine("5) Exit Program.");

                String selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        {
                            Context db = new Context();
                            db.AddTestModel();
                            db.SaveChanges();
                            break;
                        }
                    case "2":
                        {
                            Context db = new Context();
                            db.DisplayTestModels();
                            db.SaveChanges();
                            break;
                        }
                    case "3":
                        {
                            Context db = new Context();
                            db.EditTestModel();
                            db.SaveChanges();
                            break;
                        }
                    case "4":
                        {
                            Context db = new Context();
                            db.DeleteTestModel();
                            db.SaveChanges();
                            break;
                        }
                    case "5":
                        {
                            inProgram = false;
                            Console.WriteLine("That was CRUDtastic!");
                            break;
                        }
                }  
            } while (inProgram);
        }
    }
}
