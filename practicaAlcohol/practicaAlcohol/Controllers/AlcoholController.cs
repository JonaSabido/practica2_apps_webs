using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practicaAlcohol.Infraestructure;

// Universidad Tecnológica Metropolitana
// Aplicaciones Web Orientada a Servicios
// Maestro: Joel Ivan Chuc UC
// Actividad 2 - Calcular BAC
// Alumno: Jonathan Missael Sabido Reynoso
// 4C
// Parcial 2
// Entrega: 30/10/2021

namespace practicaAlcohol.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlcoholController : ControllerBase
    {
        [HttpGet]
        [Route("{drink}/{amount}/{weight}")]
        public string GetResult(string drink, double amount, double weight)
        {
            var repository = new AlcoholRepository();
            string result = repository.GetValues(drink, amount, weight);
            return result;
        }
    }
}
