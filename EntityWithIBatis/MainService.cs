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
        private ISqlMapper _mapper
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

        public List<MM_CODE> GetMM_CODE()
        {
            using (var ctx = new TEMP_BIZ_DBContext())
            {
                return ctx.MM_CODE.ToList();
            }
        }

        public IList<MM_CODE> MM_CODE_SELECT()
        {
            return _mapper.QueryForList<MM_CODE>("MM_CODE.SELECT", null);
        }

        public int MM_CODE_INSERT(MM_CODE model)
        {
            return _mapper.Update("MM_CODE.INSERT", model);
        }

        //https://docs.microsoft.com/ko-kr/ef/ef6/saving/transactions
        public void UpdateMM_CODE(string GROUP_CODE, string GROUP_NAME, string CODE, string NAME, string DATA1, string DATA2, string DATA3, string IUSER)
        {
            try
            {
                using (var session = _mapper.BeginTransaction())                
                using (var context = new TEMP_BIZ_DBContext(session))
                {
                    var findMM_CODE = context.MM_CODE.FirstOrDefault(f => f.GROUP_CODE == GROUP_CODE &&
                                                                          f.CODE == CODE &&
                                                                          f.DDATE == null);

                    if (findMM_CODE == null)
                        throw new Exception("업데이트 대상을 찾을 수 없습니다.");

                    // EntityFramework
                    findMM_CODE.DUSER = IUSER;
                    findMM_CODE.DDATE = DateTime.Now;
                    context.SaveChanges();

                    // iBatis.NET
                    MM_CODE newModel2 = new MM_CODE()
                    {
                        GROUP_CODE = GROUP_CODE,
                        GROUP_NAME = GROUP_NAME,
                        CODE = CODE,
                        NAME = NAME,
                        REV_NO = findMM_CODE.REV_NO + 1,
                        DATA1 = DATA1,
                        DATA2 = DATA2,
                        DATA3 = DATA3,
                        IUSER = IUSER,
                        IDATE = DateTime.Now,
                        DUSER = null,
                        DDATE = null
                    };
                    MM_CODE_INSERT(newModel2);
                    
                    session.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
