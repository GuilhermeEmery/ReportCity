using Fiap.Api.ReportCity.Models;

namespace Fiap.Api.ReportCity.Data.Repository
{
    public interface ISurveillanceRepository
    {
        IEnumerable<Surveillance> GetAll();
        Surveillance GetById(int id);
        void Add(Surveillance surveillance);
        void Update(Surveillance surveillance);
        void Delete(int id);
    }
}
