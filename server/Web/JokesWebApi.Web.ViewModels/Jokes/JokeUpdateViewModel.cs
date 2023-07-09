namespace JokesWebApi.Web.ViewModels.Jokes
{
    using System.Collections.Generic;

    using JokesWebApi.Web.ViewModels.JokesCategories;

    public class JokeUpdateViewModel
    {
        public string Id { get; set; }

        public string EditedText { get; set; }
    }
}
