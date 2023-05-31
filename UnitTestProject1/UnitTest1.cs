using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 2, 4, 6};

            int expecred = 15;

            int actual = Varian_24.Task1(a);
            Assert.AreEqual(expecred ,actual );
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] a = { 2, 4, 6};

            int[] expecred = { 5, 17, 29 };

            int[] actual = Varian_24.Task2(a);
            CollectionAssert.AreEqual(expecred, actual);   
        }

        [TestMethod]
        public void TestMethod3()
        {
            
            
        }
    }
}
