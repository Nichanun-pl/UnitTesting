using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        [Test]
        public void CalculateDemeritPoints_SpeedIsNegative_ThrowArgumentOutOfRangeException()
        {
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(64, 0)]
        [TestCase(65, 0)]
        [TestCase(66, 0)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed)
        {
        }

    }
}
