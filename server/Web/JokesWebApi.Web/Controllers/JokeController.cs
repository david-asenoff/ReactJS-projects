namespace JokesWebApi.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
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
        public IActionResult Get(string jokeId)
        {
            var result = this.jokesRepository.All().FirstOrDefault(x => x.Id == jokeId);
            return this.Ok(result);
        }

        [HttpDelete]
        [Route("joke/{id}")]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            var result = this.jokesRepository.All().FirstOrDefault(x => x.Id == id);
            this.jokesRepository.Delete(result);
            await this.jokesRepository.SaveChangesAsync();
            return this.Ok(result);
        }
    }
}
