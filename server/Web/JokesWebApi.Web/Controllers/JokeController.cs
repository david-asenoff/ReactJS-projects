namespace JokesWebApi.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    using JokesWebApi.Web.ViewModels;
    using JokesWebApi.Web.ViewModels.JokesCategories;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class JokeController : ControllerBase
    {
        [HttpGet("joke/{jokeId}")]
        public IActionResult Index(string jokeId)
        {
            var result = "joke/" + jokeId;
            return this.Ok(result);
        }
    }
}
