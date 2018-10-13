using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Jupiter.Api.Controllers
{
    /// <summary>
    ///     Handles requests related to my workouts.
    /// </summary>
    [Route("api/[controller]")]
    public sealed class WorkoutsController : Controller
    {
        /// <summary>
        ///     GET ~/workouts
        /// </summary>
        /// <returns>All of the workouts.</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return this.Ok(new List<string>());
        }
    }
}