using Fiap.Api.ReportCity.Data.Repository;
using Fiap.Api.ReportCity.Models;

namespace Fiap.Api.ReportCity.Services
{
    public class AlarmNotificationService : IAlarmNotificationService
    {
        private readonly IAlarmNotificationRepository _alarmNotificationRepository;

        public AlarmNotificationService(IAlarmNotificationRepository alarmNotificationRepository)
        {
            _alarmNotificationRepository = alarmNotificationRepository;
        }

        public IEnumerable<AlarmNotification> GetAllNotifications()
        {
            return _alarmNotificationRepository.GetAll();
        }

        public AlarmNotification GetNotificationById(int id)
        {
            return _alarmNotificationRepository.GetById(id);
        }

        public void CreateNotification(AlarmNotification notification)
        {
            _alarmNotificationRepository.Add(notification);
        }

        public void UpdateNotification(AlarmNotification notification)
        {
            _alarmNotificationRepository.Update(notification);
        }

        public void DeleteNotification(int id)
        {
            _alarmNotificationRepository.Delete(id);
        }
    }
}
