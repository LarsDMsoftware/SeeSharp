using Newtonsoft.Json;
using NUnit.Framework;
using System.Net.Http.Json;
using TechTalk.SpecFlow;

namespace TestProject3.Services
{
    public class Pet
    {
        private HttpClient restClient = new HttpClient();
        private string URI = "https://petstore3.swagger.io/api/v3/pet/";

        public dynamic LoadJson()
        {
            string? items;
            using (StreamReader r = new StreamReader("pet.json"))
            {
                string json = r.ReadToEnd();
                items = (string?)JsonConvert.DeserializeObject(json);
            }

            return items;
        }



        [Given(@"the user wants to make a GET Request.")]
        public async void Get_Response()
        {
            var response = await restClient.GetStringAsync(URI + "10");
            Assert.IsTrue(response.Contains("id=10"));
        }

        [Given(@"the user wants to make a Post Request.")]
        public async void Post_Response()
        {
            string json = LoadJson();
            var response = await restClient.PostAsJsonAsync(URI,json);
            var ResponsePost = response.StatusCode.ToString();
            Assert.Equals("OK", ResponsePost);
        }


        [Given(@"the user wants to make a Put Request.")]
        public async void Put_Response()
        {
            string json = LoadJson();
            var response = await restClient.PutAsJsonAsync(URI, json);
            var ResponsePut = response.StatusCode.ToString();
            Assert.Equals("OK", ResponsePut);
        }


        [Given(@"the user wants to make a Delete Request.")]
        public async void Delete_Response()
        {
            string json = LoadJson();
            var response = await restClient.DeleteAsync(URI+"10");
            var ResponseDelete = response.StatusCode.ToString();
            Assert.Equals("OK", ResponseDelete);
        }
    }
}
