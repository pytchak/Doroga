using System.Collections.Generic;
using Doroga.Domain.Entities;

namespace Doroga.Domain.Contracts
{
    public interface ICarStationService
    {
        IEnumerable<CarStationEntity> GetAllServiceStations();
        CarStationEntity GetServiceStationById(string serviceStationId);
        void CreateServiceStation(CarStationEntity serviceStation, string currentServiceStationId);
        void UpdateServiceStation(CarStationEntity serviceStation, string currentServiceStationId);
    }
}
