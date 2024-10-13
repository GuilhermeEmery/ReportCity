using Fiap.Api.ReportCity.Models;

namespace Fiap.Api.ReportCity.Services
{
    public interface IAlarmNotificationService
    {
        IEnumerable<AlarmNotification> GetAllNotifications();
        AlarmNotification GetNotificationById(int id);
        void CreateNotification(AlarmNotification notification);
        void UpdateNotification(AlarmNotification notification);
        void DeleteNotification(int id);
    }
}
