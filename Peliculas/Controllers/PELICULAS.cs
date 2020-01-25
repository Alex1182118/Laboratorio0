
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Peliculas.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Peliculas.Controllers
{
    [ApiController]
    [Route("Pelicula")]
    public class PELICULAS : ControllerBase
    {

        public readonly static List<Pelicula> PeliculaLista = new List<Pelicula>();

        
        [HttpPost]
        public void AñadirPeliculas([FromBody] Pelicula pelicula) 
        {
            PeliculaLista.Add(pelicula);
        }

        //[Route("MostrarPelicula")]
        [HttpGet]
               
        public string Get(string MostrarTodo)
        {

            if (PeliculaLista.Count < 10)
            {

                for (int i = 0; i < PeliculaLista.Count; i++)
                {


                    var mostrar = "\n" + "Nombre:" + PeliculaLista[i].Nombre + "\n" + "Director:"
                        + PeliculaLista[i].Director + "\n" + "Año:" + PeliculaLista[i].Año + "\n";
                    MostrarTodo += mostrar;

                }
            }
            else
            {
                for (int i = PeliculaLista.Count - 10; i < PeliculaLista.Count; i++)
                {

                    var mostrar = "\n" + "Nombre:" + PeliculaLista[i].Nombre + "\n" + "Director:"
                        + PeliculaLista[i].Director + "\n" + "Año:" + PeliculaLista[i].Año + "\n";
                    MostrarTodo += mostrar;
                }


            }

            return MostrarTodo;

        }
        

    }
}
