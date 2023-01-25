using Microsoft.AspNetCore.Mvc;

namespace Calculation_CoreWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculationController : ControllerBase
    {
      
        private readonly ILogger<CalculationController> _logger;

        public CalculationController(ILogger<CalculationController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Calculate([Microsoft.AspNetCore.Mvc.FromBody] Calculation calc)
        {
            int result = 0;
            if (calc.typeid == 1)
            {
                result = calc.num1 + calc.num2;
            }
            else { result = calc.num1 * calc.num2; }
            return Ok(result);
        }

    }
}