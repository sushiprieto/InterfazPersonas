using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_InterfazPersonas.Models
{
    public class clsPersona
    {

        //private int id { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string sexo { get; set; }
        public double peso { get; set; }
        public double altura { get; set; }
        public string fechaNac { get; set; }

        /* Ctrl + r + e para generara Getters and Setters */


        public clsPersona()
        {
            //this.id = 0;
            this.dni = "";
            this.nombre = "";
            this.apellidos = "";
            this.fechaNac = "";
            this.sexo = "";
            this.peso = 0;
            this.altura = 0;
        }

        public clsPersona(string dni, string nombre, string apellidos, string fechaNac, string sexo, double peso, double altura)
        {
            //this.id = id;
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNac = fechaNac;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }

        public override string ToString()
        {
            return "DNI: " + dni + "\n" +
                   "Nombre: " + nombre + "\n" +
                   "Apellidos: " + apellidos + "\n" +
                   "Peso: " + peso + "\n" +
                   "Altura: " + altura + "\n" +
                   "Fecha de Nacimiento: " + fechaNac + "\n" +
                   "Sexo: " + sexo + "\n";
        }

    }
}