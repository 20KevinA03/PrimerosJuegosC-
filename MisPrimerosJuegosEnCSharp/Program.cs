using PrimerosPasosNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisPrimerosJuegosEnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una opcion:");
            Console.WriteLine("1. Juego Ahorcado");
            Console.WriteLine("2. Tres en Raya");
            Console.WriteLine("3. Juego de la vida Conway");
            Console.WriteLine("4. Juego Memoriza");
            Console.WriteLine("5. Apuesta caballos");


            try
            {
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        JuegoAhorcado.Ahorcado();
                        break;
                    case 2:
                        TresEnRaya.Juego();
                        break;
                    case 3:
                        JuegoDeLaVidaConway.Juego();
                        break;
                    case 4:
                        JuegoMemoriza.Juego();
                        break;
                    case 5:
                        CarreraCaballos.Juego();
                        break;
                    default:
                        Console.WriteLine("No se ingreso numero de la opcion");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No se ingreso numero de la opcion");
                throw;
            }
        }
    }
}
