using Core;
using Core.Data.Initialize;
using Core.Model;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MySqlCodeFirstDemo
{
    [Export]
    internal class Program
    {
        private static CompositionContainer _container;

        [Import]
        public IUserContract userContract { get; set; }
        static void Main(string[] args)
        {

            //初始化MEF组合容器
            AggregateCatalog catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(Directory.GetCurrentDirectory()));
            catalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));
            _container = new CompositionContainer(catalog);
            DbConfiguration.SetConfiguration(new MySqlEFConfiguration());
            DatabaseInitializer.Initializer();

            try
            {
                Insert();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                string stackt = ex.StackTrace;
                Console.WriteLine(stackt);
            }

            Console.ReadLine();
        }

        public static void Insert()
        {
            Console.WriteLine("start inset....");
            Program program = _container.GetExportedValue<Program>();


            User model = new User();
            model.Name = "test";
            model.Password = "askdkjf";
            Console.WriteLine("model build ok....");
            program.userContract.Insert(model);
            Console.WriteLine("inset over....or not?...");
        }
    }
}
