using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Test.ValueObjects
{
    [TestClass]
    public class CampaignTest
    {
        [TestMethod]
        [DataRow("", "", "teste", true)]
        [DataRow("teste", "", "teste", true)]
        [DataRow("", "teste", "", true)]
        [DataRow("", "teste", "teste", true)]
        [DataRow("teste", "teste", "", true)]
        [DataRow("teste", "teste", "teste", false)]
        public void TestCampaign(string source, string medium, string name, bool expectedException)
        {
            if(expectedException)
            {
                try
                {
                    new Campaign(source, medium, name);
                    Assert.Fail();
                }
                catch (InvalidCampaignException ex)
                {
                    Console.WriteLine(ex);
                    Assert.IsTrue(expectedException);
                }
            }
            else
            {
                new Campaign(source, medium, name);
                Assert.IsTrue(true);
            }
        }
    }
}
