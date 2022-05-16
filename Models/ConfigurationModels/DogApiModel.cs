using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogMvc.Models.ConfigurationModels
{
    public class DogApiModel
    {
        public string BaseUrl { get; set; }
        public string ApiKey { get; set; }
        public string ApiKeyName { get; set; }
    }
}
