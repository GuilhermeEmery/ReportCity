using Fiap.Api.ReportCity.Models;

namespace Fiap.Api.ReportCity.Data.Repository
{
    public interface IIncidentReportRepository
    {
        IEnumerable<IncidentReport> GetAll();
        IncidentReport GetById(int id);
        void Add(IncidentReport report);
        void Update(IncidentReport report);
        void Delete(int id);
    }
}
