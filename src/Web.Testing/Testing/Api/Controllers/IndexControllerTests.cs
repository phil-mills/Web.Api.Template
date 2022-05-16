namespace Web.Testing.Api.Controllers
{
    using System.Net.Http;
    using Web.Testing.Common;
    using System.Threading.Tasks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IndexControllerTests
    {
        private HttpClient _client;

        private readonly string baseUrl = "index/";

        [TestInitialize]
        public void Startup()
        {
            _client = new CustomWebApplicationFactory().CreateClient();
        }

        [TestMethod]
        public async Task Successful_Get()
        {
            // Arrange
            // not needed

            // Act
            var response = await _client.GetAsync(baseUrl + "");
            var result = await response.Content.ReadAsStringAsync();

            // Assert
            Assert.AreEqual("Hello World!", result);
        }
    }
}