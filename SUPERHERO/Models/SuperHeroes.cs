using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SUPERHERO.Models
{
    public class SuperHeroes
    {
        [Key]
        public int Id { get; set; }
        public string HeroName { get; set; }
        public string AlterEgo { get; set; }
        public string HeroAbility { get; set; }
        public string SecondaryHeroAbility { get; set; }
        public string HeroCatchPhrase { get; set; }
    }
}