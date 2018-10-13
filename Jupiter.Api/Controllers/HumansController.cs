using System;
using System.Collections.Generic;
using Jupiter.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jupiter.Api.Controllers
{
    /// <summary>
    ///     Capable for responding to requests about humans.
    /// </summary>
    [Route("api/[controller]")]
    public sealed class HumansController : ControllerBase
    {
        /// <summary>
        ///     GET ~/humans
        /// </summary>
        /// <returns>All known humans.</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return this.Ok(new List<Human>
            {
                new Human(DateTime.Parse("1978-01-09"), "Emerson")
            });
        }
    }
}
