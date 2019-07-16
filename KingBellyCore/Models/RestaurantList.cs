using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KingBellyCore.Models
{
    public class RestaurantList
    {
        public List<Restaurant> Restaurants { get; set; }

        public RestaurantList()
        {
            Restaurants = getRestaurants();
        }


        private List<Restaurant> getRestaurants()
        {
            List<Restaurant> Restaurants = new List<Restaurant>();
            Restaurants.Add(new Restaurant("Shie Sushio", 4, "asdsa", "It was greaaaaat!"));
            return Restaurants;
        }
    }
}
