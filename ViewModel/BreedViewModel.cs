using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogMvc.Models
{
    public class BreedViewModel
    {
        public int id { get; set; }
        public string breed_group { get; set; }
        public string imageUrl { get; set; }
        public string life_span { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string history { get; set; }

        public BreedViewModel(Breed breed)
        {
            breed_group = breed.breed_group;
            id = breed.id;
            imageUrl = breed.image.url;
            name = breed.name;
            description = breed.description;
            history = breed.history;
        }

    }



}
