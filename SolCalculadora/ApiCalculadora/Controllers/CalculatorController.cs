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

        [HttpGet]
        [Route("Add")]
        public float Add2( float numa, float numb)
        {
            return numa + numb;
        }

        [HttpPost]
        [Route("Multi")]
        public float Multi([FromHeader] float numa, [FromHeader] float numb)
        {
            return numa * numb;
        }

        [HttpGet]
        [Route("Multi")]
        public float Multi2(float numa, float numb)
        {
            return numa * numb;
        }

        [HttpPost]
        [Route("Divide")]
        public float Divide([FromHeader] float numa, [FromHeader] float numb)
        {
            if (numb == 0)
                return 0;
            return (numa / numb);
        }

        [HttpGet]
        [Route("Divide")]
        public float Divide2(float numa, float numb)
        {
            if (numb == 0)
                return 0;
            return (numa / numb);
        }

        [HttpPost]
        [Route("Subtract")]
        public float Subtract([FromHeader] float numa, [FromHeader] float numb)
        {
            return numa - numb;
        }

        [HttpGet]
        [Route("Subtract")]
        public float Subtract2(float numa, float numb)
        {
            return numa - numb;
        }

    }
}
