using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;


namespace TestDB
{
    class Context : DbContext
    {
        public Context() : base("name=Context") { }

        public DbSet<TestModel> TestModels { get; set; }

        public void DisplayTestModels()
        {
            Console.WriteLine("All TestModels in db.");
            var query = TestModels;

            foreach (var item in query)
            {
                Console.WriteLine("{0}) {1}", item.TestId,item.TestName);
            }
        }

        public void AddTestModel()
        {
            TestModel tm = new TestModel();
            Console.WriteLine("Enter new Test Name:");
            tm.TestName = Console.ReadLine();
            Console.WriteLine("Enter new Test Description:");
            tm.TestDescription = Console.ReadLine();

            TestModels.Add(tm);
            SaveChanges();
        }

        public void DeleteTestModel()
        {
            DisplayTestModels();
            Console.WriteLine("Choose a Test Model to delete (select by id)");
            String selection = Console.ReadLine();

            try { var query = TestModels.Find(Int32.Parse(selection));
                Console.WriteLine("{0} has been deleted.", query.TestName);
                TestModels.Remove(query);
                SaveChanges();
            }
            catch { Console.WriteLine("Not a valid ID."); }
        }

        public void EditTestModel()
        {
            DisplayTestModels();
            Console.WriteLine("Choose a test Model to edit (select by id)");
            String selection = Console.ReadLine();

            try { var query = TestModels.Find(Int32.Parse(selection));
                Console.WriteLine("Enter new Test Name:");
                query.TestName = Console.ReadLine();
                Console.WriteLine("Enter new Test Description:");
                query.TestDescription = Console.ReadLine();

                SaveChanges();
            }
            catch { Console.WriteLine("Not a valid ID."); }
        }
    }
}
