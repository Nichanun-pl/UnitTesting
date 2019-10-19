using NUnit.Framework;
using System.Linq;
using Moq;
using TestNinja.Mocking;
using System.Collections.Generic;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class BookingHelper_OverlappingBookingExistTest
    {
        [Test]
        public void BookingStartsAndFinishesBeforeAnExistingBooking_ReturnEmptyString()
        {
            var mock = new Mock<IBookingRepository>();
            mock.Setup(r => r.GetActiveBookings(1)).Returns(new List<Booking>
            {

            }.AsQueryable());
        }
    }
}
