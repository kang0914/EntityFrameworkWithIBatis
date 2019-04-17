using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityWithIBatis
{
    public partial class Entities
    {
        public Entities(DbConnection existingConnection, bool contextOwnsConnection)
               : base(existingConnection, contextOwnsConnection)
        {
        }
    }
}
