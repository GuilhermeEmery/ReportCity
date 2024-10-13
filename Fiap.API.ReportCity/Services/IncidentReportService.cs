using Fiap.Api.ReportCity.Data.Repository;
using Fiap.Api.ReportCity.Models;

namespace Fiap.Api.ReportCity.Services
{
    public class IncidentReportService : IIncidentReportService
    {
        private readonly IIncidentReportRepository _incidentReportRepository;

        public IncidentReportService(IIncidentReportRepository incidentReportRepository)
        {
            _incidentReportRepository = incidentReportRepository;
        }

        public IEnumerable<IncidentReport> GetAllReports()
        {
            return _incidentReportRepository.GetAll();
        }

        public IncidentReport GetReportById(int id)
        {
            return _incidentReportRepository.GetById(id);
        }

        public void CreateReport(IncidentReport report)
        {
            _incidentReportRepository.Add(report);
        }

        public void UpdateReport(IncidentReport report)
        {
            _incidentReportRepository.Update(report);
        }

        public void DeleteReport(int id)
        {
            _incidentReportRepository.Delete(id);
        }
    }
}
