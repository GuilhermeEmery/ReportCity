using Microsoft.AspNetCore.Mvc;
using Fiap.Api.ReportCity.Services;
using Fiap.Api.ReportCity.Models;

namespace Fiap.Api.ReportCity.Controllers
{
    [Route("fiap/api/ReportCity/[controller]")]
    [ApiController]
    public class SurveillanceController : ControllerBase
    {
        private readonly ISurveillanceService _surveillanceService;

        public SurveillanceController(ISurveillanceService surveillanceService)
        {
            _surveillanceService = surveillanceService;
        }

        // GET: fiap/api/ReportCity/Surveillance
        [HttpGet]
        public ActionResult<IEnumerable<Surveillance>> GetSurveillances()
        {
            var surveillances = _surveillanceService.GetAllSurveillances();
            return Ok(surveillances);
        }

        // GET: fiap/api/ReportCity/Surveillance/5
        [HttpGet("{id}")]
        public ActionResult<Surveillance> GetSurveillance(int id)
        {
            var surveillance = _surveillanceService.GetSurveillanceById(id);

            if (surveillance == null)
            {
                return NotFound();
            }

            return surveillance;
        }

        // POST: fiap/api/ReportCity/Surveillance
        [HttpPost]
        public ActionResult<Surveillance> PostSurveillance(Surveillance surveillance)
        {
            _surveillanceService.CreateSurveillance(surveillance);
            return CreatedAtAction(nameof(GetSurveillance), new { id = surveillance.Id }, surveillance);
        }

        // PUT: fiap/api/ReportCity/Surveillance/5
        [HttpPut("{id}")]
        public IActionResult PutSurveillance(int id, Surveillance surveillance)
        {
            if (id != surveillance.Id)
            {
                return BadRequest();
            }

            _surveillanceService.UpdateSurveillance(surveillance);
            return NoContent();
        }

        // DELETE: fiap/api/ReportCity/Surveillance/5
        [HttpDelete("{id}")]
        public IActionResult DeleteSurveillance(int id)
        {
            _surveillanceService.DeleteSurveillance(id);
            return NoContent();
        }
    }
}
