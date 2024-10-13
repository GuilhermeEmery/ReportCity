
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
        public void GetAlarmNotifications_ReturnsOkResult()
        {
            // Assert
        }


    }
}
