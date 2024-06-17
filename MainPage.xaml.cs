using PokeAPI.Models;
using PokeAPI.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PokeAPI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CargarData();
        }

        public async void CargarData()
        {
            PokemonServices poke_services = new PokemonServices();
            var listado_pokemon = await poke_services.DevuelveListadoPokemon();

            ListaPokemon.ItemsSource = listado_pokemon;
        }

        public async void MostrarInfoPokemon (object sender, SelectedItemChangedEventArgs e)
        {
            PokemonItem poke_info = (PokemonItem)e.SelectedItem;
            Navigation.PushAsync(new ResumenPokemon(poke_info.url));

        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}
