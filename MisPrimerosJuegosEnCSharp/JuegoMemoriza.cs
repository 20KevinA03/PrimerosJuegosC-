using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisPrimerosJuegosEnCSharp
{
    class JuegoMemoriza
    {
        public static void Juego()
        {
            int record = 0;
            bool seguirjugando = true;
            while (seguirjugando == true)
            {
                int intentos = 0;
                bool finjuego = false;

                matriz.vaciararrayfiguras();
                matriz.llenararray();
                matriz.ordena();
                while (finjuego == false)
                {
                    int fila1 = 0;
                    int columna1 = 0;
                    int fila2 = 0;
                    int columna2 = 0;
                    string letra1 = "";
                    string letra2 = "";

                    bool correccion1 = true;
                    /*verifica que la primera letra se ingrese correctamente*/
                    while (correccion1 == true)
                    {
                        Console.Clear();
                        Console.WriteLine("\nmemoriza                        record:" + record + " intentos\n\n");
                        matriz.mostrararrayletras();
                        Console.Write("\nescriba la primera letra que desea mostrar: ");
                        letra1 = Console.ReadLine();

                        if (letra1 == "a" || letra1 == "b" || letra1 == "c" || letra1 == "d" || letra1 == "e" || letra1 == "f" || letra1 == "g" || letra1 == "h" || letra1 == "i" || letra1 == "j" || letra1 == "k" || letra1 == "l" || letra1 == "m" || letra1 == "n" || letra1 == "o" || letra1 == "p")
                        {
                            (fila1, columna1) = matriz.verificacampo(letra1);

                            if (fila1 != 505 && columna1 != 505)
                            {
                                matriz.mostrarseleccion(fila1, columna1);
                                correccion1 = false;
                            }
                            else
                            {
                                Console.WriteLine("error: ya has seleccionado este recuadro, intenta de nuevo");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("error: letra que se ingreso no esta permitida, intenta de nuevo");
                            Console.ReadKey();
                        }
                    }

                    bool correccion2 = true;
                    while (correccion2 == true)
                    {
                        Console.Clear();
                        Console.WriteLine("\nmemoriza                        record:" + record + " intentos\n\n");
                        matriz.mostrararrayletras();
                        Console.Write("\nescriba la segunda letra que desea mostrar: ");
                        letra2 = Console.ReadLine();

                        if (letra2 == "a" || letra2 == "b" || letra2 == "c" || letra2 == "d" || letra2 == "e" || letra2 == "f" || letra2 == "g" || letra2 == "h" || letra2 == "i" || letra2 == "j" || letra2 == "k" || letra2 == "l" || letra2 == "m" || letra2 == "n" || letra2 == "o" || letra2 == "p")
                        {

                            (fila2, columna2) = matriz.verificacampo(letra2);
                            if (fila2 != 505 && columna2 != 505)
                            {
                                matriz.mostrarseleccion(fila2, columna2);
                                correccion2 = false;
                            }
                            else
                            {
                                Console.WriteLine("error: ya has seleccionado este recuadro, intenta de nuevo");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("error: letra que se ingreso no esta permitida, intenta de nuevo");
                            Console.ReadKey();
                        }
                    }

                    Console.Clear();
                    Console.WriteLine("\nmemoriza                        record:" + record + " intentos\n\n");
                    matriz.mostrararrayletras();

                    string correcto = matriz.verificaselecciones(fila1, columna1, fila2, columna2);

                    if (correcto == "no")
                    {
                        matriz.reemplazacampo(letra1, fila1, columna1, letra2, fila2, columna2);
                        Console.WriteLine("\nfiguras no son iguales, intente de nuevo");
                        intentos = intentos + 1;
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("\nmuy bien, encontraste una pareja");
                        intentos = intentos + 1;
                        Console.ReadKey();
                        Console.Clear();
                    }

                    int correctas = matriz.verificaganar();
                    if (correctas == 16)
                    {
                        Console.WriteLine("memoriza\n\n");
                        matriz.mostrararrayletras();
                        Console.WriteLine("\nfelicidades, encontraste todas la figuras");
                        Console.WriteLine("numero de intentos: " + intentos);
                        if (record == 0)
                        {
                            record = intentos;
                        }
                        else if (intentos < record)
                        {
                            record = intentos;
                        }
                        finjuego = true;
                    }
                    else
                    {
                        finjuego = false;
                    }
                }

                Console.Write("\nquiere volver a jugar: si/no ");
                string seguir = Console.ReadLine();

                if (seguir == "no" || seguir == "no" || seguir == "no")
                {
                    seguirjugando = false;
                }
                else
                {
                    Console.Clear();
                    seguirjugando = true;
                }
            }
        }
    }

    class matriz
    {

        public static string[,] memorizam = new string[4, 4];
        public static string[,] mostrarm = new string[4, 4];

        public static void mostrarseleccion(int fila, int columna)
        {
            mostrarm[fila, columna] = memorizam[fila, columna];
        }

        public static void reemplazacampo(string letra1, int f1, int col1, string letra2, int f2, int col2)
        {
            mostrarm[f1, col1] = letra1;
            mostrarm[f2, col2] = letra2;
        }

        public static int verificaganar()
        {
            int correctas = 0;
            for (int fila = 0; fila <= 3; fila++)
            {
                for (int columna = 0; columna <= 3; columna++)
                {
                    if (mostrarm[fila, columna] == memorizam[fila, columna])
                    {
                        correctas = correctas + 1;
                    }
                    else
                    {
                        correctas = correctas + 0;
                    }
                }
            }
            return correctas;
        }

        public static (int, int) verificacampo(string seleccion)
        {
            int fila = 0;
            int columna = 0;
            switch (seleccion)
            {
                case "a":
                    if (mostrarm[0, 0] == "a")
                    {
                        fila = 0;
                        columna = 0;
                    }
                    else
                    {
                        fila = 505;
                        columna = 505;
                    }
                    break;
                case "b":
                    if (mostrarm[0, 1] == "b")
                    {
                        fila = 0;
                        columna = 1;
                    }
                    else
                    {
                        fila = 505;
                        columna = 505;
                    }
                    break;
                case "c":
                    if (mostrarm[0, 2] == "c")
                    {
                        fila = 0;
                        columna = 2;
                    }
                    else
                    {
                        fila = 505;
                        columna = 505;
                    }
                    break;
                case "d":
                    if (mostrarm[0, 3] == "d")
                    {
                        fila = 0;
                        columna = 3;
                    }
                    else
                    {
                        fila = 505;
                        columna = 505;
                    }
                    break;
                case "e":
                    if (mostrarm[1, 0] == "e")
                    {
                        fila = 1;
                        columna = 0;
                    }
                    else
                    {
                        fila = 505;
                        columna = 505;
                    }
                    break;
                case "f":
                    if (mostrarm[1, 1] == "f")
                    {
                        fila = 1;
                        columna = 1;
                    }
                    else
                    {
                        fila = 505;
                        columna = 505;
                    }
                    break;
                case "g":
                    if (mostrarm[1, 2] == "g")
                    {
                        fila = 1;
                        columna = 2;
                    }
                    else
                    {
                        fila = 505;
                        columna = 505;
                    }
                    break;
                case "h":
                    if (mostrarm[1, 3] == "h")
                    {
                        fila = 1;
                        columna = 3;
                    }
                    else
                    {
                        fila = 505;
                        columna = 505;
                    }
                    break;
                case "i":
                    if (mostrarm[2, 0] == "i")
                    {
                        fila = 2;
                        columna = 0;
                    }
                    else
                    {
                        fila = 505;
                        columna = 505;
                    }
                    break;
                case "j":
                    if (mostrarm[2, 1] == "j")
                    {
                        fila = 2;
                        columna = 1;
                    }
                    else
                    {
                        fila = 505;
                        columna = 505;
                    }
                    break;
                case "k":
                    if (mostrarm[2, 2] == "k")
                    {
                        fila = 2;
                        columna = 2;
                    }
                    else
                    {
                        fila = 505;
                        columna = 505;
                    }
                    break;
                case "l":
                    if (mostrarm[2, 3] == "l")
                    {
                        fila = 2;
                        columna = 3;
                    }
                    else
                    {
                        fila = 505;
                        columna = 505;
                    }
                    break;
                case "m":
                    if (mostrarm[3, 0] == "m")
                    {
                        fila = 3;
                        columna = 0;
                    }
                    else
                    {
                        fila = 505;
                        columna = 505;
                    }
                    break;
                case "n":
                    if (mostrarm[3, 1] == "n")
                    {
                        fila = 3;
                        columna = 1;
                    }
                    else
                    {
                        fila = 505;
                        columna = 505;
                    }
                    break;
                case "o":
                    if (mostrarm[3, 2] == "o")
                    {
                        fila = 3;
                        columna = 2;
                    }
                    else
                    {
                        fila = 505;
                        columna = 505;
                    }
                    break;
                case "p":
                    if (mostrarm[3, 3] == "p")
                    {
                        fila = 3;
                        columna = 3;
                    }
                    else
                    {
                        fila = 505;
                        columna = 505;
                    }
                    break;
            }
            return (fila, columna);
        }

        public static string verificaselecciones(int f1, int col1, int f2, int col2)
        {
            string correcto = "";
            if (mostrarm[f1, col1] == mostrarm[f2, col2])
            {
                correcto = "si";
            }
            else
            {
                correcto = "no";
            }
            return correcto;
        }

        public static string figura1()
        {
            string f1 = "♠";
            return f1;
        }

        public static string figura2()
        {
            string f2 = "&";
            return f2;
        }

        public static string figura3()
        {
            string f3 = "$";
            return f3;
        }

        public static string figura4()
        {
            string f4 = "♣";
            return f4;
        }

        public static string figura5()
        {
            string f5 = "☻";
            return f5;
        }

        public static string figura6()
        {
            string f6 = "♥";
            return f6;
        }

        public static string figura7()
        {
            string f7 = "♦";
            return f7;
        }

        public static string figura8()
        {
            string f8 = "♫";
            return f8;
        }


        public static void ordena()
        {
            bool espacio = true;
            int fila = 0;
            int columna = 0;

            for (int i = 1; i <= 2; i++)
            {
                while (espacio == true)
                {
                    Random numero = new Random();
                    fila = numero.Next(0, 4);
                    columna = numero.Next(0, 4);
                    if (memorizam[fila, columna] == "" || memorizam[fila, columna] == null)
                    {
                        memorizam[fila, columna] = figura1();
                        espacio = false;
                    }
                    else
                    {
                        espacio = true;
                    }
                }
                espacio = true;
                while (espacio == true)
                {
                    Random numero = new Random();
                    fila = numero.Next(0, 4);
                    columna = numero.Next(0, 4);
                    if (memorizam[fila, columna] == "" || memorizam[fila, columna] == null)
                    {
                        memorizam[fila, columna] = figura2();
                        espacio = false;
                    }
                    else
                    {
                        espacio = true;
                    }
                }
                espacio = true;
                while (espacio == true)
                {
                    Random numero = new Random();
                    fila = numero.Next(0, 4);
                    columna = numero.Next(0, 4);
                    if (memorizam[fila, columna] == "" || memorizam[fila, columna] == null)
                    {
                        memorizam[fila, columna] = figura3();
                        espacio = false;
                    }
                    else
                    {
                        espacio = true;
                    }
                }
                espacio = true;
                while (espacio == true)
                {
                    Random numero = new Random();
                    fila = numero.Next(0, 4);
                    columna = numero.Next(0, 4);
                    if (memorizam[fila, columna] == "" || memorizam[fila, columna] == null)
                    {
                        memorizam[fila, columna] = figura4();
                        espacio = false;
                    }
                    else
                    {
                        espacio = true;
                    }
                }
                espacio = true;
                while (espacio == true)
                {
                    Random numero = new Random();
                    fila = numero.Next(0, 4);
                    columna = numero.Next(0, 4);
                    if (memorizam[fila, columna] == "" || memorizam[fila, columna] == null)
                    {
                        memorizam[fila, columna] = figura5();
                        espacio = false;
                    }
                    else
                    {
                        espacio = true;
                    }
                }
                espacio = true;
                while (espacio == true)
                {
                    Random numero = new Random();
                    fila = numero.Next(0, 4);
                    columna = numero.Next(0, 4);
                    if (memorizam[fila, columna] == "" || memorizam[fila, columna] == null)
                    {
                        memorizam[fila, columna] = figura6();
                        espacio = false;
                    }
                    else
                    {
                        espacio = true;
                    }
                }
                espacio = true;
                while (espacio == true)
                {
                    Random numero = new Random();
                    fila = numero.Next(0, 4);
                    columna = numero.Next(0, 4);
                    if (memorizam[fila, columna] == "" || memorizam[fila, columna] == null)
                    {
                        memorizam[fila, columna] = figura7();
                        espacio = false;
                    }
                    else
                    {
                        espacio = true;
                    }
                }
                espacio = true;
                while (espacio == true)
                {
                    Random numero = new Random();
                    fila = numero.Next(0, 4);
                    columna = numero.Next(0, 4);
                    if (memorizam[fila, columna] == "" || memorizam[fila, columna] == null)
                    {
                        memorizam[fila, columna] = figura8();
                        espacio = false;
                    }
                    else
                    {
                        espacio = true;
                    }
                }
                espacio = true;
            }
            int a = 1;
        }

        public static void llenararray()
        {
            mostrarm[0, 0] = "a";
            mostrarm[0, 1] = "b";
            mostrarm[0, 2] = "c";
            mostrarm[0, 3] = "d";
            mostrarm[1, 0] = "e";
            mostrarm[1, 1] = "f";
            mostrarm[1, 2] = "g";
            mostrarm[1, 3] = "h";
            mostrarm[2, 0] = "i";
            mostrarm[2, 1] = "j";
            mostrarm[2, 2] = "k";
            mostrarm[2, 3] = "l";
            mostrarm[3, 0] = "m";
            mostrarm[3, 1] = "n";
            mostrarm[3, 2] = "o";
            mostrarm[3, 3] = "p";
        }

        public static void vaciararrayfiguras()
        {
            memorizam[0, 0] = "";
            memorizam[0, 1] = "";
            memorizam[0, 2] = "";
            memorizam[0, 3] = "";
            memorizam[1, 0] = "";
            memorizam[1, 1] = "";
            memorizam[1, 2] = "";
            memorizam[1, 3] = "";
            memorizam[2, 0] = "";
            memorizam[2, 1] = "";
            memorizam[2, 2] = "";
            memorizam[2, 3] = "";
            memorizam[3, 0] = "";
            memorizam[3, 1] = "";
            memorizam[3, 2] = "";
            memorizam[3, 3] = "";
        }

        public static void mostrararrayfiguras()
        {
            Console.WriteLine("|¯¯¯|¯¯¯|¯¯¯|¯¯¯|");
            Console.WriteLine("| " + memorizam[0, 0] + " | " + memorizam[0, 1] + " | " + memorizam[0, 2] + " | " + memorizam[0, 3] + " |");
            Console.WriteLine("|---|---|---|---|");
            Console.WriteLine("| " + memorizam[1, 0] + " | " + memorizam[1, 1] + " | " + memorizam[1, 2] + " | " + memorizam[1, 3] + " |");
            Console.WriteLine("|---|---|---|---|");
            Console.WriteLine("| " + memorizam[2, 0] + " | " + memorizam[2, 1] + " | " + memorizam[2, 2] + " | " + memorizam[2, 3] + " |");
            Console.WriteLine("|---|---|---|---|");
            Console.WriteLine("| " + memorizam[3, 0] + " | " + memorizam[3, 1] + " | " + memorizam[3, 2] + " | " + memorizam[3, 3] + " |");
            Console.WriteLine("|___|___|___|___|");
        }

        public static void mostrararrayletras()
        {
            Console.WriteLine("|¯¯¯|¯¯¯|¯¯¯|¯¯¯|");
            Console.WriteLine("| " + mostrarm[0, 0] + " | " + mostrarm[0, 1] + " | " + mostrarm[0, 2] + " | " + mostrarm[0, 3] + " |");
            Console.WriteLine("|---|---|---|---|");
            Console.WriteLine("| " + mostrarm[1, 0] + " | " + mostrarm[1, 1] + " | " + mostrarm[1, 2] + " | " + mostrarm[1, 3] + " |");
            Console.WriteLine("|---|---|---|---|");
            Console.WriteLine("| " + mostrarm[2, 0] + " | " + mostrarm[2, 1] + " | " + mostrarm[2, 2] + " | " + mostrarm[2, 3] + " |");
            Console.WriteLine("|---|---|---|---|");
            Console.WriteLine("| " + mostrarm[3, 0] + " | " + mostrarm[3, 1] + " | " + mostrarm[3, 2] + " | " + mostrarm[3, 3] + " |");
            Console.WriteLine("|___|___|___|___|");
        }
    }
}
