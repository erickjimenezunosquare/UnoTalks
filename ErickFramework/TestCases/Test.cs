using Framework;
using NUnit.Framework;
using System;

namespace TestCases
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            Console.WriteLine("Erick Jiménez Rodríguez");

            SampleClass.DummyTest();

            Console.WriteLine("Dummy test passed!");
        }
    }
}
