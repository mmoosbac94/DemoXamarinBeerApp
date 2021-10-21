using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace BeerApp.Core.Models
{
    public class Beer
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("food_pairing")]
        public List<string> FoodPairing { set; get; } = new List<string>();
    }
}
