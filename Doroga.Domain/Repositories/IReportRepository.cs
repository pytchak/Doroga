using System.Collections.Generic;
using Doroga.Domain.Entities;

namespace Doroga.Domain.Repositories
{
    public interface IReportRepository
    {
        IEnumerable<ReportEntity> GetAllReports();
        ReportEntity GetReportById(string id);
        void CreateReport(ReportEntity reportEntities);
        void UpdateReport(ReportEntity reportEntities);
    }
}
