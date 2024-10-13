using System;

namespace Fiap.Api.ReportCity.Models
{
    public class Surveillance
    {
        public int Id { get; set; }
        public string CameraId { get; set; }
        public string Location { get; set; }
        public DateTime Timestamp { get; set; }
        public string Status { get; set; }
    }
}
