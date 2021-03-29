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
        [HttpGet("jokesCategories/getall")]
        public IActionResult Index()
        {
            var categories = new List<JokesCategoryViewModel>();
            categories.Add(new JokesCategoryViewModel() { Id = "1", Name = "Big Brother", PictureUrl = "https://vicove.com/theme/img/jokes-category/1.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "2", Name = "Microsoft", PictureUrl = "https://vicove.com/theme/img/jokes-category/2.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "3", Name = "SMS", PictureUrl = "https://vicove.com/theme/img/jokes-category/3.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "4", Name = "Авто", PictureUrl = "https://vicove.com/theme/img/jokes-category/4.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "5", Name = "Блондинки", PictureUrl = "https://vicove.com/theme/img/jokes-category/5.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "6", Name = "Графити", PictureUrl = "https://vicove.com/theme/img/jokes-category/6.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "7", Name = "Животни", PictureUrl = "https://vicove.com/theme/img/jokes-category/7.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "8", Name = "Знаете ли че...", PictureUrl = "https://vicove.com/theme/img/jokes-category/8.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "9", Name = "Истории", PictureUrl = "https://vicove.com/theme/img/jokes-category/9.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "10", Name = "Компютри", PictureUrl = "https://vicove.com/theme/img/jokes-category/10.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "11", Name = "Лафоризми", PictureUrl = "https://vicove.com/theme/img/jokes-category/11.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "12", Name = "Мечо Пух", PictureUrl = "https://vicove.com/theme/img/jokes-category/12.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "13", Name = "Мръсни", PictureUrl = "https://vicove.com/theme/img/jokes-category/13.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "14", Name = "Пиянски", PictureUrl = "https://vicove.com/theme/img/jokes-category/14.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "15", Name = "По новините", PictureUrl = "https://vicove.com/theme/img/jokes-category/15.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "16", Name = "Политически", PictureUrl = "https://vicove.com/theme/img/jokes-category/16.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "17", Name = "Приказни", PictureUrl = "https://vicove.com/theme/img/jokes-category/17.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "18", Name = "Професионални", PictureUrl = "https://vicove.com/theme/img/jokes-category/18.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "19", Name = "Разни", PictureUrl = "https://vicove.com/theme/img/jokes-category/19.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "20", Name = "С*кс", PictureUrl = "https://vicove.com/theme/img/jokes-category/20.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "21", Name = "Само в България", PictureUrl = "https://vicove.com/theme/img/jokes-category/1.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "22", Name = "Семейни", PictureUrl = "https://vicove.com/theme/img/jokes-category/21.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "23", Name = "Спорт", PictureUrl = "https://vicove.com/theme/img/jokes-category/22.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "24", Name = "Студентски", PictureUrl = "https://vicove.com/theme/img/jokes-category/23.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "25", Name = "Ученически", PictureUrl = "https://vicove.com/theme/img/jokes-category/24.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "26", Name = "Черен хумор", PictureUrl = "https://vicove.com/theme/img/jokes-category/25.jpg", JokesCount = 5 });
            categories.Add(new JokesCategoryViewModel() { Id = "27", Name = "Чък Норис", PictureUrl = "https://vicove.com/theme/img/jokes-category/26.jpg", JokesCount = 5 });
            return this.Ok(categories);
        }

        //public IActionResult Privacy()
        //{
        //    return this.View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return this.View(
        //        new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        //}
    }
}
