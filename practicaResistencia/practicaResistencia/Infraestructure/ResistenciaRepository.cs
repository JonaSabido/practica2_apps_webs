using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Universidad Tecnológica Metropolitana
// Aplicaciones Web Orientada a Servicios
// Maestro: Joel Ivan Chuc UC
// Actividad 2 - Calcular Resistencia
// Alumno: Jonathan Missael Sabido Reynoso
// 4C
// Parcial 2
// Entrega: 30/10/2021

namespace practicaResistencia.Infraestructure
{
    public class ResistenciaRepository
    {
        public string CalculoOhmios(string banda1, string banda2, string banda3, string banda4)
        {
            banda1 = banda1.ToUpper();
            banda2 = banda2.ToUpper();
            banda3 = banda3.ToUpper();
            banda4 = banda4.ToUpper();

            string error = "";
            float resultado = 0;
            string tolerancia = "";

            switch (banda1)
            {
                case "NEGRO":
                    resultado = 0;
                    break;
                case "CAFE":
                    resultado = 10;
                    break;
                case "ROJO":
                    resultado = 20;
                    break;
                case "NARANJA":
                    resultado = 30;
                    break;
                case "AMARILLO":
                    resultado = 40;
                    break;
                case "VERDE":
                    resultado = 50;
                    break;
                case "AZUL":
                    resultado = 60;
                    break;
                case "VIOLETA":
                    resultado = 70;
                    break;
                case "GRIS":
                    resultado = 80;
                    break;
                case "BLANCO":
                    resultado = 90;
                    break;
                default:
                    error = "Warning: Error en el color de la Banda 1. ";
                    break;
            }

            switch (banda2)
            {
                case "NEGRO":
                    resultado = resultado + 0;
                    break;
                case "CAFE":
                    resultado = resultado + 1;
                    break;
                case "ROJO":
                    resultado = resultado + 2;
                    break;
                case "NARANJA":
                    resultado = resultado + 3;
                    break;
                case "AMARILLO":
                    resultado = resultado + 4;
                    break;
                case "VERDE":
                    resultado = resultado + 5;
                    break;
                case "AZUL":
                    resultado = resultado + 6;
                    break;
                case "VIOLETA":
                    resultado = resultado + 7;
                    break;
                case "GRIS":
                    resultado = resultado + 8;
                    break;
                case "BLANCO":
                    resultado = resultado + 9;
                    break;
                default:
                    error = error + "Warning: Error en el color de la Banda 2. ";
                    break;
            }

            switch (banda3)
            {
                case "NEGRO":
                    resultado = resultado * 1;
                    break;
                case "CAFE":
                    resultado = resultado * 10;
                    break;
                case "ROJO":
                    resultado = resultado * 100;
                    break;
                case "NARANJA":
                    resultado = resultado * 1000;
                    break;
                case "AMARILLO":
                    resultado = resultado * 10000;
                    break;
                case "VERDE":
                    resultado = resultado * 100000;
                    break;
                case "AZUL":
                    resultado = resultado * 1000000;
                    break;
                case "DORADO":
                    resultado = resultado / 10;
                    break;
                case "PLATA":
                    resultado = resultado / 100;
                    break;
                default:
                    error = error + "Warning: Error en el color de la Banda 3. ";
                    break;
            }

            switch (banda4)
            {
                case "DORADO":
                    tolerancia = "5%";
                    break;
                case "PLATA":
                    tolerancia = "10%";
                    break;
                default:
                    error = error + "Warning: Error en el color de la Banda 4. ";
                    break;
            }

            if (error == "")
            {
                return banda1 + "," + banda2 + "," + banda3 + "," + banda4 + " = " + resultado + "Ω. Tolerancia de " + tolerancia;
            }
            else
            {
                return error;
            }
        }
    }
}
