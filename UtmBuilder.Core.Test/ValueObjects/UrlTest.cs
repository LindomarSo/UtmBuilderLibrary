using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Test.ValueObjects
{
    [TestClass]
    public class UrlTest
    {
        private const string InvalidUrl = "banana";
        private const string ValidUrl = "https://google.com";

        [TestMethod]
        [ExpectedException(typeof(InvalidUrlException))]
        public void ShouldReturnExceptionWhenUrlIsInvalid()
        {
            new Url(InvalidUrl);
        }

        [TestMethod]
        [DataRow(" ", true)]
        [DataRow("http", true)]
        [DataRow(InvalidUrl, true)]
        [DataRow(ValidUrl, false)]
        public void ShouldNotReturnExceptionWhenUrIsValid(string link, bool expectException)
        {
            if (expectException)
            {
                try
                {
                    new Url(link);
                    Assert.Fail();
                }
                catch (InvalidUrlException ex)
                {
                    Console.WriteLine(ex);
                    Assert.IsTrue(expectException);
                }
            }
            else
            {
                new Url(link);
                Assert.IsTrue(true);
            }
        }
    }
}
