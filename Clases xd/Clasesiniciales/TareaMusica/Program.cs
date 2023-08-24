using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaMusica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esto es una instancia
            Musica Instancia01 = new Musica();
            //Album
            Instancia01.album = new Album();
            Instancia01.album.AnioDeLanzamiento = 2012;
            Instancia01.album.NumeroDeCanciones = 11;
            Instancia01.album.NombreDelAlbum = "Hawaii: Part II";
            Instancia01.album.DuracionDelAlbum = 42; //minutos
            Instancia01.album.CompaniaDiscografica = "Mirakurumyūjikaru (Milagro Musical)";
            //Cancion
            Instancia01.cancion = new Cancion();
            Instancia01.cancion.NombreDeCancion = "Dream Sweet in Sea Major";
            Instancia01.cancion.DuracionDeCancionMinAprox = 7;
            Instancia01.cancion.ReproduccionesEnSpotify = 65201417;
            Instancia01.cancion.NumeroDePista = 11;
            Instancia01.cancion.InstrumentaloNo = "No";
            //Artista
            Instancia01.artista = new Artista();
            Instancia01.artista.NombreDelArtista = "Miracle Musical";
            Instancia01.artista.Genero = "Indie";
            Instancia01.artista.Nacionalidad = "Estadounidense";
            Instancia01.artista.AnioDelDebut = 2012;
            Instancia01.artista.ArtistasSimilares = "bo en, Tally Hall";


            //Esto es otra instancia
            Musica Instancia02 = new Musica();
            //Album
            Instancia02.album = new Album();
            Instancia02.album.AnioDeLanzamiento = 2021;
            Instancia02.album.NumeroDeCanciones = 7;
            Instancia02.album.NombreDelAlbum = "Pebble Brain";
            Instancia02.album.DuracionDelAlbum = 23; //minutos
            Instancia02.album.CompaniaDiscografica = "Anvil Cat Records";
            //Cancion
            Instancia02.cancion = new Cancion();
            Instancia02.cancion.NombreDeCancion = "The Fall";
            Instancia02.cancion.DuracionDeCancionMinAprox = 3;
            Instancia02.cancion.ReproduccionesEnSpotify = 52247267;
            Instancia02.cancion.NumeroDePista = 6;
            Instancia02.cancion.InstrumentaloNo = "No";
            //Artista
            Instancia02.artista = new Artista();
            Instancia02.artista.NombreDelArtista = "Lovejoy";
            Instancia02.artista.Genero = "Indie";
            Instancia02.artista.Nacionalidad = "Britanica";
            Instancia02.artista.AnioDelDebut = 2021;
            Instancia02.artista.ArtistasSimilares = "Los Campesinos!,The Oh Hellos";


            //Esto es otra instancia mas
            Musica Instancia03 = new Musica();
            //Album
            Instancia03.album = new Album();
            Instancia03.album.AnioDeLanzamiento = 2022;
            Instancia03.album.NumeroDeCanciones = 16;
            Instancia03.album.NombreDelAlbum = "In case I make it,";
            Instancia03.album.DuracionDelAlbum = 72; //minutos
            Instancia03.album.CompaniaDiscografica = "Will Wood";
            //Cancion
            Instancia03.cancion = new Cancion();
            Instancia03.cancion.NombreDeCancion = "The Main Character";
            Instancia03.cancion.DuracionDeCancionMinAprox = 4;
            Instancia03.cancion.ReproduccionesEnSpotify = 12388073;
            Instancia03.cancion.NumeroDePista = 11;
            Instancia03.cancion.InstrumentaloNo = "No";
            //Artista
            Instancia03.artista = new Artista();
            Instancia03.artista.NombreDelArtista = "Will Wood";
            Instancia03.artista.Genero = "Indie";
            Instancia03.artista.Nacionalidad = "EstadoUnidence";
            Instancia03.artista.AnioDelDebut = 2015;
            Instancia03.artista.ArtistasSimilares = "Rio Romeo,Over The Garden Wall";
        }
    }
}
