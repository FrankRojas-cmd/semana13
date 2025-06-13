using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace clases_Metodos
{
    public class Class1
    {
        public void animacion_de_entrada()
        {

            Console.WriteLine("CARGANDO...");
            Thread.Sleep(500);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" A H  O  R  C  A  D  O ");
            for (int i = 0; i < 8; i++)
            {
                if (i < 5)
                {
                    // Parte de suspenso: tonos graves descendentes
                    int frecuencia = 600 - (i * 60); // 600, 540, 480, 420, 360
                    Console.Beep(frecuencia, 600);
                    Thread.Sleep(200);
                }
                else
                {
                    // Parte de susto: tonos agudos cortos
                    Console.Beep(500, 100);
                    Thread.Sleep(100);
                }
            }
            Thread.Sleep(100);
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Preparando la soga...");
            Thread.Sleep(1000);
            Console.WriteLine("Buscando palabras secretas...");
            Thread.Sleep(1000);
            Console.WriteLine("¡Todo listo!");
            Thread.Sleep(800);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine(" B I E N V E N I D O ");
            Console.ForegroundColor = ConsoleColor.White;



        }
        public void animacion_de_salida()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" A D I O S ");
            for (int i = 0; i < 8; i++)
            {
                if (i < 5)
                {
                    // Parte de suspenso: tonos graves descendentes
                    int frecuencia = 600 - (i * 60); // 600, 540, 480, 420, 360
                    Console.Beep(frecuencia, 600);
                    Thread.Sleep(200);
                }
                else
                {
                    // Parte de susto: tonos agudos cortos
                    Console.Beep(1000, 100);
                    Thread.Sleep(100);
                }
            }
            Thread.Sleep(100);
            Thread.Sleep(250);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Gracias por jugar.");
            Thread.Sleep(500);
            Console.WriteLine("Esperamos que hayas disfrutado del juego.");
            Thread.Sleep(500);
            Console.WriteLine("¡Hasta la próxima!");
            Thread.Sleep(400);
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public void horca( int fallosRestantes)
        {
            switch (fallosRestantes)
            {
                case 7:
                    Console.WriteLine("-");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("----");
                    break;
                case 6:
                    Console.WriteLine("-------");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("----");
                    break;
                case 5:
                    Console.WriteLine("-------");
                    Console.WriteLine("|    |");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("----");
                    break;
                case 4:
                    Console.WriteLine("-------");
                    Console.WriteLine("|    |");
                    Console.WriteLine("|    O");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("----");
                    break;
                case 3:
                    Console.WriteLine("-------");
                    Console.WriteLine("|    |");
                    Console.WriteLine("|    O");
                    Console.WriteLine("|   /|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("----");
                    break;
                case 2:
                    Console.WriteLine("-------");
                    Console.WriteLine("|    |");
                    Console.WriteLine("|    O");
                    Console.WriteLine("|   /|\\");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("----");
                    break;
                case 1:
                    Console.WriteLine("-------");
                    Console.WriteLine("|    |");
                    Console.WriteLine("|    O");
                    Console.WriteLine("|   /|\\");
                    Console.WriteLine("|   / ");
                    Console.WriteLine("|");
                    Console.WriteLine("----");
                    break;
                case 0:
                    Console.WriteLine("-------");
                    Console.WriteLine("|    |");
                    Console.WriteLine("|    O");
                    Console.WriteLine("|   /|\\");
                    Console.WriteLine("|   / \\");
                    Console.WriteLine("|");
                    Console.WriteLine("----");
                    break;
            }
        }
        public void proceso()
        {
            // El ordenador escoge una palabra al azar (de entre un conjunto prefijado)
            string[] palabras = { "superman", "flash", "acuaman",
            "destino final", "stich", "minecraft" };
            Random generador = new Random();
            int numeroAzar = generador.Next(0, palabras.Length);
            string palabraAdivinar = palabras[numeroAzar];

            // Preparamos una palabra a mostrar (serie de guiones: ---- ----) desde ella
            string palabraMostrar = "";
            for (int i = 0; i < palabraAdivinar.Length; i++)
                if (palabraAdivinar[i] == ' ')
                    palabraMostrar += " ";
                else
                    palabraMostrar += "-";

            // Resto de variables
            int fallosRestantes = 8;
            char letraActual;
            bool terminado = false;

            // Parte repetitiva:
            do
            {
                // Mostramos la palabra oculta (y los fallos restantes)
                Console.WriteLine("Palabra oculta:  " + palabraMostrar);
                Console.WriteLine("Fallos restantes: " + fallosRestantes);

                // El usuario elige una letra
                Console.Write("Introduzca una letra: ");
                letraActual = char.Parse(Console.ReadLine());

                // Si la letra no es parte de la palabra, el jugador 
                // pierde un intento (de los ocho iniciales)
                if (!palabraAdivinar.Contains(letraActual))
                {
                    fallosRestantes--;
                    horca(fallosRestantes);
                }

                // Si la letra es parte de la palabra, el jugador no 
                // pierde ningún intento, y la letra se muestra como
                // parte de la palabra oculta: --a- -a--
                string siguienteMostrar = "";

                for (int i = 0; i < palabraAdivinar.Length; i++)
                {
                    if (letraActual == palabraAdivinar[i])
                        siguienteMostrar += letraActual;
                    else
                        siguienteMostrar += palabraMostrar[i];
                }
                palabraMostrar = siguienteMostrar;

                // Comprobamos si ha terminado: si el usuario se queda sin intentos
                // o si adivina toda la palabra.
                if (!palabraMostrar.Contains("-"))
                {
                    Console.WriteLine("Felicidades, acertaste!  ({0})",
                        palabraAdivinar);

                    terminado = true;
                }
                else if (fallosRestantes == 0)
                {
                    Console.WriteLine("Lo siento. Era " + palabraAdivinar);
                    terminado = true;
                }

                Console.WriteLine();

            }
            while (!terminado);
        }
        public void animacionganador()
        {
         
        }
    }
}
