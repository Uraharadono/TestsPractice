using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(0);

            // There are 2 ways to assert type
            Assert.That(result, Is.TypeOf<NotFound>()); // used most of the time
            // Assert.That(result, Is.InstanceOf<NotFound>()); // not used as much, as it can mean that result can be of type NotFound or one of it's derivatives
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            // TODO: as exercise
        }
    }
}
