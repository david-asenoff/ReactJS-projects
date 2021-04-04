namespace JokesWebApi.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using JokesWebApi.Data.Common.Repositories;
    using JokesWebApi.Data.Models;
    using JokesWebApi.Web.ViewModels;
    using JokesWebApi.Web.ViewModels.JokesCategories;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IDeletableEntityRepository<Category> categoryRepository;

        public CategoryController(IDeletableEntityRepository<Category> categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        [HttpGet("category/all")]
        public IActionResult Index()
        {
            var result = this.categoryRepository.All().ToList();
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
