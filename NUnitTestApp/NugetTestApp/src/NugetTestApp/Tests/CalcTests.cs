using NUnit.Framework;

namespace NugetTestApp.Tests
{
    [TestFixture]
    public class CalcTests
    {
        [Test]
        public void minus_should_work()
        {
            Assert.That(4 - 1, Is.EqualTo(3), "вычитание не работает");
        }

        [Test]
        public void plus_should_work()
        {
            Assert.That(4 + 1, Is.EqualTo(3), "сложение не работает");
        }
    }
}
