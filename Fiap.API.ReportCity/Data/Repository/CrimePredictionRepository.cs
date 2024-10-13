using Fiap.Api.ReportCity.Data.Contexts;
using Fiap.Api.ReportCity.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.ReportCity.Data.Repository
{
    public class CrimePredictionRepository : ICrimePredictionRepository
    {
        private readonly ApplicationDbContext _context;

        public CrimePredictionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<CrimePrediction> GetAll()
        {
            return _context.CrimePredictions.ToList();
        }

        public CrimePrediction GetById(int id)
        {
            return _context.CrimePredictions.Find(id);
        }

        public void Add(CrimePrediction prediction)
        {
            _context.CrimePredictions.Add(prediction);
            _context.SaveChanges();
        }

        public void Update(CrimePrediction prediction)
        {
            _context.Entry(prediction).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var prediction = _context.CrimePredictions.Find(id);
            if (prediction != null)
            {
                _context.CrimePredictions.Remove(prediction);
                _context.SaveChanges();
            }
        }
    }
}
