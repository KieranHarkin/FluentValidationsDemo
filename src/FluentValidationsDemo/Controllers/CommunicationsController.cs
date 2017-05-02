
using FluentValidationsDemo.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationsDemo.Controllers
{
    [Route("api/[controller]")]
    public class CommunicationsController : Controller
    {
        [HttpPost]
        public IActionResult CreateCommunication(CommunicationDataContract resource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok();
        }

    }
}
