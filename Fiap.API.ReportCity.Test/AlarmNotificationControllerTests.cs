
using Xunit;
using Moq;
using Fiap.Api.ReportCity.Controllers;
using Fiap.Api.ReportCity.Services;
using Fiap.Api.ReportCity.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Fiap.Api.ReportCity.Test
{
    public class AlarmNotificationControllerTests
    {
        private readonly Mock<IAlarmNotificationService> _mockAlarmNotificationService;
        private readonly AlarmNotificationController _alarmnotification;

        public AlarmNotificationControllerTests()
        {
            _mockAlarmNotificationService = new Mock<IAlarmNotificationService>();
            _alarmnotification = new AlarmNotificationController(_mockAlarmNotificationService.Object);
        }


        [Fact]
        public void GetAlarmNotifications()
        {
            // Arrange
            var notifications = new List<AlarmNotification> { new AlarmNotification { Id = 1, AlarmType = "Test Alarm" } };_mockAlarmNotificationService.Setup(service => service.GetAll()).Returns(notifications);

            // Act
            var result = _alarmnotification.GetAlarmNotifications();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsType<List<AlarmNotification>>(okResult.Value);
            Assert.Equal(notifications.Count, returnValue.Count);
        }

    }
}
