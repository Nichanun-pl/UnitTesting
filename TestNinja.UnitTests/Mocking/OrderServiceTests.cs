using NUnit.Framework;
using TestNinja.Mocking;
using Moq;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class OrderServiceTests
    {
        [Test]
        public void PlaceOrder_WhenCalled_StoreTheOrder()
        {
            var storage = new Mock<IStorage>();
            var service = new OrderService(storage.Object);

            service.PlaceOrder(new Order());

            storage.Verify(s => s.Store());
        }
    }
}
