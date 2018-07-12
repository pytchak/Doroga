using System.Collections.Generic;
using Doroga.Domain.Entities;

namespace Doroga.Domain.Repositories
{
    public interface IRestaurantRepository
    {
        IEnumerable<RestaurantEntity> GetAllRestaurants();
        RestaurantEntity GetRestaurantById(string id);
        void CreateRestaurant(RestaurantEntity restaurantEntities);
        void UpdateRestaurant(RestaurantEntity restaurantEntities);
    }
}
