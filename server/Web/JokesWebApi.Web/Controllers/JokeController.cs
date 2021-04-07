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
    public class JokeController : ControllerBase
    {
        private readonly IDeletableEntityRepository<Category> categoryRepository;
        private readonly IDeletableEntityRepository<Joke> jokesRepository;

        public JokeController(
            IDeletableEntityRepository<Category> categoryRepository,
            IDeletableEntityRepository<Joke> jokesRepository)
        {
            this.categoryRepository = categoryRepository;
            this.jokesRepository = jokesRepository;
        }

        [HttpGet("joke/{jokeId}")]
        public IActionResult Index(string jokeId)
        {
            var result = this.jokesRepository.All().FirstOrDefault(x => x.Id == jokeId);
            return this.Ok(result);
        }

        [HttpDelete("joke/{jokeId}")]
        public IActionResult OnDelete(string jokeId)
        {
            var result = this.jokesRepository.All().FirstOrDefault(x => x.Id == jokeId);
            result.DeletedOn = DateTime.UtcNow;
            return this.Ok();
        }
    }
}
