using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EntityWithIBatis.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // 준비
            MainService mainService = new MainService();

            // 작업
            var results = mainService.GetMM_CODE();

            // 확인
            Assert.IsTrue(results != null);
        }

        [TestMethod]
        public void MM_CODE_SELECT()
        {
            // 준비
            MainService mainService = new MainService();

            // 작업
            var results = mainService.MM_CODE_SELECT();

            // 확인
            Assert.IsTrue(results != null);
        }

        [TestMethod]
        public void MixTest()
        {
            // 준비
            MainService mainService = new MainService();

            // 작업
            mainService.UpdateMM_CODE("G1", "취1", "C1", "코1", null, null, null, "admin");

            // 확인
        }
    }
}
