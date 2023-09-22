﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class Jueves
    {
        static void Main(string[] args)
        {
            /*
           variables();
           usuario();
           pedirEdados();
           PedirEdadesCorregido();
           calificaciones();
            */
        }

        public static void calificaciones()
        {
            /* pedir nota y comprobar que esta entre 0 y 10 */

            int nota = 0;
            string calificacion = "";

            Console.WriteLine("Introduce la nota");

            try
            {
                nota = Convert.ToInt32(Console.ReadLine());

                if (nota >= 0 && nota <= 10)
                {
                    if (nota >= 0 && nota <= 4)
                    {
                        calificacion = "Suspenso";
                    }
                    else if (nota >= 5 && nota <= 7)
                    {
                        calificacion = "Bien";
                    }
                    else
                    {
                        calificacion = "Sobresaliente";
                    }

                    calificacion = string.Concat("La calificación es: ", calificacion);
                }
                else
                {
                    calificacion = "Escribe una nota valida";
                }

            }
            catch (FormatException)
            {
                calificacion = "¡Esa nota es irreal!";
            }

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(calificacion);
            //
            //sassasasasasa
           
        }

        public static void variables()
        {
            //variable año de nacimiento, año actual y para la edad
            //mostrar El año xxxx : tienes xx años
            int fecha_nacimiento = 2000;
            int ano_actual = 2023;
            int edad = ano_actual - fecha_nacimiento;
            Console.WriteLine("El año " + ano_actual + " : tienes " + edad
            + " años.");
        }

        public static void usuario()
        {
            // Type your username and press enter
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);
        }

        static void pedirEdados()
        {
            /*
          Pedimos el año de nacimiento al usuario
         Pedimos el nombre al usuario
         Guardamos los dos datos en variables
         Preguntamos el año en el que quiere saber los años que va a tener
         Mostramos en pantalla:"Hola, xxxxxx!!!"
                               "El año " + anioAct + " tendrás: " + edad + " años"


          */

            int fechaNacimiento = 0, fechaBuscar = 0, edad = 0;
            string usuarioPedir = "";

            try
            {

                Console.WriteLine("Introduzca año de nacimiento");
                fechaNacimiento = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduzca el usuario");
                usuarioPedir = Console.ReadLine();

                Console.WriteLine("¿De que año quiere saber su edad?");
                fechaBuscar = Convert.ToInt32(Console.ReadLine());

                edad = fechaBuscar - fechaNacimiento;
                Console.WriteLine("Hola, " + usuarioPedir + ". El año " + fechaBuscar + " tendrás: " + edad + " años");
                

            }
            catch (FormatException)
            {
                Console.WriteLine("No me seas asi eeeeee");
            }
        }

        public static void PedirEdadesCorregido()
        {
            int anioNac;
            int anioActual = DateTime.Now.Year;
            int anioDeseado = anioActual;
            string nombre = " ";
            int edadDeseada, edad = 0;


            try
            {
                Console.WriteLine("Escribe tu anio de nacimiento");
                anioNac = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escribe tu nombre");
                nombre = Console.ReadLine();

                Console.WriteLine("Escribe el año deseado:");
                anioDeseado = Convert.ToInt32(Console.ReadLine());

                edadDeseada = anioDeseado - anioNac;
                edad = anioActual - anioNac;

                Console.WriteLine("Holaa," + nombre + " ahora (" + anioActual + ") Tienes " + edad + " anos y el año:" + anioDeseado + " tendrás: " + edadDeseada + " años.");

            }catch (Exception)
            {
                Console.WriteLine("Escribe tu anio de nacimiento, TRAMPOSO...");
            }
        }

    }
}

