using Microsoft.AspNetCore.Mvc;
using Fiap.Api.ReportCity.Services;
using Fiap.Api.ReportCity.Models;

namespace Fiap.Api.ReportCity.Controllers
{
    [Route("fiap/api/ReportCity/[controller]")]
    [ApiController]

    public class IncidentReportController : ControllerBase
    {
        private readonly IIncidentReportService _incidentReportService;

        public IncidentReportController(IIncidentReportService incidentReportService)
        {
            _incidentReportService = incidentReportService;
        }

        // GET: fiap/api/ReportCity/IncidentReport
        [HttpGet]
        public ActionResult<IEnumerable<IncidentReport>> GetIncidentReports()
        {
            var reports = _incidentReportService.GetAllReports();
            return Ok(reports);
        }

        // GET: fiap/api/ReportCity/IncidentReport/5
        [HttpGet("{id}")]
        public ActionResult<IncidentReport> GetIncidentReport(int id)
        {
            var report = _incidentReportService.GetReportById(id);

            if (report == null)
            {
                return NotFound();
            }

            return report;
        }

        // POST: fiap/api/ReportCity/IncidentReport
        [HttpPost]
        public ActionResult<IncidentReport> PostIncidentReport(IncidentReport report)
        {
            _incidentReportService.CreateReport(report);
            return CreatedAtAction(nameof(GetIncidentReport), new { id = report.Id }, report);
        }

        // PUT: fiap/api/ReportCity/IncidentReport/5
        [HttpPut("{id}")]
        public IActionResult PutIncidentReport(int id, IncidentReport report)
        {
            if (id != report.Id)
            {
                return BadRequest();
            }

            _incidentReportService.UpdateReport(report);
            return NoContent();
        }

        // DELETE: fiap/api/ReportCity/IncidentReport/5
        [HttpDelete("{id}")]
        public IActionResult DeleteIncidentReport(int id)
        {
            _incidentReportService.DeleteReport(id);
            return NoContent();
        }
    }
}
