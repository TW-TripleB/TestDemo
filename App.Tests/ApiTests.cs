using NUnit.Framework;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace App.Tests
{
    public class ApiTests
    {
        [Test]
        public void GetUser1_ShouldReturn_LeanneGraham()
        {
            // Arrange
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("/users/1", Method.Get);

            // Act
            RestResponse response = client.Execute(request);

            // Assert
            Assert.That((int)response.StatusCode, Is.EqualTo(200), "HTTP Status Check");

            // Check content not null before parsing
            Assert.That(response.Content, Is.Not.Null, "Response content is null");

            var content = JObject.Parse(response.Content!); // 加上 ! 是說我保證它不是 null
            string? name = content["name"]?.ToString();

            Assert.That(name, Is.EqualTo("Leanne Graham"));
        }

        [Test]
        public void GetUser2_ShouldReturn_ErvinHowell()
        {
            // Arrange
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("/users/2", Method.Get);

            // Act
            RestResponse response = client.Execute(request);

            // Assert
            Assert.That((int)response.StatusCode, Is.EqualTo(200), "HTTP Status Check");

            // Check content not null before parsing
            Assert.That(response.Content, Is.Not.Null, "Response content is null");

            var content = JObject.Parse(response.Content!); // 加上 ! 是說我保證它不是 null
            string? name = content["name"]?.ToString();

            Assert.That(name, Is.EqualTo("Ervin Howell"));
        }

    }
}
