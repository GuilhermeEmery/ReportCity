namespace Fiap.Api.ReportCity.Models
{
    public class IncidentReport
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime ReportDate { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
    }
}