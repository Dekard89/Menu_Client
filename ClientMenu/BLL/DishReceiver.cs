
using ClientMenu.DTO;
using ClientMenu.Models;
using ClientMenu.Options;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;


namespace ClientMenu.BLL
{
    public class DishReceiver
    {
        private readonly HttpClient _client;

        public DishReceiver(IHttpClientFactory factory, IOptions<OriginOptions> options)
        {
            var set = options.Value;
            _client = factory.CreateClient();
            _client.BaseAddress = new Uri(set.Value);
        }

        public async Task< List<DishModel>?> GetRequestDishes(DishRequest request)
        {
            var result = await _client.GetFromJsonAsync<List<DishModel>>(request.ToRequestString());

            return result;
        }
       
      

    }
}
