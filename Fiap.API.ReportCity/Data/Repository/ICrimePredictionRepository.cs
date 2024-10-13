using Fiap.Api.ReportCity.Models;

namespace Fiap.Api.ReportCity.Data.Repository
{
    public interface ICrimePredictionRepository
    {
        IEnumerable<CrimePrediction> GetAll();
        CrimePrediction GetById(int id);
        void Add(CrimePrediction prediction);
        void Update(CrimePrediction prediction);
        void Delete(int id);
    }
}
