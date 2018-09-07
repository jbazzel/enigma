using EnigmaProject.Helpers;
using NUnit.Framework;

namespace Tests.Helpers
{
    [TestFixture]
    public class EnigmaHelperTests
    {
        [Test]
        public void Test_GetInt()
        {
            Assert.AreEqual(0, EnigmaHelper.GetInt('A'));
            Assert.AreEqual(4, EnigmaHelper.GetInt('E'));
            Assert.AreEqual(25, EnigmaHelper.GetInt('Z'));
        }

        [Test]
        public void Test_GetChar()
        {
            Assert.AreEqual(0, EnigmaHelper.GetInt('A'));
            Assert.AreEqual(16, EnigmaHelper.GetInt('Q'));
            Assert.AreEqual(25, EnigmaHelper.GetInt('Z'));
        }
    }
}
