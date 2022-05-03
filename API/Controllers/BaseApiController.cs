using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]//checks for valid parameer types in url
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {

    }
}