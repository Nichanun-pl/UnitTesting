﻿using System;
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
        [Test]
        public void SendStatementEmails_WhenCalled_GenerateStatements()
        {
            var unitOfWork = new Mock<IUnitOfWork>();
            unitOfWork.Setup(uow => uow.Query<Housekeeper>()).Returns(new List<Housekeeper>
            {
                new Housekeeper {Email = "a", FullName = "b", Oid = 1, StatementEmailBody = "c" }
            }.AsQueryable());

            var statementGenerator = new Mock<IStatementGenerator>();

            var service = new HousekeeperService(unitOfWork.Object);
        }
    }
}
