using Fiap.Api.ReportCity.Data.Contexts;
using Fiap.Api.ReportCity.Data.Repository;
using Fiap.Api.ReportCity.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.ReportCity.Data.Repository
{
    public class SurveillanceRepository : ISurveillanceRepository
    {
        private readonly ApplicationDbContext _context;

        public SurveillanceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Surveillance> GetAll()
        {
            return _context.Surveillances.ToList();
        }

        public Surveillance GetById(int id)
        {
            return _context.Surveillances.FirstOrDefault(s => s.Id == id);
        }

        public void Add(Surveillance surveillance)
        {
            _context.Surveillances.Add(surveillance);
            _context.SaveChanges();
        }

        public void Update(Surveillance surveillance)
        {
            _context.Entry(surveillance).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var surveillance = _context.Surveillances.Find(id);
            if (surveillance != null)
            {
                _context.Surveillances.Remove(surveillance);
                _context.SaveChanges();
            }
        }
    }
}
