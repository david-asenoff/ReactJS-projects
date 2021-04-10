namespace JokesWebApi.Web.ViewModels.Jokes
{
    using System.Collections.Generic;

    using JokesWebApi.Web.ViewModels.JokesCategories;

    public class JokeCreateViewModel
    {
        public string Content { get; set; }

        public string Name { get; set; }

        public string PictureUrl { get; set; }
    }
}
