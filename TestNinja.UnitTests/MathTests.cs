using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        // Note to self  (as of video 22): We should never instantiate object in constructor than reuse it in our methods.
        // However, NUnit has 2 special methods:
        // SetUp
        // TearDown

        private Math _math;
        // Name can be anything, but by convention we are gonna name it "SetUp"
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        // As of video 23, we learned about parameterized methods in NUnit. There is no way to test with parameterized tests in MsTest.
        // If we approach testing this way all of the methods below (Max_FirstArgumentIsGreater_ReturnFirstArgument, Max_SecondArgumentIsGreater_ReturnSecondArgument and Max_ArgumentsAreEqual_ReturnTheSameArgument) can be removed as they are replaced by this single method.
        [Test]
        [TestCase(2,1,2)]
        [TestCase(1,2,2)]
        [TestCase(1,1,1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        // [Ignore("Reason why test is disabled.")] // Lecture 24, easy way to ignore test while we fix other stuff
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            // Removed because we introduced special function "SetUp" (as of video 22)
            // var math = new Math();

            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        #region Removed cause of the parameterized test method exercise, but tests below work just fine
        //[Test]
        //public void Max_FirstArgumentIsGreater_ReturnFirstArgument()
        //{
        //    // Removed because we introduced special function "SetUp" (as of video 22)
        //    // var math = new Math();

        //    // First argument should be greater, per method name
        //    var result = _math.Max(2, 1);

        //    Assert.That(result, Is.EqualTo(2));
        //}

        //[Test]
        //public void Max_SecondArgumentIsGreater_ReturnSecondArgument()
        //{
        //    // Removed because we introduced special function "SetUp" (as of video 22)
        //    // var math = new Math();

        //    // Second argument should be greater, per method name
        //    var result = _math.Max(1, 2);

        //    Assert.That(result, Is.EqualTo(2));
        //}

        //[Test]
        //public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        //{
        //    // Removed because we introduced special function "SetUp" (as of video 22)
        //    // var math = new Math();

        //    // First argument should be greater, per method name
        //    var result = _math.Max(1, 1);

        //    Assert.That(result, Is.EqualTo(1));
        //}
        #endregion  
    }
}
