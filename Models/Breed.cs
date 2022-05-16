using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogMvc.Models
{
    public class Breed
    {
        public string bred_for { get; set; }
        public string breed_group { get; set; }
        public Height height { get; set; }
        public int id { get; set; }
        public Image image { get; set; }
        public string life_span { get; set; }
        public string name { get; set; }
        public string origin { get; set; }
        public string reference_image_id { get; set; }
        public string temperament { get; set; }
        public Weight weight { get; set; }
        public string country_code { get; set; }
        public string description { get; set; }
        public string history { get; set; }
    }


    public class Height
    {
        public string imperial { get; set; }
        public string metric { get; set; }
    }


    public class Image
    {
        public int height { get; set; }
        public string id { get; set; }
        public string url { get; set; }
        public int width { get; set; }
    }


    public class Weight
    {
        public string imperial { get; set; }
        public string metric { get; set; }
    }


}
