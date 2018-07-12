using System.Collections.Generic;
using Doroga.Domain.Entities;

namespace Doroga.Domain.Repositories
{
    public interface ICarStationRepository
    {
        IEnumerable<CarStationEntity> GetAllServiceStations();
        CarStationEntity GetServiceStationById(string id);
        void CreateServiceStation(CarStationEntity serviceStationEntities);
        void UpdateServiceStation(CarStationEntity serviceStationEntities);
    }
}
