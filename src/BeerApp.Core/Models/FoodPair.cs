using System;
namespace BeerApp.Core.Models
{
    public class FoodPair
    {
        public string Name { get; private set; }

        public FoodPair(string name)
        {
            Name = name;
        }
    }
}
