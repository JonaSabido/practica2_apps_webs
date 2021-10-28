using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practicaResistencia.Infraestructure;

// Universidad Tecnológica Metropolitana
// Aplicaciones Web Orientada a Servicios
// Maestro: Joel Ivan Chuc UC
// Actividad 2 - Calcular Resistencia
// Alumno: Jonathan Missael Sabido Reynoso
// 4C
// Parcial 2
// Entrega: 30/10/2021

namespace practicaResistencia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResistenciaController : ControllerBase
    {
        [HttpGet]
        [Route("{banda1}/{banda2}/{banda3}/{banda4}")]
        public string GetResistencia(string banda1, string banda2, string banda3, string banda4)
        {
            var repository = new ResistenciaRepository();
            string info = repository.CalculoOhmios(banda1, banda2, banda3, banda4);
            return info;
        }
    }
}
