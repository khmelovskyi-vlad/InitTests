using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using System.Net;

namespace InitTests.Integration.Tests.Controllers.Api.Store
{
    [TestFixture]
    internal class StoreControllerTests
    {
        [Test]
        public async Task GetProduct_SendRequest_ShouldReturnOk()
        {
            //Arrange

            WebApplicationFactory<Program> web = new WebApplicationFactory<Program>().WithWebHostBuilder(_ => { });

            HttpClient client = web.CreateClient();

            //Act

            HttpResponseMessage response = await client.GetAsync("api/Store/product");

            //Assert

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
