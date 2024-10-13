namespace Fiap.Api.ReportCity.Models
{
    public class AlarmNotification
    {
        public int Id { get; set; }
        public string AlarmType { get; set; }
        public DateTime AlarmDate { get; set; }
        public string Location { get; set; }
    }
}
