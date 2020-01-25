
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

          
        }

        //[Route("MostrarPelicula")]
        [HttpGet]
               
        public string Get(string MostrarTodo)
        {
             
            
           
            return MostrarTodo;

        }
        

    }
}
