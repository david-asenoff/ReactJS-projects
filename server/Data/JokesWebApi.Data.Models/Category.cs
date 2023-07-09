namespace JokesWebApi.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using JokesWebApi.Data.Common.Models;

    public class Category : BaseDeletableModel<string>
    {
        public Category()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Name { get; set; }

        public string PictureUrl { get; set; }

        public virtual ICollection<Joke> Jokes { get; set; }
    }
}
