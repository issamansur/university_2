using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabRabota5_1;

namespace TestLabRabota5_1
{
    [TestClass]
    public class UnitTestMethods
    {
        [TestMethod]
        public void TestLinearMethod()
        {
            int[] array = new int[] { 5, 4, 3, 2, 1, 0 };

            Assert.AreEqual(5, Methods.LinearMethod(array, 0));
            Assert.AreEqual(3, Methods.LinearMethod(array, 2));
            Assert.AreEqual(0, Methods.LinearMethod(array, 5));
            Assert.AreEqual(-1, Methods.LinearMethod(array, 6));
        }

        [TestMethod]
        public void TestFastLinearMethod()
        {
            int[] array = new int[] { 5, 4, 3, 2, 1, 0, 0 };
            Assert.AreEqual(5, Methods.FastLinearMethod(array, 0));
            array = new int[] { 5, 4, 3, 2, 1, 0, 2 };
            Assert.AreEqual(3, Methods.FastLinearMethod(array, 2));
            array = new int[] { 5, 4, 3, 2, 1, 0, 5 };
            Assert.AreEqual(0, Methods.FastLinearMethod(array, 5));
            array = new int[] { 5, 4, 3, 2, 1, 0, 6 };
            Assert.AreEqual(-1, Methods.FastLinearMethod(array, 6));
        }
    }
}
