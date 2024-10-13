using Fiap.Api.ReportCity.Models;

namespace Fiap.Api.ReportCity.Services
{
    public interface IIncidentReportService
    {
        IEnumerable<IncidentReport> GetAllReports();
        IncidentReport GetReportById(int id);
        void CreateReport(IncidentReport report);
        void UpdateReport(IncidentReport report);
        void DeleteReport(int id);
    }
}
