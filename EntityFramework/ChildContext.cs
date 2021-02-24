using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class ChildContext: DbContext
    {
        public ChildContext()
            : base("EntityFramework.Properties.Settings.ChidlGrDbConnectionString")
        { }

        public DbSet<Child> Children{ get; set; }
    }
}
