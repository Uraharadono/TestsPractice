using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            // Example of specific assertion - This is kind of bad, cause sometimes this can slip unnoticed
            // Assert.That(result, Is.EqualTo("<strong>abc</strong>"));

            // More general assertion
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abc"));

            // If we don't care about case, we can add IgnoreCase, like this:
            // Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
        }
    }
}
