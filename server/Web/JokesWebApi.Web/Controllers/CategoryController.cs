namespace JokesWebApi.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    using JokesWebApi.Web.ViewModels;
    using JokesWebApi.Web.ViewModels.JokesCategories;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet("category/all")]
        public IActionResult Index()
        {
            var result = "category/all";
            return this.Ok(result);
        }

        [HttpGet("category/{categoryId}")]
        public IActionResult Category(string categoryId)
        {
            var result = "category/" + categoryId;

            return this.Ok(result);
        }
    }
}
