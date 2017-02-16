using NUnit.Framework;
using System;
using Library;

namespace Tests
{
    [TestFixture ()]
    public class Test
    {
        [Test ()]
        //public void CorrectYield (int buzzIn, string buzzOut)
        //{
        //    Assert.AreEqual (Buzzer.Buzz(buzzIn), buzzOut);
        //}
        public void CorrectYield()
        {
            Assert.AreEqual (Buzzer.Buzz (3), "Fizz");
            Assert.AreEqual (Buzzer.Buzz (5), "Buzz");
            Assert.AreEqual (Buzzer.Buzz (15), "FizzBuzz");
            Assert.AreEqual (Buzzer.Buzz (43), "43");
        }
        [Test ()]
        public void TestInt()
        {
            Assert.AreEqual (Buzzer.Buzz (1), "1");
            Assert.AreEqual (Buzzer.Buzz (100), "Buzz");
        }
    }
}

