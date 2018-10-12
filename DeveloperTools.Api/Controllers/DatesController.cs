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
        ///     GET ~/date/day/number/{datetime}
        /// </summary>
        /// <param name="dateTime">The <see cref="DateTime"/> the caller would like the day number of.</param>
        /// <returns>The day number.</returns>
        [Route("Day/Number/{dateTime}")]
        [HttpGet]
        public IActionResult Get(DateTime dateTime)
        {
            return this.Ok(dateTime.DayOfYear);
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
