using DogMvc.Models.ConfigurationModels;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DogMvc.ApiHelper
{
    public class DogApi
    {
        private readonly DogApiModel _model;

        public DogApi(IOptions<DogApiModel> model)
        {
            _model = model.Value;
        }
        public HttpClient Initialize()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(_model.BaseUrl);
            client.DefaultRequestHeaders.Add(_model.ApiKeyName, _model.ApiKey);
            return client;
        }
    }
}
