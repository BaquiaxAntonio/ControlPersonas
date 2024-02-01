using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ControlPersonas
{
    internal class Persona
    {
        //campos 
        //privados opara cumplir con
        //el encasulado
        String dpi;
        String nombre;
        String apellido;
        DateTime fechaNacimiento;

        public Persona()
        {
            dpi = "";
            nombre = "";
            apellido = "";
            fechaNacimiento = DateTime.Now;

        }

        // encapsulamdo
        public String Dpi { get => dpi; set => dpi = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        //get
        //a = Dpi
        //set
        //Dpi=1"2213213":

        //Metodos que se realizan 
        public void PrimeraMayuscula()
        {
            if (nombre.Length > 0)
            {
                StringBuilder NombreMayuscula = new StringBuilder(nombre);
                NombreMayuscula[0] = char.ToUpper(NombreMayuscula[0]);
                nombre = NombreMayuscula.ToString();
                nombre = Regex.Replace(nombre, @"[^a-zA-Z]", "");
            }
            if (apellido.Length > 0)
            {
                StringBuilder apellidoMayuscula = new StringBuilder(apellido);
                apellidoMayuscula[0] = char.ToUpper(apellidoMayuscula[0]);
                apellido = apellidoMayuscula.ToString();
                apellido = Regex.Replace(apellido, @"[^a-zA-Z]", "");
            }
        }

        public int edad()
        {
            int edad = 0;
            //Calcular edad
            int mesNacimiento = fechaNacimiento.Month;
            int añoNacimiento = fechaNacimiento.Year;
            int diaNacimiento = fechaNacimiento.Day;

            int mesActual = DateTime.Now.Month;
            int añoActual = DateTime.Now.Year;
            int diaActual = DateTime.Now.Day;


            if ((diaActual >= diaNacimiento) && (mesActual >= mesNacimiento))
            {
                edad = añoActual - añoNacimiento;
            }
            else
            {
                edad = (añoActual - añoNacimiento) - 1;
            }
            return edad;

        }
    }
}
