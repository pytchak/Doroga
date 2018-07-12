using System.Collections.Generic;
using Doroga.Domain.Entities;

namespace Doroga.Domain.Repositories
{
    public interface IServiceStationRepository
    {
        IEnumerable<ServiceStationEntity> GetAllServiceStations();
        ServiceStationEntity GetServiceStationById(string id);
        void CreateServiceStation(ServiceStationEntity serviceStationEntities);
        void UpdateServiceStation(ServiceStationEntity serviceStationEntities);
    }
}
