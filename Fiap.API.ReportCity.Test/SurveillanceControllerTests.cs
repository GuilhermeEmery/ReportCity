
using Xunit;
using Moq;
using Fiap.Api.ReportCity.Controllers;
using Fiap.Api.ReportCity.Services;
using Fiap.Api.ReportCity.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Fiap.Api.ReportCity.Test
{
    public class SurveillanceControllerTests
    {
        private readonly Mock<ISurveillanceService> _mockSurveillanceService;
        private readonly SurveillanceController _surveillance;

        public SurveillanceControllerTests()
        {
            _mockSurveillanceService = new Mock<ISurveillanceService>();
            _surveillance = new SurveillanceController(_mockSurveillanceService.Object);
        }


    }
}
