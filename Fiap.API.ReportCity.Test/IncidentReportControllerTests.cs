
using Xunit;
using Moq;
using Fiap.Api.ReportCity.Controllers;
using Fiap.Api.ReportCity.Services;
using Fiap.Api.ReportCity.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Fiap.Api.ReportCity.Test
{
    public class IncidentReportControllerTests
    {
        private readonly Mock<IIncidentReportService> _mockIncidentReportService;
        private readonly IncidentReportController _incidentreport;

        public IncidentReportControllerTests()
        {
            _mockIncidentReportService = new Mock<IIncidentReportService>();
            _incidentreport = new IncidentReportController(_mockIncidentReportService.Object);
        }


    }
}
