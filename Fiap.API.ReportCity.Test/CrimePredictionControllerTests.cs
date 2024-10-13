
using Xunit;
using Moq;
using Fiap.Api.ReportCity.Controllers;
using Fiap.Api.ReportCity.Services;
using Fiap.Api.ReportCity.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Fiap.Api.ReportCity.Test
{
    public class CrimePredictionControllerTests
    {
        private readonly Mock<ICrimePredictionService> _mockCrimePredictionService;
        private readonly CrimePredictionController _crimeprediction;

        public CrimePredictionControllerTests()
        {
            _mockCrimePredictionService = new Mock<ICrimePredictionService>();
            _crimeprediction = new CrimePredictionController(_mockCrimePredictionService.Object);
        }


    }
}
