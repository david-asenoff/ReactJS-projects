namespace JokesWebApi.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    using JokesWebApi.Web.ViewModels;
    using JokesWebApi.Web.ViewModels.JokesCategories;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            var result = "/";
            return this.Ok(result);
        }
    }
}
