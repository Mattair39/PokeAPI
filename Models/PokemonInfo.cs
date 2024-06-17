using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI.Models
{
    public class PokemonInfo
    {
        public List<Abilities> abilities { get; set; }
        public Sprite sprites {  get; set; }
    }
}
