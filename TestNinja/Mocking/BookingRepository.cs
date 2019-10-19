using System.Linq;

namespace TestNinja.Mocking
{
    public class BookingRepository
    {
        public IQueryable<Booking> GetActiveBookings()
        {
            var unitOfWork = new UnitOfWork();
            var bookings =
                unitOfWork.Query<Booking>()
                    .Where(
                        b => b.Id != booking.Id && b.Status != "Cancelled");

            return bookings;
        }
    }
}
