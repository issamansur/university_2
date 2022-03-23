using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabRabota5_2;

namespace TestLabRabota5_2
{
    [TestClass]
    public class UnitTest1
    {
        delegate int Func(int[] array, int x);

        [TestMethod]
        public void TestFullMethods()
        {
            foreach (Func func in new Func[] { Methods.FastLinearMethod, Methods.IterativeBinaryMethod, 
                Methods.RecursiveBinaryMethod, Methods.JumpingMethod })
            {
                int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
                Assert.AreEqual(0, func(array, 0));
                Assert.AreEqual(1, func(array, 1));
                Assert.AreEqual(7, func(array, 7));
                Assert.AreEqual(10, func(array, 10));
                Assert.AreEqual(-1, func(array, 11));

                array = new int[] { 0, 2, 2, 2, 2, 5, 6, 7, 8, 9, 10 };
                Assert.AreEqual(1, func(array, 2));
            }
        }
    }
}
