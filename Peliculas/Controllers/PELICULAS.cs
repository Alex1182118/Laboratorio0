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
              
                
        //[HttpGet]
        //public IEnumerable<Pelicula> AñadirPelicula()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new Pelicula
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
        Stack<Pelicula> Pila = new Stack<Pelicula>();

        [HttpPost]
        public IEnumerable<Pelicula> ObtenerPeliculas()
        {
            

            
            
        }


    }
}
