using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Jupiter.Api.Controllers
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
        /// <returns></returns>
        [Route("day/number")]
        [HttpGet]
        public IActionResult Get()
        {
            return this.Ok(DateTime.Today.DayOfYear);
        }
    }
}
