using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class GroupContext: DbContext
    {
        public GroupContext()
            : base("EntityFramework.Properties.Settings.ChidlGrDbConnectionString")
        { }

        public DbSet<Group> Groups { get; set; }
    }
}
