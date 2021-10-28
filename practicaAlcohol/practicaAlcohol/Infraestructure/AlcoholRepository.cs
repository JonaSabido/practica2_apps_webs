using System.ComponentModel;
using System.Dynamic;
using System.Reflection.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Universidad Tecnológica Metropolitana
// Aplicaciones Web Orientada a Servicios
// Maestro: Joel Ivan Chuc UC
// Actividad 2 - Calcular BAC
// Alumno: Jonathan Missael Sabido Reynoso
// 4C
// Parcial 2
// Entrega: 30/10/2021

namespace practicaAlcohol.Infraestructure
{
    public class AlcoholRepository
    {
        public string GetValues(string drink, double amount, double weight)
        {
            drink = drink.ToUpper();
            double degrees = 0;
            double ml = 0;

            switch (drink)
            {
                case "CERVEZA":
                    ml = 330 * amount;
                    degrees = 5;
                    break;
                case "VINO":
                case "CAVA":
                    ml = 100 * amount;
                    degrees = 12;
                    break;
                case "VERMU":
                    ml = 70 * amount;
                    degrees = 17;
                    break;
                case "LICOR":
                    ml = 45 * amount;
                    degrees = 23;
                    break;
                case "BRANDY":
                    ml = 45 * amount;
                    degrees = 38;
                    break;
                case "COMBINADO":
                    ml = 50 * amount;
                    degrees = 38;
                    break;
                default:
                    ml = 0;
                    degrees = 0;
                    return "Warning: Error en la bebida";
            }

            double BAC = BAC_Calculate(ml, degrees, weight);
            if(BAC <= 0.8){
                return "Alcoholemia: " + Convert.ToString((BAC).ToString("N3")) + ". ¡¡Tenga un buen viaje!!";
            }
            else{
                return "Alcoholemia: " + Convert.ToString((BAC).ToString("N3")) + ". ¡¡SE NECESITA APOYO!!";
            }
        }

        public double BAC_Calculate(double ml, double degrees, double weight)
        {
            double alcohol_consumed;
            double mass;
            double result;
            double v;
            double blood;

            alcohol_consumed = (degrees / 100) * ml;
            v = .15 * alcohol_consumed;
            mass = .789 * v;
            blood = weight * .08;
            result = mass / blood;

            return result;
        }
    }
}
