using _006_InterfazPersonas.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_InterfazPersonas.Controllers
{
    public static class clsPersonaController
    {

        public static List<clsPersona> personas = new List<clsPersona>();

        /// <summary>
        /// Metodo que muestra todas las personas que existen
        /// </summary>
        /// <returns></returns>
        public static string MostrarPersona()
        {
            for (int i = 0; i < personas.Count; i++)
            {

                return personas[i].ToString();

            }

            return null;

        }

        /// <summary>
        /// Metodo que inserta una persona
        /// </summary>
        /// <param name="p"></param>
        public static void InsertarPersona(clsPersona p)
        {

            //Comprobamos que no sea nulo
            if (p != null)
            {

                personas.Add(p);

            }

        }

        /// <summary>
        /// Muestra la persona mas alta
        /// </summary>
        /// <returns></returns>
        public static string OrdenarAltura()
        {

            double alturaMax = 0;

            for (int i = 0; i < personas.Count; i++)
            {

                if (alturaMax < personas[i].altura)
                {

                    alturaMax = personas[i].altura;

                }

            }

            for (int i = 0; i < personas.Count; i++)
            {

                if (personas[i].altura == alturaMax)
                {

                    return personas[i].ToString();

                }

            }

            return null;

        }

        /// <summary>
        /// Metodo que muestra la persona con menos peso
        /// </summary>
        /// <returns></returns>
        public static string OrdenarPeso()
        {

            double pesoMin = 0;

            for (int i = 0; i < personas.Count; i++)
            {

                if (pesoMin < personas[i].peso)
                {

                    pesoMin = personas[i].peso;

                }

            }

            for (int i = 0; i < personas.Count; i++)
            {

                if (personas[i].peso == pesoMin)
                {

                    return personas[i].ToString();

                }

            }

            return null;

        }

        /// <summary>
        /// Metodo que se le pasa un dni y consulta en la lista si existe ese dni y lo muestra
        /// </summary>
        /// <returns></returns>
        public static string ConsultarDNI(string dni)
        {

            string textBlock = "";

            for (int i = 0; i < personas.Count; i++)
            {
                if (dni.Equals(personas[i].dni))
                {
                    return textBlock = personas[i].ToString();
                }
                else
                {
                    return textBlock = "El DNI no coincide o el campo está vacio.";
                }
            }

            return null;

        }

    }
}
