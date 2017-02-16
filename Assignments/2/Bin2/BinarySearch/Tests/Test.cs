using NUnit.Framework;
using System;
using Library;

namespace Tests
{
    [TestFixture ()]
    public class Test
    {
        [Test ()]
        public void TestTooLow ()
        {
            Assert.AreEqual (-1, Search.Binary(new IComparable [] { 3, 4, 5, 6, 7, 8, 9 } , 1 ), "1NotIn3456789" );
        }
        [Test ()]
        public void TestTooHigh ()
        {
            Assert.AreEqual (-1, Search.Binary (new IComparable [] { 3, 4, 5, 6, 7, 8, 9 }, 10), "10NotIn3456789");
        }
        [Test ()]
        public void TestElement ()
        {
            Assert.AreNotEqual (-1, Search.Binary (new IComparable [] { 3, 4, 5, 6, 7, 8, 9 }, 4), "4IsIn3456789");
            Assert.AreNotEqual (-1, Search.Binary (new IComparable [] { 3, 4, 5, 6, 7, 8, 9 }, 5), "5IsIn3456789");
            Assert.AreNotEqual (-1, Search.Binary (new IComparable [] { 3, 4, 5, 6, 7, 8, 9 }, 3), "3IsIn3456789");
            Assert.AreNotEqual (-1, Search.Binary (new IComparable [] { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, 11), "11IsIn3456789101112");
        }
        [Test ()]
        public void TestEmptyArray ()
        {
            for (int i = -100; i <= 100; i++) 
            {
                Assert.AreEqual (-1, Search.Binary (new IComparable [] { }, i), "-100To100EmptyArray");
            }
        }
        [Test ()]
        public void TestBinaryVsLinear ()
        {
            Generator testGen = new Generator ();

            int sumLinEval = 0;
            int sumBinEval = 0;

            for (int i = 0; i == 25; i++)
            {
                int searchVal = testGen.NextInt (25);
                sumLinEval = sumLinEval + Search.Linear (testGen.NextArray (25, 25), searchVal);
                sumBinEval = sumBinEval + Search.Binary (testGen.NextArray (25, 25), searchVal);
            }

            Assert.Less (sumLinEval, sumBinEval);
        }
    }
}
