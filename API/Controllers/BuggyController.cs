using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        [HttpGet("notfound")]
        public ActionResult GetNotFoundRequest()
        {
            return NotFound();
        }

        [HttpGet("servererror")]
        public ActionResult GetServerError()
        {
            throw new System.Exception();
            return Ok();
        }

        [HttpGet("badRequest")]
        public ActionResult GetBadRequest()
        {
            return BadRequest();
        }

        [HttpGet("badrequest/{id}")]
        public ActionResult GetNotFoundRequest(int id)
        {
            return Ok();
        }
    }
}