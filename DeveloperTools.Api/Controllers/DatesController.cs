using System;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperTools.Api.Controllers
{
    /// <summary>
    ///     All things about dates.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DatesController : ControllerBase
    {
        /// <summary>
        ///     GET ~/date/day/number
        /// </summary>
        /// <returns>The day number.</returns>
        [Route("Day/Number")]
        [HttpGet]
        public IActionResult Get()
        {
            return this.Ok(DateTime.Today.DayOfYear);
        }

        /// <summary>
        ///     GET ~/date/time/utcnow
        /// </summary>
        /// <returns>The current UTC date time.</returns>
        [Route("Time/UtcNow")]
        [HttpGet]
        public IActionResult GetUtcDateTime()
        {
            return this.Ok(DateTime.UtcNow);
        }
    }
}
