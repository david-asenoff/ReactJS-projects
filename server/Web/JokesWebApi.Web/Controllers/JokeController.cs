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
    using JokesWebApi.Web.ViewModels.Jokes;
    using JokesWebApi.Web.ViewModels.JokesCategories;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

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
            var result = this.jokesRepository.All()
                .Include(x => x.Categories)
                .FirstOrDefault(x => x.Id == jokeId);
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

        [HttpPut]
        [Route("joke/{id}")]
        public async Task<IActionResult> PutAsync(JokeUpdateViewModel model)
        {
            var result = this.jokesRepository.All().FirstOrDefault(x => x.Id == model.Id);
            this.jokesRepository.Update(result);
            await this.jokesRepository.SaveChangesAsync();
            return this.Ok(result);
        }

        [HttpPost]
        [Route("joke/create")]
        public async Task<IActionResult> PostAsync(string name, string content, string pictureUrl)
        {
            var joke = new Joke { Content = content };
            var category = this.categoryRepository.All().FirstOrDefault(x => x.Name == name);
            if (category == null)
            {
                category = new Category { Name = name, PictureUrl = pictureUrl };
                await this.categoryRepository.AddAsync(category);
            }

            await this.categoryRepository.SaveChangesAsync();
            joke.Categories.ToList().Add(category);
            await this.jokesRepository.AddAsync(joke);
            await this.jokesRepository.SaveChangesAsync();
            return this.Ok(joke);
        }
    }
}
