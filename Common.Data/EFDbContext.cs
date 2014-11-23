﻿using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Data
{
    [Export(typeof(DbContext))]
   /* [DbConfigurationType(typeof(MySqlEFConfiguration))]*/
    public class EFDbContext : DbContext
    {

        public EFDbContext()
            : base("DefaultConnection")
        {
            
            string con = base.Database.Connection.ConnectionString;
            Console.WriteLine(con);
        }
         

        public EFDbContext (string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }
        [ImportMany(typeof(IEntityMapper))]
        public IEnumerable<IEntityMapper> EntityMappers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           /* AddDependencyResolver(new MySqlDependencyResolver());*/
            
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            if (EntityMappers == null)
            {
                return;
            }
            foreach (var mapper in EntityMappers)
            {
                mapper.RegistTo(modelBuilder.Configurations);
            }
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<User>().MapToStoredProcedures();
        }
    }
}
