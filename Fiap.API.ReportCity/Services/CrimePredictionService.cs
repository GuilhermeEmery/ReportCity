using Fiap.Api.ReportCity.Data.Repository;
using Fiap.Api.ReportCity.Models;

namespace Fiap.Api.ReportCity.Services
{
    public class CrimePredictionService : ICrimePredictionService
    {
        private readonly ICrimePredictionRepository _crimePredictionRepository;

        public CrimePredictionService(ICrimePredictionRepository crimePredictionRepository)
        {
            _crimePredictionRepository = crimePredictionRepository;
        }

        public IEnumerable<CrimePrediction> GetAllPredictions()
        {
            return _crimePredictionRepository.GetAll();
        }

        public CrimePrediction GetPredictionById(int id)
        {
            return _crimePredictionRepository.GetById(id);
        }

        public void CreatePrediction(CrimePrediction prediction)
        {
            _crimePredictionRepository.Add(prediction);
        }

        public void UpdatePrediction(CrimePrediction prediction)
        {
            _crimePredictionRepository.Update(prediction);
        }

        public void DeletePrediction(int id)
        {
            _crimePredictionRepository.Delete(id);
        }
    }
}
