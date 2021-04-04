namespace JokesWebApi.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    using JokesWebApi.Data.Common.Models;

    public class Joke : BaseDeletableModel<string>
    {
        public Joke()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Content { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

        [ForeignKey(nameof(ApplicationUser))]
        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        public virtual ICollection<Raiting> Raitings { get; set; }
    }
}
