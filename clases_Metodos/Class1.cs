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
            Thread.Sleep(1000);
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
                    Console.Beep(1000, 100);
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
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Gracias por jugar.");
            Thread.Sleep(1000);
            Console.WriteLine("Esperamos que hayas disfrutado del juego.");
            Thread.Sleep(1000);
            Console.WriteLine("¡Hasta la próxima!");
            Thread.Sleep(800);
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public void proceso()
        {

        }
    }
}
