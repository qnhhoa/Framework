using Chart.Models;
using Chart.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chart.Controllers
{
    [ApiController]
    public class ChartController : Controller
    {

        public FlowChartRepository flows;
        public ChartController()
        {
            flows = new FlowChartRepository();
        }

        [HttpGet]
        [Route("getCharts")]
        public async Task<IActionResult> getChartController()
        {
            List<CircleChart> circles = await flows.GetCircles();
            List<BarChart> bars = await flows.GetBarChart();
            return Ok(new
            {
                circles = circles,
                bars = bars
            });
        }

    }
}