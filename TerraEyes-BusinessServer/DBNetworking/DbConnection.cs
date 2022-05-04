using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace TerraEyes_BusinessServer.DBNetworking
{
    public class DbConnection : IDbConnect
    {
        private string uri = "http://terraeyesdbserver.eu-central-1.elasticbeanstalk.com/";
        public async Task<List<int>> GetTemperaturePointFromDb(string userId)
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync($"{uri}/temperatures");
            
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($"StatusCode: {responseMessage.StatusCode}");
            }

            string listAsString = await responseMessage.Content.ReadAsStringAsync();
            List<int> temperatures = JsonSerializer.Deserialize<List<int>>(listAsString, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            return temperatures;
        }
    }
}