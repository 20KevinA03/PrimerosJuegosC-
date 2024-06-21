using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MisPrimerosJuegosEnCSharp
{
    class JuegoDeLaVidaConway
    {
        public static string[,] Tablero = new string[30, 40];
        public static string[,] TableroCelulas = new string[30, 40];

        public static void Juego() 
        {
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.Black;
            llenar();
            Console.WriteLine("Ingrese un patron, del uno al 5");
            string patron = Console.ReadLine();

            switch (patron)
            {
                case "1":
                    patron1();
                    break;
                case "2":
                    patron2();
                    break;
                case "3":
                    patron3();
                    break;
                case "4":
                    patron4();
                    break;
                case "5":
                    patron5();
                    break;
                default:
                    patron1();
                    break;
            }

            Console.Clear();

            bool infinito = true;
            while (infinito == true)
            {

                mostrar();

                for (int Filam = 1; Filam < 19; Filam++)
                {
                    for (int Columnam = 1; Columnam < 29; Columnam++)
                    {

                        int EstadoCel = verifica(Filam, Columnam);

                        if (EstadoCel == 1)
                        {
                            vive(Filam, Columnam);
                        }
                        else if (EstadoCel == 2)
                        {
                            vive(Filam, Columnam);
                        }
                        else
                        {
                            muere(Filam, Columnam);
                        }
                    }
                }

                for (int Fila = 0; Fila < 20; Fila++)
                {
                    for (int Columna = 0; Columna < 30; Columna++)
                    {
                        Tablero[Fila, Columna] = TableroCelulas[Fila, Columna];
                    }
                }
                // Console.ReadKey();
                Thread.Sleep(10);
                Console.Clear();
            }
        }

        static void llenar()
        {
            for (int Fila = 0; Fila < 20; Fila++)
            {
                for (int Columna = 0; Columna < 30; Columna++)
                {
                    Tablero[Fila, Columna] = "     ";
                }
            }
        }

        public static void vive(int f, int c)
        {
            TableroCelulas[f, c] = "  ■  ";
        }

        public static void muere(int f, int c)
        {
            TableroCelulas[f, c] = "     ";
        }

        public static int verifica(int Fila, int Columna)
        {
            int contador = 0;
            int Vfila = 0;
            int Vcolumna = 0;
            int VerificaCelula = 0;

            Vfila = Fila - 1;
            Vcolumna = Columna - 1;

            for (int i = 1; i <= 3; i++)
            {
                if (Tablero[Vfila, Vcolumna] == "  ■  ")
                {
                    contador = contador + 1;
                }
                Vcolumna = Vcolumna + 1;
            }

            Vfila = Fila;
            Vcolumna = Columna - 1;
            for (int i = 1; i <= 2; i++)
            {
                if (Tablero[Vfila, Vcolumna] == "  ■  ")
                {
                    contador = contador + 1;
                }
                Vcolumna = Vcolumna + 2;
            }

            Vfila = Fila + 1;
            Vcolumna = Columna - 1;
            for (int i = 1; i <= 3; i++)
            {
                if (Tablero[Vfila, Vcolumna] == "  ■  ")
                {
                    contador = contador + 1;
                }
                Vcolumna = Vcolumna + 1;
            }

            if (Tablero[Fila, Columna] == "     " && contador == 3)
            {
                VerificaCelula = 1;
            }
            else if (Tablero[Fila, Columna] == "  ■  " && (contador == 2 || contador == 3))
            {
                VerificaCelula = 2;
            }
            else
            {
                VerificaCelula = 0;
            }

            return VerificaCelula;

        }

        static void patron1()
        {
            Tablero[8, 13] = "  ■  ";
            Tablero[8, 14] = "  ■  ";
            Tablero[8, 15] = "  ■  ";
            //Tablero[9,15]="  ■  ";
            //Tablero[10,14]="  ■  ";
        }

        static void patron2()
        {
            Tablero[7, 20] = "  ■  ";
            Tablero[6, 20] = "  ■  ";
            Tablero[5, 21] = "  ■  ";
            Tablero[6, 22] = "  ■  ";
            Tablero[7, 23] = "  ■  ";
            Tablero[8, 22] = "  ■  ";
            Tablero[9, 22] = "  ■  ";
            Tablero[9, 23] = "  ■  ";
            Tablero[9, 25] = "  ■  ";
            Tablero[9, 26] = "  ■  ";
            Tablero[8, 26] = "  ■  ";
            Tablero[7, 25] = "  ■  ";
            Tablero[6, 26] = "  ■  ";
            Tablero[5, 27] = "  ■  ";
            Tablero[6, 28] = "  ■  ";
            Tablero[7, 28] = "  ■  ";
        }

        static void patron3()
        {
            Tablero[13, 10] = "  ■  ";
            Tablero[12, 10] = "  ■  ";
            Tablero[12, 9] = "  ■  ";
            Tablero[13, 8] = "  ■  ";
            Tablero[12, 8] = "  ■  ";
            Tablero[11, 7] = "  ■  ";
            Tablero[10, 8] = "  ■  ";
            Tablero[8, 7] = "  ■  ";
            Tablero[8, 8] = "  ■  ";
            Tablero[7, 8] = "  ■  ";
            Tablero[6, 8] = "  ■  ";
            Tablero[6, 7] = "  ■  ";
            Tablero[5, 9] = "  ■  ";
            Tablero[6, 10] = "  ■  ";
            Tablero[5, 12] = "  ■  ";
            Tablero[6, 12] = "  ■  ";
            Tablero[6, 13] = "  ■  ";
            Tablero[5, 14] = "  ■  ";
            Tablero[6, 14] = "  ■  ";
            Tablero[7, 15] = "  ■  ";
            Tablero[8, 14] = "  ■  ";
            Tablero[10, 14] = "  ■  ";
            Tablero[10, 15] = "  ■  ";
            Tablero[11, 14] = "  ■  ";
            Tablero[12, 14] = "  ■  ";
            Tablero[12, 15] = "  ■  ";
            Tablero[13, 13] = "  ■  ";
            Tablero[12, 12] = "  ■  ";
        }

        static void patron4()
        {
            Tablero[4, 3] = "  ■  ";
            Tablero[4, 4] = "  ■  ";
            Tablero[5, 6] = "  ■  ";
            Tablero[6, 7] = "  ■  ";
            Tablero[7, 7] = "  ■  ";
            Tablero[8, 7] = "  ■  ";
            Tablero[8, 6] = "  ■  ";
            Tablero[8, 5] = "  ■  ";
            Tablero[8, 4] = "  ■  ";
            Tablero[8, 3] = "  ■  ";
            Tablero[8, 2] = "  ■  ";
            Tablero[7, 1] = "  ■  ";
            Tablero[5, 1] = "  ■  ";
        }

        static void patron5()
        {
            Tablero[8, 13] = "  ■  ";
            Tablero[8, 14] = "  ■  ";
            Tablero[9, 14] = "  ■  ";
            Tablero[9, 15] = "  ■  ";
            Tablero[10, 14] = "  ■  ";
        }

        static void mostrar()
        {
            for (int Fila = 0; Fila < 20; Fila++)
            {
                for (int Columna = 0; Columna < 30; Columna++)
                {
                    Console.Write(Tablero[Fila, Columna]);
                    if (Columna == 29)
                    {
                        Console.WriteLine(" \n");
                    }
                }
            }
        }
    }
}
