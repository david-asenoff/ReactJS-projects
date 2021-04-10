using JokesWebApi.Web.ViewModels.JokesCategories;
using System.Collections.Generic;

namespace JokesWebApi.Web.ViewModels.Jokes
{
    public class JokeUpdateViewModel
    {
        public string Id { get; set; }

        public JokeViewModel Joke { get; set; }

        public JokesCategoryViewModel Category { get; set; }
    }
}
