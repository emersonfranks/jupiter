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
        //[Route("api/[controller]/{upperCase}/{separators}")]
        public IActionResult GetWithQuery(bool upperCase = false, bool dashes = false)
        {
            var guid = dashes ? Guid.NewGuid().ToString() : Guid.NewGuid().ToString("N");

            return this.Ok(upperCase ? guid.ToUpper() : guid);
        }
    }
}
