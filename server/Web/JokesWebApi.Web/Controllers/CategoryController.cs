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
    using Microsoft.EntityFrameworkCore;

    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IDeletableEntityRepository<Category> categoryRepository;
        private readonly IDeletableEntityRepository<Joke> jokesRepository;

        public CategoryController(
            IDeletableEntityRepository<Category> categoryRepository,
            IDeletableEntityRepository<Joke> jokesRepository)
        {
            this.categoryRepository = categoryRepository;
            this.jokesRepository = jokesRepository;
        }

        [HttpGet("category/all")]
        public IActionResult Index()
        {
            var result = this.categoryRepository.All().ToList();
            return this.Ok(result);
        }

        [Route("category/{categoryId}")]
        public IActionResult CategoryById(string categoryId)
        {
            var result = this.categoryRepository.All().FirstOrDefault(x => x.Id == categoryId);

            return this.Ok(result);
        }

        [Route("category/{categoryId}/jokes")]
        public IActionResult JokesByCategoryId(string categoryId)
        {
            var category = this.categoryRepository.All().FirstOrDefault(x => x.Id == categoryId);
            var result = this.jokesRepository
                .All()
                .Where(x => x.Categories
                .Any(x => x.Id == categoryId))
                .Include(x => x.Author)
                .Include(x => x.Raitings);
            return this.Ok(result);
        }
    }
}
