namespace Fiap.Api.ReportCity.Models
{
    public class CrimePrediction
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public DateTime PredictedDate { get; set; }
        public string CrimeType { get; set; }
    }
}
