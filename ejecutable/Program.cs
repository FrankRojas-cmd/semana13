using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clases_Metodos;

namespace ejecutable
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Class1 x = new Class1();
            x.animacion_de_entrada();
            Console.WriteLine("\nPresiona una tecla para comenzar...");
            Console.ReadKey();
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine(" MENÚ PRINCIPAL ");
                Console.WriteLine("1. Iniciar Juego");
                Console.WriteLine("2. Descripción del Juego");
                Console.WriteLine("3. Créditos");
                Console.WriteLine("4. Salir");
                Console.Write("Selecciona una opción (1-4): ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        IniciarJuego();
                        break;
                    case "2":
                        MostrarDescripcion();
                        break;
                    case "3":
                        MostrarCreditos();
                        break;
                    case "4":
                        salir = true;
                        Console.WriteLine("Saliendo del juego... ¡Hasta pronto!");
                        x.animacion_de_salida();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presiona una tecla para continuar...");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine("Presiona una tecla para volver al menú...");
                    Console.ReadKey();
                }
            }
        }

        static void IniciarJuego()
        {
            Console.Clear();
            Console.WriteLine("\n[Iniciando el juego...]");
            Class1 x = new Class1();
            x.proceso();
        }

        static void MostrarDescripcion()
        {
            Console.Clear();
            Console.WriteLine("[Descripción del Juego]");
            Console.WriteLine("Este clásico juego de adivinanzas pondrá a prueba tu vocabulario, lógica y nervios. ");
            Console.WriteLine("Deberás adivinar la palabra secreta antes de que se complete el dibujo de la horca.");
            Console.WriteLine("Cada error te acercará más a la derrota, ¡así que piensa bien tus respuestas!");

        }

        static void MostrarCreditos()
        {
            Console.Clear();
            Console.WriteLine("[Créditos]");
            Console.WriteLine("Desarrollado por: JHANN FRANK ROJAS VALDIVIA ");
            Console.WriteLine("Y SUMIL");
            Console.WriteLine("Gracias por jugar :)");
        }
    
    }
}
