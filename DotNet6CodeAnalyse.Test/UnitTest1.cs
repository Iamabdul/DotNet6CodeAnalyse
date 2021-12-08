using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNet6CodeAnalyse.Test
{
    [TestClass]
    public class UnitTest1
    {
        readonly DoSomething _sut = new DoSomething();

        [TestMethod]
        [DataRow(true, 1)]
        [DataRow(false, 0)]
        public void TestMethod1(bool testBool, int expectedOutput)
        {
            var uselessVariable = 123456789; //checking to see if analyser action will pick this up
            var output = _sut.DoSomethingDependantOn(testBool);
            Assert.AreEqual(expectedOutput, output);
        }
    }
}