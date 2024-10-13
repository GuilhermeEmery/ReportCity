using Microsoft.AspNetCore.Mvc;
using Fiap.Api.ReportCity.Services;
using Fiap.Api.ReportCity.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace Fiap.Api.ReportCity.Controllers
{
    [Route("fiap/api/ReportCity/[controller]")]
    [ApiController]
    public class CrimePredictionController : ControllerBase
    {
        private readonly ICrimePredictionService _crimePredictionService;

        public CrimePredictionController(ICrimePredictionService crimePredictionService)
        {
            _crimePredictionService = crimePredictionService;
        }

        // GET: fiap/api/ReportCity/CrimePrediction
        [HttpGet]
        public ActionResult<IEnumerable<CrimePrediction>> GetCrimePredictions()
        {
            var predictions = _crimePredictionService.GetAllPredictions();
            return Ok(predictions);
        }

        // GET: fiap/api/ReportCity/CrimePrediction/5
        [HttpGet("{id}")]
        public ActionResult<CrimePrediction> GetCrimePrediction(int id)
        {
            var prediction = _crimePredictionService.GetPredictionById(id);

            if (prediction == null)
            {
                return NotFound();
            }

            return prediction;
        }

        // POST: fiap/api/ReportCity/CrimePrediction
        [HttpPost]
        public ActionResult<CrimePrediction> PostCrimePrediction(CrimePrediction prediction)
        {
            _crimePredictionService.CreatePrediction(prediction);
            return CreatedAtAction(nameof(GetCrimePrediction), new { id = prediction.Id }, prediction);
        }

        // PUT: fiap/api/ReportCity/CrimePrediction/5
        [HttpPut("{id}")]
        public IActionResult PutCrimePrediction(int id, CrimePrediction prediction)
        {
            if (id != prediction.Id)
            {
                return BadRequest();
            }

            _crimePredictionService.UpdatePrediction(prediction);
            return NoContent();
        }

        // DELETE: fiap/api/ReportCity/CrimePrediction/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCrimePrediction(int id)
        {
            _crimePredictionService.DeletePrediction(id);
            return NoContent();
        }
    }
}
