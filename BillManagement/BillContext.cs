using BillManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManagement
{
    public class BillContext: DbContext
    {
        public DbSet<User> users { get; set; }
        public BillContext(): base("BillConnection")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BillContext>());
        }
    }
}
