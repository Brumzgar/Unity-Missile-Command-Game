using NUnit.Framework;

namespace Tests
{
    public class NewTestScript
    {
        [Test]
        public void TestOnIntToTest()
        {
            Assert.AreEqual(1, ScriptToTestWithTests.intToTest);
        }
    }
}
