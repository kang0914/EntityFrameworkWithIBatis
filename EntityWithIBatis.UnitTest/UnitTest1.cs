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
            mainService.Test();

            // 확인
        }

        [TestMethod]
        public void MM_CODE_SELECT()
        {
            // 준비
            MainService mainService = new MainService();

            // 작업
            mainService.MM_CODE_SELECT();

            // 확인
        }

        [TestMethod]
        public void MixTest()
        {
            // 준비
            MainService mainService = new MainService();

            // 작업
            mainService.MixTest();

            // 확인
        }
    }
}
