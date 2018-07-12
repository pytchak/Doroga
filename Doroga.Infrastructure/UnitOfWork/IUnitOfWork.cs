using System;
using Doroga.Domain.Repositories;

namespace Doroga.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        IArticleRepository ArticleRepository { get; }
        IHotelRepository HotelRepository { get; }
        IUserRepository UserRepository { get; }
        IAttractionRepository AttractionRepository { get; }
        IReportRepository ReportRepository { get; }
        IRestaurantRepository RestaurantRepository { get; }
        IServiceStationRepository ServiceStationRepository { get; }
        void SaveChanges();
    }
}
