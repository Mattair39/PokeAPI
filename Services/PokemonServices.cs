using Microsoft.Maui.Animations;
using PokeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace PokeAPI.Services
{
    public class PokemonServices
    {
        public HttpClient _httpClient;
        public PokemonServices()
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<PokemonItem>> DevuelveListadoPokemon()
        {
            string url = "https://pokeapi.co/api/v2/pokemon/?limit=151&offset=0";
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(url);
            ListPokemon lista_pokemon = JsonConvert.DeserializeObject<ListPokemon>(json);

            return lista_pokemon.results;
        }

        public async Task <PokemonInfo> DevuelveCaracteristicasPokemon (string url)
        {
            string json = await _httpClient.GetStringAsync(url);
            PokemonInfo caracteristicas = JsonConvert.DeserializeObject<PokemonInfo>(json);
            return caracteristicas;
        }
    }
}
