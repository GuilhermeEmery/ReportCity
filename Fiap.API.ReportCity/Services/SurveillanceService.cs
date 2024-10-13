using Fiap.Api.ReportCity.Data.Repository;
using Fiap.Api.ReportCity.Models;

namespace Fiap.Api.ReportCity.Services
{
    public class SurveillanceService : ISurveillanceService
    {
        private readonly ISurveillanceRepository _surveillanceRepository;

        public SurveillanceService(ISurveillanceRepository surveillanceRepository)
        {
            _surveillanceRepository = surveillanceRepository;
        }

        public IEnumerable<Surveillance> GetAllSurveillances()
        {
            return _surveillanceRepository.GetAll();
        }

        public Surveillance GetSurveillanceById(int id)
        {
            return _surveillanceRepository.GetById(id);
        }

        public void CreateSurveillance(Surveillance surveillance)
        {
            _surveillanceRepository.Add(surveillance);
        }

        public void UpdateSurveillance(Surveillance surveillance)
        {
            _surveillanceRepository.Update(surveillance);
        }

        public void DeleteSurveillance(int id)
        {
            _surveillanceRepository.Delete(id);
        }
    }
}
