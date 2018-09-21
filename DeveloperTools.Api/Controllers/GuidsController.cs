using System;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperTools.Api.Controllers
{
    /// <summary>
    ///     All things GUID.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class GuidsController : ControllerBase
    {
        /// <summary>
        ///     GET ~/guid
        /// </summary>
        /// <returns>A new GUID.</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return this.Ok(Guid.NewGuid());
        }
    }
}
