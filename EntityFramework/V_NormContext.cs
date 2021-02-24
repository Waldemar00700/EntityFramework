using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class V_NormContext: DbContext
    {
        public V_NormContext()
            : base("EntityFramework.Properties.Settings.ChidlGrDbConnectionString")
        { }

      
    }
}
