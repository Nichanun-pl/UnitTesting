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
        public void CalculateDemeritPoints_SpeedIsLessThanOrEqualToSpeedLimit_ReturnZero(int speed)
        {
        }

        [Test]
        public void CalculateDemeritPoints_SpeedIsLessThanSpeedLimit_ReturnZero()
        {
        }
    }
}
