using Newtonsoft.Json;
using SatrackTeam.Domain.Models;
using SatrackTeam.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SatrackTeam.Infrastructure.Services
{
    public class ApiService : IApiService
    {
        public string serviceUrl { get; set; }
        public ApiService()
        {
            serviceUrl = "http://satrackteam.azurewebsites.net/tables/{0}";
        }
        public async Task<List<User>> ValidUser(User user)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("ZUMO-API-VERSION", "2.0.0");
                var response = await client.GetAsync(new Uri(string.Format(serviceUrl, "user")));
                string result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<User>>(result).Where(x => x.username == user.username && x.password == user.password).ToList();
            }
        }
        public async Task<List<Request>> GetRequests()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("ZUMO-API-VERSION", "2.0.0");
                var response = await client.GetAsync(new Uri(string.Format(serviceUrl, "Request")));
                string result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Request>>(result);
            }
        }
        public async Task SaveRequest(Request request)
        {
            using (var client = new HttpClient())
            {
                var bodyRequest = JsonConvert.SerializeObject(request);
                client.DefaultRequestHeaders.Add("ZUMO-API-VERSION", "2.0.0");
                var response = await client.PostAsync(string.Format(serviceUrl, "Request"),
                    new StringContent(bodyRequest, System.Text.Encoding.UTF8, "application/json"));
                string result = await response.Content.ReadAsStringAsync();
            }
        }

    }
}
