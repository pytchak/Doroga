using System.Collections.Generic;
using Doroga.Domain.Entities;


namespace Doroga.Domain.Contracts
{
    public interface IRestaurantService
    {
        IEnumerable<RestaurantEntity> GetAllRestaurants();
        RestaurantEntity GetRestaurantById(string restaurantId);
        void CreateRestaurant(RestaurantEntity restaurant, string currentRestaurantId);
        void UpdateRestaurant(RestaurantEntity restaurant, string currentRestaurantId);
    }
}
