using JokesWebApi.Web.ViewModels.JokesCategories;
using System.Collections.Generic;

namespace JokesWebApi.Web.ViewModels.Jokes
{
    public class JokeCreateViewModel
    {
        public string Content { get; set; }

        public string Name { get; set; }

        public string PictureUrl { get; set; }
    }
}
