namespace JokesWebApi.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    using JokesWebApi.Data.Common.Models;

    public class Raiting : BaseDeletableModel<string>
    {
        public int Value { get; set; }

        [ForeignKey(nameof(ApplicationUser))]
        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        [Required]
        [ForeignKey(nameof(Joke))]

        public string JokeId { get; set; }

        public virtual Joke Joke { get; set; }
    }
}
