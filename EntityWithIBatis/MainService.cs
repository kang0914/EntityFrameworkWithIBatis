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
            using (var ctx = new Model2())
            {
                var findMM_CODE = ctx.MM_CODE.ToList();

                //ctx.Database.UseTransaction
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
            var ibatis = EntityMapper.OpenConnection();
            
            using (var ctx = new Model2((DbConnection)ibatis.Connection, false))
            {
                var findMM_CODE = ctx.MM_CODE.ToList();

                MM_CODE newModel = new MM_CODE()
                {
                    GROUP_CODE = "GG1",
                    GROUP_NAME = "쥐쥐1",
                    CODE = "",
                    NAME = "",
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
