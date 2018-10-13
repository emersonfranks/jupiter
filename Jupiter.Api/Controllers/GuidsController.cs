using System;
using Microsoft.AspNetCore.Mvc;

namespace Jupiter.Api.Controllers
{
    /// <summary>
    ///     All things GUID.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public sealed class GuidsController : ControllerBase
    {
        /// <summary>
        ///     GET ~/guid
        /// </summary>
        /// <returns>A new GUID.</returns>
        [HttpGet]
        public IActionResult GetWithQuery(bool upperCase = false, bool dashes = false)
        {
            var guid = dashes ? Guid.NewGuid().ToString() : Guid.NewGuid().ToString("N");

            return this.Ok(upperCase ? guid.ToUpper() : guid);
        }
    }
}
