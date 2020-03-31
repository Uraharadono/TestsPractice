using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {

        // Note to self since I suck with naming, they could have been also called
        // AdminCanceling, SameUserCanceling and AnotherUserCanceling
        [Test]
        public void CanBeCanceledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User() { IsAdmin = true });

            // Assert
            Assert.IsTrue(result);
            Assert.That(result, Is.True);
            Assert.That(result == true);
        }

        [Test]
        public void CanBeCanceledBy_UserIsOwner_ReturnsTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation() { MadeBy = user };

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCanceledBy_UserIsNotOwner_ReturnsFalse()
        {
            // Arrange
            var ownerUser = new User();
            var reservation = new Reservation() { MadeBy = ownerUser };

            // Act
            var result = reservation.CanBeCancelledBy(new User());

            // Assert
            Assert.IsFalse(result);
        }
    }

    // Way to implement testing with built in functionalities.
    //[TestClass]
    //public class ReservationTests
    //{

    //    // Note to self since I suck with naming, they could have been also called
    //    // AdminCanceling, SameUserCanceling and AnotherUserCanceling
    //    [TestMethod]
    //    public void CanBeCanceledBy_UserIsAdmin_ReturnsTrue()
    //    {
    //        // Arrange
    //        var reservation = new Reservation();

    //        // Act
    //        var result = reservation.CanBeCancelledBy(new User() { IsAdmin = true });

    //        // Assert
    //        Assert.IsTrue(result);
    //    }

    //    [TestMethod]
    //    public void CanBeCanceledBy_UserIsOwner_ReturnsTrue()
    //    {
    //        // Arrange
    //        var user = new User();
    //        var reservation = new Reservation() { MadeBy = user };

    //        // Act
    //        var result = reservation.CanBeCancelledBy(user);

    //        // Assert
    //        Assert.IsTrue(result);
    //    }

    //    [TestMethod]
    //    public void CanBeCanceledBy_UserIsNotOwner_ReturnsFalse()
    //    {
    //        // Arrange
    //        var ownerUser = new User();
    //        var reservation = new Reservation() { MadeBy = ownerUser };

    //        // Act
    //        var result = reservation.CanBeCancelledBy(new User());

    //        // Assert
    //        Assert.IsFalse(result);
    //    }
    //}
}
