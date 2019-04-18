using EntityWithIBatis.DBContexts;
using IBatisNet.Common.Transaction;
using IBatisNet.DataMapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityWithIBatis
{
    public class MainService
    {
        public void Test()
        {
            using (var ctx = new TEMP_BIZ_DBContext())
            {
                var findMM_CODE = ctx.MM_CODE.ToList();
            }
        }

        public IList<MM_CODE> MM_CODE_SELECT()
        {
            ISqlMapper mapper = EntityMapper;
            var result = mapper.QueryForList<MM_CODE>("MM_CODE.SELECT", null);
            return result;
        }
        
        //https://docs.microsoft.com/ko-kr/ef/ef6/saving/transactions
        public void MixTest()
        {
            try
            {
                using (var session = EntityMapper.BeginTransaction())
                using (var ctx = new TEMP_BIZ_DBContext((DbConnection)session.Connection, false))
                {
                    ctx.Database.UseTransaction((DbTransaction)session.Transaction);

                    var findMM_CODE = ctx.MM_CODE.ToList();

                    // EntityFramework
                    MM_CODE newModel = new MM_CODE()
                    {
                        GROUP_CODE = "GG1",
                        GROUP_NAME = "쥐쥐1",
                        CODE = "CC1",
                        NAME = "씨씨1",
                        DATA1 = "",
                        DATA2 = "",
                        DATA3 = "",
                        IUSER = "admin",
                        IDATE = DateTime.Now,
                        DUSER = null,
                        DDATE = null
                    };
                    ctx.MM_CODE.Add(newModel);
                    ctx.SaveChanges();

                    // iBatis.NET
                    MM_CODE newModel2 = new MM_CODE()
                    {
                        GROUP_CODE = "GG2",
                        GROUP_NAME = "쥐쥐2",
                        CODE = "CC2",
                        NAME = "씨씨2",
                        DATA1 = "",
                        DATA2 = "",
                        DATA3 = "",
                        IUSER = "admin",
                        IDATE = DateTime.Now,
                        DUSER = null,
                        DDATE = null
                    };
                    EntityMapper.Update("MM_CODE.INSERT", newModel2);
                    
                    session.Complete();
                }
            }
            catch (Exception ex)
            {

            }

        }

        public static ISqlMapper EntityMapper
        {
            get
            {
                try
                {
                    ISqlMapper mapper = Mapper.Instance();
                    return mapper;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
