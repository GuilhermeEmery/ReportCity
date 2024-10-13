using Fiap.Api.ReportCity.Data.Contexts;
using Fiap.Api.ReportCity.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.ReportCity.Data.Repository
{
    public class IncidentReportRepository : IIncidentReportRepository
    {
        private readonly ApplicationDbContext _context;

        public IncidentReportRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<IncidentReport> GetAll()
        {
            return _context.IncidentReports.Include(r => r.User).ToList();
        }

        public IncidentReport GetById(int id)
        {
            return _context.IncidentReports.Include(r => r.User).FirstOrDefault(r => r.Id == id);
        }

        public void Add(IncidentReport report)
        {
            _context.IncidentReports.Add(report);
            _context.SaveChanges();
        }

        public void Update(IncidentReport report)
        {
            _context.Entry(report).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var report = _context.IncidentReports.Find(id);
            if (report != null)
            {
                _context.IncidentReports.Remove(report);
                _context.SaveChanges();
            }
        }
    }
}
