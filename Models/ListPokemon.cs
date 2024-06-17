using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI.Models
{
    public class ListPokemon
    {
        public int count {  get; set; }
        
        public List<PokemonItem> results { get; set; }
    }
}
