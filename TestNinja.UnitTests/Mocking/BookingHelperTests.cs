﻿using NUnit.Framework;
using System.Linq;
using Moq;
using TestNinja.Mocking;
using System.Collections.Generic;
using System;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class BookingHelper_OverlappingBookingExistTest
    {
        private Booking _booking;
        private Mock<IBookingRepository> _repository;

        [SetUp]
        public void SetUp()
        {
            _booking = new Booking
            {
                Id = 2,
                ArrivalDate = ArriveOn(2017, 1, 15),
                DepartureDate = DepartOn(2017, 1, 20),
                Reference = "a"
            };

            _repository = new Mock<IBookingRepository>();
            _repository.Setup(r => r.GetActiveBookings(1)).Returns(new List<Booking>
            {
                _booking

            }.AsQueryable());
        }

        [Test]
        public void BookingStartsAndFinishesBeforeAnExistingBooking_ReturnEmptyString()
        {

            var result = BookingHelper.OverlappingBookingsExist(new Booking
            {
                Id = 1,
                ArrivalDate = ArriveOn(2017, 1, 10), //Befor(_existingBooking.ArrivalDate)
                DepartureDate = DepartOn(2017, 1, 24),
            }, _repository.Object);

            Assert.That(result, Is.Empty);
        }

        private DateTime Before(DateTime dateTime)
        {
            return dateTime.AddDays(-1);
        }
        private DateTime ArriveOn(int year, int month, int day)
        {
            return new DateTime(year, month, day, 14, 0, 0);
        }
        private DateTime DepartOn(int year, int month, int day)
        {
            return new DateTime(year, month, day, 10, 0, 0);
        }
    }
}
