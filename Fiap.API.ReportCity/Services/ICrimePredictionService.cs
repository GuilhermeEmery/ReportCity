using Fiap.Api.ReportCity.Models;
using System.Collections.Generic;

namespace Fiap.Api.ReportCity.Services
{
    public interface ICrimePredictionService
    {
        IEnumerable<CrimePrediction> GetAllPredictions();
        CrimePrediction GetPredictionById(int id);
        void CreatePrediction(CrimePrediction prediction);
        void UpdatePrediction(CrimePrediction prediction);
        void DeletePrediction(int id);
    }
}
