using System.Collections.Generic;
using Doroga.Domain.Entities;

namespace Doroga.Domain.Contracts
{
    public interface ICarStationService
    {
        IEnumerable<ServiceStationEntity> GetAllServiceStations();
        ServiceStationEntity GetServiceStationById(string serviceStationId);
        void CreateServiceStation(ServiceStationEntity serviceStation, string currentServiceStationId);
        void UpdateServiceStation(ServiceStationEntity serviceStation, string currentServiceStationId);
    }
}
