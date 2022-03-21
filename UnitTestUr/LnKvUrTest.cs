using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryFun;

namespace UnitTestUr
{
    [TestClass]
    public class LnKvUrTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x1_exp = double.NaN, x2_exp = double.NaN, d_exp = double.NaN;
            string message_exp = "Прямая совпадает с осью, ответ R";

            double x1_act;
            string message_act;

            Ur.LnUr(0, 0, 0, out x1_act, out message_act);

            Assert.AreEqual(x1_exp, x1_act);
            Assert.AreEqual(message_exp, message_act);
        }
    }
}
