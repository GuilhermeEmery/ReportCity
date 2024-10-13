using Fiap.Api.ReportCity.Models;
using System.Collections.Generic;

namespace Fiap.Api.ReportCity.Services
{
    public interface ISurveillanceService
    {
        IEnumerable<Surveillance> GetAllSurveillances();
        Surveillance GetSurveillanceById(int id);
        void CreateSurveillance(Surveillance surveillance);
        void UpdateSurveillance(Surveillance surveillance);
        void DeleteSurveillance(int id);
    }
}
