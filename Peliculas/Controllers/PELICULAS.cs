using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Peliculas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PELICULAS : ControllerBase
    {


        [HttpGet]
        //public IEnumerable<Pelicula> AñadirPelicula()
        //{
            
        //    return Enumerable.Range(1, 5).Select(index => new Pelicula
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
        

        [HttpPost]
        public IEnumerable<Pelicula>AñadirPeliculas([FromBody]string nombre, [FromBody]string director, [FromBody] int año)
        {
           Stack<Pelicula> Pila = new Stack<Pelicula>();
            var peliculas = new Pelicula
            {
                Nombre = nombre,
                Director = director,
                Año = año 

            };
            Pila.Push(peliculas);
             return Pila;
        }


    }
}
