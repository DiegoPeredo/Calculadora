namespace ApiCalculadora.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpPost]
        [Route ("Add")]
        public float Add([FromHeader] float numa, [FromHeader] float numb)
        {
            return numa + numb;
        }
        [HttpPost]
        [Route("Multi")]
        public float Multi([FromHeader] float numa, [FromHeader] float numb)
        {
            return numa * numb;
        }
        [HttpPost]
        [Route("Divide")]
        public float Divide([FromHeader] float numa, [FromHeader] float numb)
        {
            return (numa / numb);
        }
        [HttpPost]
        [Route("Substract")]
        public float Substract([FromHeader] float numa, [FromHeader] float numb)
        {
            return numa - numb;
        }
    }
}
