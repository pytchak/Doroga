using System;
using System.Collections.Generic;
using Doroga.Infrastructure.Common;
using Doroga.Infrastructure;
using Doroga.Domain.Entities;
using Doroga.Domain.Contracts;


namespace Doroga.Domain.Services
{
    public class CarStationService : ICarStationService
    {
        private readonly IDependencyResolver _dependencyResolver;

        public CarStationService(IDependencyResolver dependencyResolver)
        {
            _dependencyResolver = dependencyResolver;
        }

        public IEnumerable<CarStationEntity> GetAllServiceStations()
        {
            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                return unitOfWork.ServiceStationRepository.GetAllServiceStations();
            }
        }

        public CarStationEntity GetServiceStationById(string serviceStationId)
        {
            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                return unitOfWork.ServiceStationRepository.GetServiceStationById(serviceStationId);
            }
        }

        public void CreateServiceStation(CarStationEntity serviceStation, string currentServiceStationId)
        {
            if (serviceStation == null)
            {
                throw new ArgumentException("ServiceStationEntity cannot be null.");
            }
            if (string.IsNullOrEmpty(currentServiceStationId))
            {
                throw new ArgumentException("CurrentServiceStationId cannot be Null or empty.");
            }

            //DB

            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                unitOfWork.ServiceStationRepository.CreateServiceStation(serviceStation);
                unitOfWork.SaveChanges();
            }
        }

        public void UpdateServiceStation(CarStationEntity serviceStation, string currentServiceStationId)
        {

            if (serviceStation == null)
            {
                throw new ArgumentException("ServiceStationEntity cannot be null.");
            }
            if (string.IsNullOrEmpty(currentServiceStationId))
            {
                throw new ArgumentException("CurrentServiceStationId cannot be Null or empty.");
            }

            //customer.ModifiedByUserId = currentUserId;
            //customer.ModifiedDateTimeUtc = DateTime.UtcNow;

            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                unitOfWork.ServiceStationRepository.UpdateServiceStation(serviceStation);
                unitOfWork.SaveChanges();
            }
        }
    }
}
