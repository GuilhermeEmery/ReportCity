using Fiap.Api.ReportCity.Data.Contexts;
using Fiap.Api.ReportCity.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.ReportCity.Data.Repository
{
    public class AlarmNotificationRepository : IAlarmNotificationRepository
    {
        private readonly ApplicationDbContext _context;

        public AlarmNotificationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<AlarmNotification> GetAll()
        {
            return _context.AlarmNotifications.ToList();
        }

        public AlarmNotification GetById(int id)
        {

            return _context.AlarmNotifications.Find(id) ?? new AlarmNotification();
        }

        public void Add(AlarmNotification alarmNotification)
        {
            _context.AlarmNotifications.Add(alarmNotification);
            _context.SaveChanges();
        }

        public void Update(AlarmNotification alarmNotification)
        {
            _context.Entry(alarmNotification).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var alarmNotification = _context.AlarmNotifications.Find(id);
            if (alarmNotification != null)
            {
                _context.AlarmNotifications.Remove(alarmNotification);
                _context.SaveChanges();
            }
        }
    }
}
