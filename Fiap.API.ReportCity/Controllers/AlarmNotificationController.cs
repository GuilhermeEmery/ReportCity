using Microsoft.AspNetCore.Mvc;
using Fiap.Api.ReportCity.Services;
using Fiap.Api.ReportCity.Models;
using Microsoft.AspNetCore.Authorization;

namespace Fiap.Api.ReportCity.Controllers
{
    [Route("fiap/api/ReportCity/[controller]")]
    [ApiController]
    public class AlarmNotificationController : ControllerBase
    {
        private readonly IAlarmNotificationService _alarmNotificationService;

        public AlarmNotificationController(IAlarmNotificationService alarmNotificationService)
        {
            _alarmNotificationService = alarmNotificationService;
        }

        // GET: fiap/api/ReportCity/AlarmNotification
        [HttpGet]
        public ActionResult<IEnumerable<AlarmNotification>> GetAlarmNotifications()
        {
            var notifications = _alarmNotificationService.GetAllNotifications();
            return Ok(notifications);
        }

        // GET: fiap/api/ReportCity/AlarmNotification/5
        [HttpGet("{id}")]
        public ActionResult<AlarmNotification> GetAlarmNotification(int id)
        {
            var notification = _alarmNotificationService.GetNotificationById(id);

            if (notification == null)
            {
                return NotFound();
            }

            return notification;
        }

        // POST: fiap/api/ReportCity/AlarmNotification
        [HttpPost]

        public ActionResult<AlarmNotification> PostAlarmNotification(AlarmNotification notification)
        {
            _alarmNotificationService.CreateNotification(notification);
            return CreatedAtAction(nameof(GetAlarmNotification), new { id = notification.Id }, notification);
        }

        // PUT: fiap/api/ReportCity/AlarmNotification/5
        [HttpPut("{id}")]

        public IActionResult PutAlarmNotification(int id, AlarmNotification notification)
        {
            if (id != notification.Id)
            {
                return BadRequest();
            }

            _alarmNotificationService.UpdateNotification(notification);
            return NoContent();
        }

        // DELETE: fiap/api/ReportCity/AlarmNotification/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "gerente")]
        public IActionResult DeleteAlarmNotification(int id)
        {
            _alarmNotificationService.DeleteNotification(id);
            return NoContent();
        }
    }
}
