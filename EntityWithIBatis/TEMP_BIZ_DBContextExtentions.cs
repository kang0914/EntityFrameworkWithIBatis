using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityWithIBatis.DBContexts
{
    public partial class TEMP_BIZ_DBContext
    {
        public TEMP_BIZ_DBContext(IBatisNet.DataMapper.ISqlMapSession sqlMapSession)
            : base((DbConnection)sqlMapSession.Connection, false)
        {
            this.Database.UseTransaction((DbTransaction)sqlMapSession.Transaction);
        }
    }
}
