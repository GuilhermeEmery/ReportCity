using Fiap.Api.ReportCity.Models;

namespace Fiap.Api.ReportCity.Data.Repository
{
    public interface IAlarmNotificationRepository
    {
        IEnumerable<AlarmNotification> GetAll();
        AlarmNotification GetById(int id);
        void Add(AlarmNotification alarmNotification);
        void Update(AlarmNotification alarmNotification);
        void Delete(int id);
    }
}
