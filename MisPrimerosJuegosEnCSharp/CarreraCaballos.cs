using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrimerosPasosNet
{
    public class CarreraCaballos
    {
        public static string[,] pista = new string[2, 20];
        public static int posicionCaballo1 = 0;
        public static int posicionCaballo2 = 0;

        public static void Juego()
        {
            Console.WriteLine("Ingrese a que caballo quiere apostar:\n1 = rojo\n2 = azul");
            int caballo = int.Parse(Console.ReadLine());
            Reiniciar();
            PosicionarCaballos();
            int ganador = Carrera();
            if (ganador == caballo)
            {
                Console.WriteLine("Ganaste");
            }
            else
            {
                Console.WriteLine("Perdiste");
            }

            Console.ReadLine();
        }

        public static void PosicionarCaballos()
        {
            pista[0, posicionCaballo1] = "*";
            pista[1, posicionCaballo2] = "*";
        }

        public static int Carrera()
        {
            bool termino = false;
            while (!termino)
            {
                Console.Clear();
                Random r = new Random();
                MostrarPista();
                int avanzarCaballo = r.Next(1, 3);
                if (avanzarCaballo == 1)
                {
                    posicionCaballo1 += 1;
                }
                else
                {
                    posicionCaballo2 += 1;
                }

                if (posicionCaballo1 == 19 || posicionCaballo2 == 19)
                {
                    termino = true;
                }

                Reiniciar();
                PosicionarCaballos();
                Thread.Sleep(300);
            }

            int ganador = 0;

            if (posicionCaballo1 == 19)
            {
                ganador = 1;
            }
            else
            {
                ganador = 2;
            }

            return ganador;
        }

        public static void MostrarPista()
        {
            Console.WriteLine("--------------------");
            Console.Write("-");

            for (int j = 0; j < 20; j++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(pista[0, j]);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("-");
            for (int j = 0; j < 20; j++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(pista[1, j]);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("--------------------");
        }

        public static void Reiniciar()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    pista[i, j] = " ";
                }
            }
        }
    }
}
