using System;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using TestNinja.Mocking;
using System.Linq;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class HouseKeeperServiceTests
    {
        [SetUp]
        public void SetUp()
        {
            var unitOfWork = new Mock<IUnitOfWork>();
            unitOfWork.Setup(uow => uow.Query<Housekeeper>()).Returns(new List<Housekeeper>
            {
                new Housekeeper {Email = "a", FullName = "b", Oid = 1, StatementEmailBody = "c" }
            }.AsQueryable());

            var statementGenerator = new Mock<IStatementGenerator>();
            var emailSender = new Mock<IEmailSender>();
            var messageBox = new Mock<IXtraMessageBox>();

            var service = new HousekeeperService(
                unitOfWork.Object, 
                statementGenerator.Object, 
                emailSender.Object, 
                messageBox.Object);
        }

        [Test]
        public void SendStatementEmails_WhenCalled_GenerateStatements()
        {
            service.SendStatementEmails(new DateTime(2017, 1, 1));

            statementGenerator.Verify(sg => sg.SaveStatement(1, "b", (new DateTime(2017, 1, 1))));
        }
    }
}
