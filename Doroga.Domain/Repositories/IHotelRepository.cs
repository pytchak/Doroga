using System.Collections.Generic;
using Doroga.Domain.Entities;

namespace Doroga.Domain.Repositories
{
    public interface IHotelRepository
    {
        IEnumerable<HotelEntity> GetAllHotels();
        HotelEntity GetHotelById(string id);
        void CreateHotel(HotelEntity hotelEntities);
        void UpdateHotel(HotelEntity hotelEntities);
    }
}
