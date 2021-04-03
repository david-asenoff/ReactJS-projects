using JokesWebApi.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JokesWebApi.Data.Models
{
    public class Joke : BaseDeletableModel<string>
    {
        public string Content { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

        [ForeignKey(nameof(ApplicationUser))]
        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        public virtual ICollection<Raiting> Raitings { get; set; }

    }
}
