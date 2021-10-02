using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


/*Nombre de la escuela: Universidad Tecnologica Metropolitana
Asignatura: Aplicaciones Web Orientadas a Objetos
Nombre del Maestro: Chuc Uc Joel Ivan
Nombre de la actividad: Ejercicio 2: Palindromos
Nombre del alumno: Brek Mejia Samuel Alexander
Cuatrimestre: 4
Grupo: B
Parcial: 1
*/


namespace Ejercicio2Palindromos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalinController : ControllerBase
    {
        [HttpGet]
        public IActionResult PalindromoResultado(string palindro)
        {
            var Palindromo = new Palindromo();
            Palindromo.palindromo = palindro;
            var PDefinitivo = string.Empty;
            var Pcount = palindro;
            int i = Pcount.Length;
            
            var FinalPalindromo = "";
            for (int j = i - 1; j >= 0; j--)
            {
                PDefinitivo = PDefinitivo + Pcount[j];
                
            }
            if (PDefinitivo.ToLower().Replace(" ", string.Empty).Replace(",", string.Empty) == Pcount.ToLower().Replace(" ", string.Empty).Replace(",", string.Empty))
            {
                FinalPalindromo = (Pcount + " es palindrome");
            }
            else
            {
                FinalPalindromo = (Pcount + " no es palindrome");
            }
            int Palabras = Pcount.Length - Pcount.Replace(" ", string.Empty).Count() + 1;
            var ResultadoFinal = ("La palabra ingresada: " + FinalPalindromo.ToLower() + ", su invertido es: " + PDefinitivo.ToLower() + " y la cantidad de palábras es: "+ Palabras);
            return Ok(ResultadoFinal.ToLower());
        }
    }
}
