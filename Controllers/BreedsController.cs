using DogMvc.ApiHelper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DogMvc.Models;

namespace DogMvc.Controllers
{
    public class BreedsController : Controller
    {
        private readonly DogApi _dogApi;
        public BreedsController(DogApi DogApi)
        {
            _dogApi = DogApi;
        }

        public async Task<IActionResult> Index()
        {
            var client = _dogApi.Initialize();
            var response = await client.GetAsync("breeds");

            var DogsGroupedByBreed = new List<IGrouping<string, BreedViewModel>>();
            if (response.IsSuccessStatusCode)
            {
                var stringResult = await response.Content.ReadAsStringAsync();
                var breeds = JsonConvert.DeserializeObject<List<Breed>>(stringResult);

                var breedViewModel = breeds.Select(x => new BreedViewModel(x)).ToList();
                DogsGroupedByBreed = breedViewModel.GroupBy(b => b.breed_group).ToList();
            }

            return View(DogsGroupedByBreed);
        }
    }
}
 