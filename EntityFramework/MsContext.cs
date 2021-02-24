using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class MsContext: DbContext
    {
        public MsContext()
            : base("EntityFramework.Properties.Settings.ChidlGrDbConnectionString")
        { }

        public DbSet<MedService> MedServices { get; set; }
    }
}
