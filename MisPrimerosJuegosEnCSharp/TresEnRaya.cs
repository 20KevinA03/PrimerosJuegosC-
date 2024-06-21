using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisPrimerosJuegosEnCSharp
{
    class TresEnRaya
    {
        public static void Juego()
        {

            bool continuar = true;
            int puntajeJ1 = 0;
            int puntajeJ2 = 0;
            int puntajeEmpate = 0;

            while (continuar == true)
            {
                int Fila = 0;
                int Columna = 0;
                int turno = 0;
                int turnoJugador = 1;
                string ganador = "";
                bool terminarJuego = false;

                Console.WriteLine("\n1. Player Vs Bot");
                Console.WriteLine("2. Player Vs Player");
                Console.Write("\nSeleccione la opcion que desea jugar: ");
                string opcionJugar = Console.ReadLine();

                Console.Clear();

                string modo1 = "";
                string modo = "";
                if (opcionJugar == "1")
                {
                    bool correSelec = true;
                    while (correSelec == true)
                    {
                        Console.WriteLine("\n1: Facil");
                        Console.WriteLine("2: Normal");
                        Console.WriteLine("3: Medio");
                        Console.WriteLine("4: Dificil");
                        Console.WriteLine("5: Imposible");
                        Console.Write("Seleccione la dificauldad de juego: ");
                        modo = Console.ReadLine();
                        Console.Clear();
                        switch (modo)
                        {
                            case "1":
                                modo1 = "Facil";
                                correSelec = false;
                                break;
                            case "2":
                                modo1 = "Normal";
                                correSelec = false;
                                break;
                            case "3":
                                modo1 = "Medio";
                                correSelec = false;
                                break;
                            case "4":
                                modo1 = "Dificil";
                                correSelec = false;
                                break;
                            case "5":
                                modo1 = "Imposible";
                                correSelec = false;
                                break;
                            default:
                                Console.WriteLine("Numero seleccionado no valido, intente de nuevo");
                                correSelec = true;
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }
                    }
                }

                Maquina.LlenarArray();
                Maquina.LlenarArray();
                while (terminarJuego == false)
                {
                    if (opcionJugar == "1")
                    {
                        Console.WriteLine("\nTRES EN RAYA \nPlayer VS Bot\nModo de juego: " + modo1 + "\n\n");
                        Maquina.MostrarTriqui();

                        Console.WriteLine("\nX = Jugador");
                        Console.WriteLine("O = Bot");

                        Console.Write("Ingrese la letra donde quiere poner la X: ");
                        string campoI = Console.ReadLine();

                        if (campoI == "a" || campoI == "b" || campoI == "c" || campoI == "d" || campoI == "e" || campoI == "f" || campoI == "g" || campoI == "h" || campoI == "i")
                        {
                            (Fila, Columna) = Maquina.VerificaCampo(campoI);
                            if (Fila != 5 && Columna != 5)
                            {
                                Maquina.turnoP(Fila, Columna);
                                turno = turno + 1;
                                if (turno < 5)
                                {
                                    Maquina.turnoM(modo);
                                }
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Este campo ya se ha llenado, intente de nuevo");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un valor valido");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        ganador = Maquina.VerificaGanadorM();
                        if (ganador == "JUGADOR")
                        {
                            Console.Clear();
                            Maquina.MostrarTriqui();
                            Console.WriteLine("\nFELICITACIONES, HAS GANADO");
                            terminarJuego = true;
                        }
                        else if (ganador == "BOT")
                        {
                            Console.Clear();
                            Maquina.MostrarTriqui();
                            Console.WriteLine("\nPERDISTE");
                            terminarJuego = true;
                        }
                        else if (turno == 5)
                        {
                            Console.Clear();
                            Maquina.MostrarTriqui();
                            Console.WriteLine("\nEMPATE");
                            terminarJuego = true;
                        }
                        //jugador vs jugador
                    }
                    else if (opcionJugar == "2")
                    {
                        Console.WriteLine("\nTRES EN RAYA \nPlayer VS Player\n");
                        Maquina.MostrarTriquiP(puntajeJ1, puntajeJ2, puntajeEmpate);

                        Console.WriteLine("\nX = Jugador1");
                        Console.WriteLine("O = Jugador2");

                        //turno jugador1
                        if (turnoJugador == 1)
                        {
                            Console.Write("\nPlayer1: Ingrese la letra donde quiere poner la X: ");
                            string campoI1 = Console.ReadLine();

                            if (campoI1 == "a" || campoI1 == "b" || campoI1 == "c" || campoI1 == "d" || campoI1 == "e" || campoI1 == "f" || campoI1 == "g" || campoI1 == "h" || campoI1 == "i")
                            {
                                (Fila, Columna) = Maquina.VerificaCampo(campoI1);
                                if (Fila != 5 && Columna != 5)
                                {
                                    Maquina.turnoP1(Fila, Columna);
                                    turno = turno + 1;
                                    turnoJugador = 2;
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("Este campo ya se ha llenado, intente de nuevo");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un valor valido");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.Write("\nPlayer2: Ingrese la letra donde quiere poner la O: ");
                            string campoI2 = Console.ReadLine();

                            if (campoI2 == "a" || campoI2 == "b" || campoI2 == "c" || campoI2 == "d" || campoI2 == "e" || campoI2 == "f" || campoI2 == "g" || campoI2 == "h" || campoI2 == "i")
                            {
                                (Fila, Columna) = Maquina.VerificaCampo(campoI2);
                                if (Fila != 5 && Columna != 5)
                                {
                                    Maquina.turnoP2(Fila, Columna);
                                    turnoJugador = 1;
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("Este campo ya se ha llenado, intente de nuevo");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un valor valido");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }

                        ganador = Maquina.VerificaGanadorP();
                        if (ganador == "JUG1")
                        {
                            Console.Clear();
                            Maquina.MostrarTriqui();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nFELICITACIONES, HA GANADO EL JUGADOR1");
                            Console.ForegroundColor = ConsoleColor.White;
                            puntajeJ1 = puntajeJ1 + 1;
                            terminarJuego = true;
                        }
                        else if (ganador == "JUG2")
                        {
                            Console.Clear();
                            Maquina.MostrarTriqui();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nFELICITACIONES, HA GANADO EL JUGADOR2");
                            Console.ForegroundColor = ConsoleColor.White;
                            puntajeJ2 = puntajeJ2 + 1;
                            terminarJuego = true;
                        }
                        else if (turno == 5)
                        {
                            Console.Clear();
                            Maquina.MostrarTriqui();
                            Console.WriteLine("\nEMPATE");
                            puntajeEmpate = puntajeEmpate + 1;
                            terminarJuego = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Elecciones posibles 1 o 2, intente de nuevo");
                        terminarJuego = true;
                    }
                }

                Console.Write("\n Desea volver a jugar? si/no: ");
                string cont = Console.ReadLine();

                if (cont == "no" || cont == "NO" || cont == "No")
                {
                    continuar = false;
                }
            }
        }
    }

    class Maquina
    {
        //array juego
        public static string[,] triquiM = new string[3, 3];

        //turno jugador
        public static void turnoP(int fila, int columna)
        {
            triquiM[fila, columna] = "X";
        }

        //turno jugador 1
        public static void turnoP1(int fila, int columna)
        {
            triquiM[fila, columna] = "X";
        }

        //turno jugador2
        public static void turnoP2(int fila, int columna)
        {
            triquiM[fila, columna] = "O";
        }

        //turno maquina
        public static void turnoM(string opcion)
        {

            if (opcion == "1")
            {
                bool espacio = true;
                while (espacio == true)
                {

                    Random numero = new Random();
                    int fila = numero.Next(0, 3);
                    int columna = numero.Next(0, 3);

                    if (triquiM[fila, columna] != "X" && triquiM[fila, columna] != "O")
                    {
                        triquiM[fila, columna] = "O";
                        espacio = false;
                    }
                    else
                    {
                        espacio = true;
                    }
                }
            }
            else if (opcion == "2")
            {
                //PROTEJER
                //1Vertical
                if (triquiM[0, 0] == "X" && triquiM[1, 0] == "X" && triquiM[2, 0] == "g")
                {
                    triquiM[2, 0] = "O";
                }
                else if (triquiM[0, 1] == "X" && triquiM[1, 1] == "X" && triquiM[2, 1] == "h")
                {
                    triquiM[2, 1] = "O";
                }
                else if (triquiM[0, 2] == "X" && triquiM[1, 2] == "X" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 2] = "O";
                }
                //2Vertical
                else if (triquiM[1, 0] == "X" && triquiM[2, 0] == "X" && triquiM[0, 0] == "a")
                {
                    triquiM[0, 0] = "O";
                }
                else if (triquiM[1, 1] == "X" && triquiM[2, 1] == "X" && triquiM[0, 1] == "b")
                {
                    triquiM[0, 1] = "O";
                }
                else if (triquiM[1, 2] == "X" && triquiM[2, 2] == "X" && triquiM[0, 2] == "c")
                {
                    triquiM[0, 2] = "O";
                }
                //1horizontal
                else if (triquiM[0, 0] == "X" && triquiM[0, 1] == "X" && triquiM[0, 2] == "c")
                {
                    triquiM[0, 2] = "O";
                }
                else if (triquiM[1, 0] == "X" && triquiM[1, 1] == "X" && triquiM[1, 2] == "f")
                {
                    triquiM[1, 2] = "O";
                }
                else if (triquiM[2, 0] == "X" && triquiM[2, 1] == "X" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 2] = "O";
                }
                //2horizontal
                else if (triquiM[0, 2] == "X" && triquiM[0, 1] == "X" && triquiM[0, 0] == "a")
                {
                    triquiM[0, 0] = "O";
                }
                else if (triquiM[1, 2] == "X" && triquiM[1, 1] == "X" && triquiM[1, 0] == "d")
                {
                    triquiM[1, 0] = "O";
                }
                else if (triquiM[2, 2] == "X" && triquiM[2, 1] == "X" && triquiM[2, 0] == "g")
                {
                    triquiM[2, 0] = "O";
                }
                //1cruzada
                else if (triquiM[0, 0] == "X" && triquiM[1, 1] == "X" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 2] = "O";
                }
                else if (triquiM[2, 2] == "X" && triquiM[1, 1] == "X" && triquiM[0, 0] == "a")
                {
                    triquiM[0, 0] = "O";
                }
                //2cruzada
                else if (triquiM[2, 0] == "X" && triquiM[1, 1] == "X" && triquiM[0, 2] == "c")
                {
                    triquiM[0, 2] = "O";
                }
                else if (triquiM[0, 2] == "X" && triquiM[1, 1] == "X" && triquiM[2, 0] == "g")
                {
                    triquiM[2, 0] = "O";
                }
                //vertical separadas
                else if (triquiM[0, 0] == "X" && triquiM[2, 0] == "X" && triquiM[1, 0] == "d")
                {
                    triquiM[1, 0] = "O";
                }
                else if (triquiM[0, 1] == "X" && triquiM[2, 1] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[0, 2] == "X" && triquiM[2, 2] == "X" && triquiM[1, 2] == "f")
                {
                    triquiM[1, 2] = "O";
                }
                //Horizontal separadas
                else if (triquiM[0, 0] == "X" && triquiM[0, 2] == "X" && triquiM[0, 1] == "b")
                {
                    triquiM[0, 1] = "O";
                }
                else if (triquiM[1, 0] == "X" && triquiM[1, 2] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[2, 0] == "X" && triquiM[2, 2] == "X" && triquiM[2, 1] == "h")
                {
                    triquiM[2, 1] = "O";
                }
                //cruzadas separadas
                else if (triquiM[0, 0] == "X" && triquiM[2, 2] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[2, 0] == "X" && triquiM[0, 2] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else
                {
                    bool espacio = true;
                    while (espacio == true)
                    {
                        Random numero = new Random();
                        int fila = numero.Next(0, 3);
                        int columna = numero.Next(0, 3);

                        if (triquiM[fila, columna] != "X" && triquiM[fila, columna] != "O")
                        {
                            triquiM[fila, columna] = "O";
                            espacio = false;
                        }
                        else
                        {
                            espacio = true;
                        }
                    }
                }
            }
            else if (opcion == "3")
            {
                //inicio
                if (triquiM[0, 0] == "X" && triquiM[0, 1] == "b" && triquiM[0, 2] == "c" && triquiM[1, 0] == "d" && triquiM[1, 1] == "e" && triquiM[1, 2] == "f" && triquiM[2, 0] == "g" && triquiM[2, 1] == "h" && triquiM[2, 2] == "i")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "X" && triquiM[0, 2] == "c" && triquiM[1, 0] == "d" && triquiM[1, 1] == "e" && triquiM[1, 2] == "f" && triquiM[2, 0] == "g" && triquiM[2, 1] == "h" && triquiM[2, 2] == "i")
                {
                    triquiM[0, 0] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "b" && triquiM[0, 2] == "X" && triquiM[1, 0] == "d" && triquiM[1, 1] == "e" && triquiM[1, 2] == "f" && triquiM[2, 0] == "g" && triquiM[2, 1] == "h" && triquiM[2, 2] == "i")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "b" && triquiM[0, 2] == "c" && triquiM[1, 0] == "X" && triquiM[1, 1] == "e" && triquiM[1, 2] == "f" && triquiM[2, 0] == "g" && triquiM[2, 1] == "h" && triquiM[2, 2] == "i")
                {
                    triquiM[0, 0] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "b" && triquiM[0, 2] == "c" && triquiM[1, 0] == "d" && triquiM[1, 1] == "X" && triquiM[1, 2] == "f" && triquiM[2, 0] == "g" && triquiM[2, 1] == "h" && triquiM[2, 2] == "i")
                {
                    triquiM[0, 2] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "b" && triquiM[0, 2] == "c" && triquiM[1, 0] == "d" && triquiM[1, 1] == "e" && triquiM[1, 2] == "X" && triquiM[2, 0] == "g" && triquiM[2, 1] == "h" && triquiM[2, 2] == "i")
                {
                    triquiM[0, 2] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "b" && triquiM[0, 2] == "c" && triquiM[1, 0] == "d" && triquiM[1, 1] == "e" && triquiM[1, 2] == "f" && triquiM[2, 0] == "X" && triquiM[2, 1] == "h" && triquiM[2, 2] == "i")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "b" && triquiM[0, 2] == "c" && triquiM[1, 0] == "d" && triquiM[1, 1] == "e" && triquiM[1, 2] == "f" && triquiM[2, 0] == "g" && triquiM[2, 1] == "X" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 0] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "b" && triquiM[0, 2] == "c" && triquiM[1, 0] == "d" && triquiM[1, 1] == "e" && triquiM[1, 2] == "f" && triquiM[2, 0] == "g" && triquiM[2, 1] == "h" && triquiM[2, 2] == "X")
                {
                    triquiM[1, 1] = "O";
                }
                //Atacar
                //1vertical
                else if (triquiM[0, 0] == "O" && triquiM[1, 0] == "O" && triquiM[2, 0] == "g")
                {
                    triquiM[2, 0] = "O";
                }
                else if (triquiM[0, 1] == "O" && triquiM[1, 1] == "O" && triquiM[2, 1] == "h")
                {
                    triquiM[2, 1] = "O";
                }
                else if (triquiM[0, 2] == "O" && triquiM[1, 2] == "O" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 2] = "O";
                }
                //2Vertical
                else if (triquiM[1, 0] == "O" && triquiM[2, 0] == "O" && triquiM[0, 0] == "a")
                {
                    triquiM[0, 0] = "O";
                }
                else if (triquiM[1, 1] == "O" && triquiM[2, 1] == "O" && triquiM[0, 1] == "b")
                {
                    triquiM[0, 1] = "O";
                }
                else if (triquiM[1, 2] == "O" && triquiM[2, 2] == "O" && triquiM[0, 2] == "c")
                {
                    triquiM[0, 2] = "O";
                }
                //1horizontal
                else if (triquiM[0, 0] == "O" && triquiM[0, 1] == "O" && triquiM[0, 2] == "c")
                {
                    triquiM[0, 2] = "O";
                }
                else if (triquiM[1, 0] == "O" && triquiM[1, 1] == "O" && triquiM[1, 2] == "f")
                {
                    triquiM[1, 2] = "O";
                }
                else if (triquiM[2, 0] == "O" && triquiM[2, 1] == "O" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 2] = "O";
                }
                //2horizontal
                else if (triquiM[0, 2] == "O" && triquiM[0, 1] == "O" && triquiM[0, 0] == "a")
                {
                    triquiM[0, 0] = "O";
                }
                else if (triquiM[1, 2] == "O" && triquiM[1, 1] == "O" && triquiM[1, 0] == "d")
                {
                    triquiM[1, 0] = "O";
                }
                else if (triquiM[2, 2] == "O" && triquiM[2, 1] == "O" && triquiM[2, 0] == "g")
                {
                    triquiM[2, 0] = "O";
                }
                //1cruzada
                else if (triquiM[0, 0] == "O" && triquiM[1, 1] == "O" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 2] = "O";
                }
                else if (triquiM[2, 2] == "O" && triquiM[1, 1] == "O" && triquiM[0, 0] == "a")
                {
                    triquiM[0, 0] = "O";
                }
                //2cruzada
                else if (triquiM[2, 0] == "O" && triquiM[1, 1] == "O" && triquiM[0, 2] == "c")
                {
                    triquiM[0, 2] = "O";
                }
                else if (triquiM[0, 2] == "O" && triquiM[1, 1] == "O" && triquiM[2, 0] == "g")
                {
                    triquiM[2, 0] = "O";
                }
                //vertical separadas
                else if (triquiM[0, 0] == "O" && triquiM[2, 0] == "O" && triquiM[1, 0] == "d")
                {
                    triquiM[1, 0] = "O";
                }
                else if (triquiM[0, 1] == "O" && triquiM[2, 1] == "O" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[0, 2] == "O" && triquiM[2, 2] == "O" && triquiM[1, 2] == "f")
                {
                    triquiM[1, 2] = "O";
                }
                //Horizontal separadas
                else if (triquiM[0, 0] == "O" && triquiM[0, 2] == "O" && triquiM[0, 1] == "b")
                {
                    triquiM[0, 1] = "O";
                }
                else if (triquiM[1, 0] == "O" && triquiM[1, 2] == "O" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[2, 0] == "O" && triquiM[2, 2] == "O" && triquiM[2, 1] == "h")
                {
                    triquiM[2, 1] = "O";
                }
                //cruzadas separadas
                else if (triquiM[0, 0] == "O" && triquiM[2, 2] == "O" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[2, 0] == "O" && triquiM[0, 2] == "O" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                //PROTEJER
                //1Vertical
                else if (triquiM[0, 0] == "X" && triquiM[1, 0] == "X" && triquiM[2, 0] == "g")
                {
                    triquiM[2, 0] = "O";
                }
                else if (triquiM[0, 1] == "X" && triquiM[1, 1] == "X" && triquiM[2, 1] == "h")
                {
                    triquiM[2, 1] = "O";
                }
                else if (triquiM[0, 2] == "X" && triquiM[1, 2] == "X" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 2] = "O";
                }
                //2Vertical
                else if (triquiM[1, 0] == "X" && triquiM[2, 0] == "X" && triquiM[0, 0] == "a")
                {
                    triquiM[0, 0] = "O";
                }
                else if (triquiM[1, 1] == "X" && triquiM[2, 1] == "X" && triquiM[0, 1] == "b")
                {
                    triquiM[0, 1] = "O";
                }
                else if (triquiM[1, 2] == "X" && triquiM[2, 2] == "X" && triquiM[0, 2] == "c")
                {
                    triquiM[0, 2] = "O";
                }
                //1horizontal
                else if (triquiM[0, 0] == "X" && triquiM[0, 1] == "X" && triquiM[0, 2] == "c")
                {
                    triquiM[0, 2] = "O";
                }
                else if (triquiM[1, 0] == "X" && triquiM[1, 1] == "X" && triquiM[1, 2] == "f")
                {
                    triquiM[1, 2] = "O";
                }
                else if (triquiM[2, 0] == "X" && triquiM[2, 1] == "X" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 2] = "O";
                }
                //2horizontal
                else if (triquiM[0, 2] == "X" && triquiM[0, 1] == "X" && triquiM[0, 0] == "a")
                {
                    triquiM[0, 0] = "O";
                }
                else if (triquiM[1, 2] == "X" && triquiM[1, 1] == "X" && triquiM[1, 0] == "d")
                {
                    triquiM[1, 0] = "O";
                }
                else if (triquiM[2, 2] == "X" && triquiM[2, 1] == "X" && triquiM[2, 0] == "g")
                {
                    triquiM[2, 0] = "O";
                }
                //1cruzada
                else if (triquiM[0, 0] == "X" && triquiM[1, 1] == "X" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 2] = "O";
                }
                else if (triquiM[2, 2] == "X" && triquiM[1, 1] == "X" && triquiM[0, 0] == "a")
                {
                    triquiM[0, 0] = "O";
                }
                //2cruzada
                else if (triquiM[2, 0] == "X" && triquiM[1, 1] == "X" && triquiM[0, 2] == "c")
                {
                    triquiM[0, 2] = "O";
                }
                else if (triquiM[0, 2] == "X" && triquiM[1, 1] == "X" && triquiM[2, 0] == "g")
                {
                    triquiM[2, 0] = "O";
                }
                //vertical separadas
                else if (triquiM[0, 0] == "X" && triquiM[2, 0] == "X" && triquiM[1, 0] == "d")
                {
                    triquiM[1, 0] = "O";
                }
                else if (triquiM[0, 1] == "X" && triquiM[2, 1] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[0, 2] == "X" && triquiM[2, 2] == "X" && triquiM[1, 2] == "f")
                {
                    triquiM[1, 2] = "O";
                }
                //Horizontal separadas
                else if (triquiM[0, 0] == "X" && triquiM[0, 2] == "X" && triquiM[0, 1] == "b")
                {
                    triquiM[0, 1] = "O";
                }
                else if (triquiM[1, 0] == "X" && triquiM[1, 2] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[2, 0] == "X" && triquiM[2, 2] == "X" && triquiM[2, 1] == "h")
                {
                    triquiM[2, 1] = "O";
                }
                //cruzadas separadas
                else if (triquiM[0, 0] == "X" && triquiM[2, 2] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[2, 0] == "X" && triquiM[0, 2] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else
                {
                    bool espacio = true;
                    while (espacio == true)
                    {
                        Random numero = new Random();
                        int fila = numero.Next(0, 3);
                        int columna = numero.Next(0, 3);

                        if (triquiM[fila, columna] != "X" && triquiM[fila, columna] != "O")
                        {
                            triquiM[fila, columna] = "O";
                            espacio = false;
                        }
                        else
                        {
                            espacio = true;
                        }
                    }
                }
            }
            else if (opcion == "4")
            {
                //Atacar
                //1vertical
                if (triquiM[0, 0] == "O" && triquiM[1, 0] == "O" && triquiM[2, 0] == "g")
                {
                    triquiM[2, 0] = "O";
                }
                else if (triquiM[0, 1] == "O" && triquiM[1, 1] == "O" && triquiM[2, 1] == "h")
                {
                    triquiM[2, 1] = "O";
                }
                else if (triquiM[0, 2] == "O" && triquiM[1, 2] == "O" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 2] = "O";
                }
                //2Vertical
                else if (triquiM[1, 0] == "O" && triquiM[2, 0] == "O" && triquiM[0, 0] == "a")
                {
                    triquiM[0, 0] = "O";
                }
                else if (triquiM[1, 1] == "O" && triquiM[2, 1] == "O" && triquiM[0, 1] == "b")
                {
                    triquiM[0, 1] = "O";
                }
                else if (triquiM[1, 2] == "O" && triquiM[2, 2] == "O" && triquiM[0, 2] == "c")
                {
                    triquiM[0, 2] = "O";
                }
                //1horizontal
                else if (triquiM[0, 0] == "O" && triquiM[0, 1] == "O" && triquiM[0, 2] == "c")
                {
                    triquiM[0, 2] = "O";
                }
                else if (triquiM[1, 0] == "O" && triquiM[1, 1] == "O" && triquiM[1, 2] == "f")
                {
                    triquiM[1, 2] = "O";
                }
                else if (triquiM[2, 0] == "O" && triquiM[2, 1] == "O" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 2] = "O";
                }
                //2horizontal
                else if (triquiM[0, 2] == "O" && triquiM[0, 1] == "O" && triquiM[0, 0] == "a")
                {
                    triquiM[0, 0] = "O";
                }
                else if (triquiM[1, 2] == "O" && triquiM[1, 1] == "O" && triquiM[1, 0] == "d")
                {
                    triquiM[1, 0] = "O";
                }
                else if (triquiM[2, 2] == "O" && triquiM[2, 1] == "O" && triquiM[2, 0] == "g")
                {
                    triquiM[2, 0] = "O";
                }
                //1cruzada
                else if (triquiM[0, 0] == "O" && triquiM[1, 1] == "O" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 2] = "O";
                }
                else if (triquiM[2, 2] == "O" && triquiM[1, 1] == "O" && triquiM[0, 0] == "a")
                {
                    triquiM[0, 0] = "O";
                }
                //2cruzada
                else if (triquiM[2, 0] == "O" && triquiM[1, 1] == "O" && triquiM[0, 2] == "c")
                {
                    triquiM[0, 2] = "O";
                }
                else if (triquiM[0, 2] == "O" && triquiM[1, 1] == "O" && triquiM[2, 0] == "g")
                {
                    triquiM[2, 0] = "O";
                }
                //vertical separadas
                else if (triquiM[0, 0] == "O" && triquiM[2, 0] == "O" && triquiM[1, 0] == "d")
                {
                    triquiM[1, 0] = "O";
                }
                else if (triquiM[0, 1] == "O" && triquiM[2, 1] == "O" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[0, 2] == "O" && triquiM[2, 2] == "O" && triquiM[1, 2] == "f")
                {
                    triquiM[1, 2] = "O";
                }
                //Horizontal separadas
                else if (triquiM[0, 0] == "O" && triquiM[0, 2] == "O" && triquiM[0, 1] == "b")
                {
                    triquiM[0, 1] = "O";
                }
                else if (triquiM[1, 0] == "O" && triquiM[1, 2] == "O" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[2, 0] == "O" && triquiM[2, 2] == "O" && triquiM[2, 1] == "h")
                {
                    triquiM[2, 1] = "O";
                }
                //cruzadas separadas
                else if (triquiM[0, 0] == "O" && triquiM[2, 2] == "O" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[2, 0] == "O" && triquiM[0, 2] == "O" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                //inicio
                else if (triquiM[0, 0] == "X" && triquiM[0, 1] == "b" && triquiM[0, 2] == "c" && triquiM[1, 0] == "d" && triquiM[1, 1] == "e" && triquiM[1, 2] == "f" && triquiM[2, 0] == "g" && triquiM[2, 1] == "h" && triquiM[2, 2] == "i")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "X" && triquiM[0, 2] == "c" && triquiM[1, 0] == "d" && triquiM[1, 1] == "e" && triquiM[1, 2] == "f" && triquiM[2, 0] == "g" && triquiM[2, 1] == "h" && triquiM[2, 2] == "i")
                {
                    triquiM[0, 0] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "b" && triquiM[0, 2] == "X" && triquiM[1, 0] == "d" && triquiM[1, 1] == "e" && triquiM[1, 2] == "f" && triquiM[2, 0] == "g" && triquiM[2, 1] == "h" && triquiM[2, 2] == "i")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "b" && triquiM[0, 2] == "c" && triquiM[1, 0] == "X" && triquiM[1, 1] == "e" && triquiM[1, 2] == "f" && triquiM[2, 0] == "g" && triquiM[2, 1] == "h" && triquiM[2, 2] == "i")
                {
                    triquiM[0, 0] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "b" && triquiM[0, 2] == "c" && triquiM[1, 0] == "d" && triquiM[1, 1] == "X" && triquiM[1, 2] == "f" && triquiM[2, 0] == "g" && triquiM[2, 1] == "h" && triquiM[2, 2] == "i")
                {
                    triquiM[0, 2] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "b" && triquiM[0, 2] == "c" && triquiM[1, 0] == "d" && triquiM[1, 1] == "e" && triquiM[1, 2] == "X" && triquiM[2, 0] == "g" && triquiM[2, 1] == "h" && triquiM[2, 2] == "i")
                {
                    triquiM[0, 2] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "b" && triquiM[0, 2] == "c" && triquiM[1, 0] == "d" && triquiM[1, 1] == "e" && triquiM[1, 2] == "f" && triquiM[2, 0] == "X" && triquiM[2, 1] == "h" && triquiM[2, 2] == "i")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "b" && triquiM[0, 2] == "c" && triquiM[1, 0] == "d" && triquiM[1, 1] == "e" && triquiM[1, 2] == "f" && triquiM[2, 0] == "g" && triquiM[2, 1] == "X" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 0] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "b" && triquiM[0, 2] == "c" && triquiM[1, 0] == "d" && triquiM[1, 1] == "e" && triquiM[1, 2] == "f" && triquiM[2, 0] == "g" && triquiM[2, 1] == "h" && triquiM[2, 2] == "X")
                {
                    triquiM[1, 1] = "O";
                }
                //segundo inicio
                //Combo 1
                else if (triquiM[0, 0] == "X" && triquiM[2, 2] == "X" && triquiM[0, 1] == "b")
                {
                    triquiM[0, 1] = "O";
                }
                else if (triquiM[0, 2] == "X" && triquiM[2, 0] == "X" && triquiM[0, 1] == "b")
                {
                    triquiM[0, 1] = "O";
                }
                //Combo 2
                else if (triquiM[0, 1] == "X" && triquiM[1, 2] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[0, 1] == "X" && triquiM[1, 0] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[2, 1] == "X" && triquiM[1, 0] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[2, 1] == "X" && triquiM[1, 2] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                //PROTEJER
                //1Vertical
                else if (triquiM[0, 0] == "X" && triquiM[1, 0] == "X" && triquiM[2, 0] == "g")
                {
                    triquiM[2, 0] = "O";
                }
                else if (triquiM[0, 1] == "X" && triquiM[1, 1] == "X" && triquiM[2, 1] == "h")
                {
                    triquiM[2, 1] = "O";
                }
                else if (triquiM[0, 2] == "X" && triquiM[1, 2] == "X" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 2] = "O";
                }
                //2Vertical
                else if (triquiM[1, 0] == "X" && triquiM[2, 0] == "X" && triquiM[0, 0] == "a")
                {
                    triquiM[0, 0] = "O";
                }
                else if (triquiM[1, 1] == "X" && triquiM[2, 1] == "X" && triquiM[0, 1] == "b")
                {
                    triquiM[0, 1] = "O";
                }
                else if (triquiM[1, 2] == "X" && triquiM[2, 2] == "X" && triquiM[0, 2] == "c")
                {
                    triquiM[0, 2] = "O";
                }
                //1horizontal
                else if (triquiM[0, 0] == "X" && triquiM[0, 1] == "X" && triquiM[0, 2] == "c")
                {
                    triquiM[0, 2] = "O";
                }
                else if (triquiM[1, 0] == "X" && triquiM[1, 1] == "X" && triquiM[1, 2] == "f")
                {
                    triquiM[1, 2] = "O";
                }
                else if (triquiM[2, 0] == "X" && triquiM[2, 1] == "X" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 2] = "O";
                }
                //2horizontal
                else if (triquiM[0, 2] == "X" && triquiM[0, 1] == "X" && triquiM[0, 0] == "a")
                {
                    triquiM[0, 0] = "O";
                }
                else if (triquiM[1, 2] == "X" && triquiM[1, 1] == "X" && triquiM[1, 0] == "d")
                {
                    triquiM[1, 0] = "O";
                }
                else if (triquiM[2, 2] == "X" && triquiM[2, 1] == "X" && triquiM[2, 0] == "g")
                {
                    triquiM[2, 0] = "O";
                }
                //1cruzada
                else if (triquiM[0, 0] == "X" && triquiM[1, 1] == "X" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 2] = "O";
                }
                else if (triquiM[2, 2] == "X" && triquiM[1, 1] == "X" && triquiM[0, 0] == "a")
                {
                    triquiM[0, 0] = "O";
                }
                //2cruzada
                else if (triquiM[2, 0] == "X" && triquiM[1, 1] == "X" && triquiM[0, 2] == "c")
                {
                    triquiM[0, 2] = "O";
                }
                else if (triquiM[0, 2] == "X" && triquiM[1, 1] == "X" && triquiM[2, 0] == "g")
                {
                    triquiM[2, 0] = "O";
                }
                //vertical separadas
                else if (triquiM[0, 0] == "X" && triquiM[2, 0] == "X" && triquiM[1, 0] == "d")
                {
                    triquiM[1, 0] = "O";
                }
                else if (triquiM[0, 1] == "X" && triquiM[2, 1] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[0, 2] == "X" && triquiM[2, 2] == "X" && triquiM[1, 2] == "f")
                {
                    triquiM[1, 2] = "O";
                }
                //Horizontal separadas
                else if (triquiM[0, 0] == "X" && triquiM[0, 2] == "X" && triquiM[0, 1] == "b")
                {
                    triquiM[0, 1] = "O";
                }
                else if (triquiM[1, 0] == "X" && triquiM[1, 2] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[2, 0] == "X" && triquiM[2, 2] == "X" && triquiM[2, 1] == "h")
                {
                    triquiM[2, 1] = "O";
                }
                //cruzadas separadas
                else if (triquiM[0, 0] == "X" && triquiM[2, 2] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[2, 0] == "X" && triquiM[0, 2] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else
                {
                    bool espacio = true;
                    while (espacio == true)
                    {
                        Random numero = new Random();
                        int fila = numero.Next(0, 3);
                        int columna = numero.Next(0, 3);

                        if (triquiM[fila, columna] != "X" && triquiM[fila, columna] != "O")
                        {
                            triquiM[fila, columna] = "O";
                            espacio = false;
                        }
                        else
                        {
                            espacio = true;
                        }
                    }
                }
            }
            else if (opcion == "5")
            {
                //Atacar
                //1vertical
                if (triquiM[0, 0] == "O" && triquiM[1, 0] == "O" && triquiM[2, 0] == "g")
                {
                    triquiM[2, 0] = "O";
                }
                else if (triquiM[0, 1] == "O" && triquiM[1, 1] == "O" && triquiM[2, 1] == "h")
                {
                    triquiM[2, 1] = "O";
                }
                else if (triquiM[0, 2] == "O" && triquiM[1, 2] == "O" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 2] = "O";
                }
                //2Vertical
                else if (triquiM[1, 0] == "O" && triquiM[2, 0] == "O" && triquiM[0, 0] == "a")
                {
                    triquiM[0, 0] = "O";
                }
                else if (triquiM[1, 1] == "O" && triquiM[2, 1] == "O" && triquiM[0, 1] == "b")
                {
                    triquiM[0, 1] = "O";
                }
                else if (triquiM[1, 2] == "O" && triquiM[2, 2] == "O" && triquiM[0, 2] == "c")
                {
                    triquiM[0, 2] = "O";
                }
                //1horizontal
                else if (triquiM[0, 0] == "O" && triquiM[0, 1] == "O" && triquiM[0, 2] == "c")
                {
                    triquiM[0, 2] = "O";
                }
                else if (triquiM[1, 0] == "O" && triquiM[1, 1] == "O" && triquiM[1, 2] == "f")
                {
                    triquiM[1, 2] = "O";
                }
                else if (triquiM[2, 0] == "O" && triquiM[2, 1] == "O" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 2] = "O";
                }
                //2horizontal
                else if (triquiM[0, 2] == "O" && triquiM[0, 1] == "O" && triquiM[0, 0] == "a")
                {
                    triquiM[0, 0] = "O";
                }
                else if (triquiM[1, 2] == "O" && triquiM[1, 1] == "O" && triquiM[1, 0] == "d")
                {
                    triquiM[1, 0] = "O";
                }
                else if (triquiM[2, 2] == "O" && triquiM[2, 1] == "O" && triquiM[2, 0] == "g")
                {
                    triquiM[2, 0] = "O";
                }
                //1cruzada
                else if (triquiM[0, 0] == "O" && triquiM[1, 1] == "O" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 2] = "O";
                }
                else if (triquiM[2, 2] == "O" && triquiM[1, 1] == "O" && triquiM[0, 0] == "a")
                {
                    triquiM[0, 0] = "O";
                }
                //2cruzada
                else if (triquiM[2, 0] == "O" && triquiM[1, 1] == "O" && triquiM[0, 2] == "c")
                {
                    triquiM[0, 2] = "O";
                }
                else if (triquiM[0, 2] == "O" && triquiM[1, 1] == "O" && triquiM[2, 0] == "g")
                {
                    triquiM[2, 0] = "O";
                }
                //vertical separadas
                else if (triquiM[0, 0] == "O" && triquiM[2, 0] == "O" && triquiM[1, 0] == "d")
                {
                    triquiM[1, 0] = "O";
                }
                else if (triquiM[0, 1] == "O" && triquiM[2, 1] == "O" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[0, 2] == "O" && triquiM[2, 2] == "O" && triquiM[1, 2] == "f")
                {
                    triquiM[1, 2] = "O";
                }
                //Horizontal separadas
                else if (triquiM[0, 0] == "O" && triquiM[0, 2] == "O" && triquiM[0, 1] == "b")
                {
                    triquiM[0, 1] = "O";
                }
                else if (triquiM[1, 0] == "O" && triquiM[1, 2] == "O" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[2, 0] == "O" && triquiM[2, 2] == "O" && triquiM[2, 1] == "h")
                {
                    triquiM[2, 1] = "O";
                }
                //cruzadas separadas
                else if (triquiM[0, 0] == "O" && triquiM[2, 2] == "O" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[2, 0] == "O" && triquiM[0, 2] == "O" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                //inicio
                else if (triquiM[0, 0] == "X" && triquiM[0, 1] == "b" && triquiM[0, 2] == "c" && triquiM[1, 0] == "d" && triquiM[1, 1] == "e" && triquiM[1, 2] == "f" && triquiM[2, 0] == "g" && triquiM[2, 1] == "h" && triquiM[2, 2] == "i")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "X" && triquiM[0, 2] == "c" && triquiM[1, 0] == "d" && triquiM[1, 1] == "e" && triquiM[1, 2] == "f" && triquiM[2, 0] == "g" && triquiM[2, 1] == "h" && triquiM[2, 2] == "i")
                {
                    triquiM[0, 0] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "b" && triquiM[0, 2] == "X" && triquiM[1, 0] == "d" && triquiM[1, 1] == "e" && triquiM[1, 2] == "f" && triquiM[2, 0] == "g" && triquiM[2, 1] == "h" && triquiM[2, 2] == "i")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "b" && triquiM[0, 2] == "c" && triquiM[1, 0] == "X" && triquiM[1, 1] == "e" && triquiM[1, 2] == "f" && triquiM[2, 0] == "g" && triquiM[2, 1] == "h" && triquiM[2, 2] == "i")
                {
                    triquiM[0, 0] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "b" && triquiM[0, 2] == "c" && triquiM[1, 0] == "d" && triquiM[1, 1] == "X" && triquiM[1, 2] == "f" && triquiM[2, 0] == "g" && triquiM[2, 1] == "h" && triquiM[2, 2] == "i")
                {
                    triquiM[0, 2] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "b" && triquiM[0, 2] == "c" && triquiM[1, 0] == "d" && triquiM[1, 1] == "e" && triquiM[1, 2] == "X" && triquiM[2, 0] == "g" && triquiM[2, 1] == "h" && triquiM[2, 2] == "i")
                {
                    triquiM[0, 2] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "b" && triquiM[0, 2] == "c" && triquiM[1, 0] == "d" && triquiM[1, 1] == "e" && triquiM[1, 2] == "f" && triquiM[2, 0] == "X" && triquiM[2, 1] == "h" && triquiM[2, 2] == "i")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "b" && triquiM[0, 2] == "c" && triquiM[1, 0] == "d" && triquiM[1, 1] == "e" && triquiM[1, 2] == "f" && triquiM[2, 0] == "g" && triquiM[2, 1] == "X" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 0] = "O";
                }
                else if (triquiM[0, 0] == "a" && triquiM[0, 1] == "b" && triquiM[0, 2] == "c" && triquiM[1, 0] == "d" && triquiM[1, 1] == "e" && triquiM[1, 2] == "f" && triquiM[2, 0] == "g" && triquiM[2, 1] == "h" && triquiM[2, 2] == "X")
                {
                    triquiM[1, 1] = "O";
                }
                //segundo inicio
                //Combo 1
                else if (triquiM[0, 0] == "X" && triquiM[2, 2] == "X" && triquiM[0, 1] == "b")
                {
                    triquiM[0, 1] = "O";
                }
                else if (triquiM[0, 2] == "X" && triquiM[2, 0] == "X" && triquiM[0, 1] == "b")
                {
                    triquiM[0, 1] = "O";
                }
                //Combo 2
                else if (triquiM[0, 1] == "X" && triquiM[1, 2] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[0, 1] == "X" && triquiM[1, 0] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[2, 1] == "X" && triquiM[1, 0] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[2, 1] == "X" && triquiM[1, 2] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                //Combo3
                else if (triquiM[0, 1] == "X" && triquiM[2, 0] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[2, 1] == "X" && triquiM[0, 0] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[1, 2] == "X" && triquiM[2, 0] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[1, 0] == "X" && triquiM[0, 2] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                //Combo4
                else if (triquiM[0, 1] == "X" && triquiM[1, 1] == "X" && triquiM[2, 0] == "X" && triquiM[0, 2] == "O" && triquiM[1, 0] == "d")
                {
                    triquiM[1, 0] = "O";
                }

                //Combo5
                else if (triquiM[1, 1] == "X" && triquiM[2, 0] == "X" && triquiM[2, 2] == "i" && triquiM[0, 2] == "O")
                {
                    triquiM[2, 2] = "O";
                }
                //combo6
                else if (triquiM[0, 1] == "X" && triquiM[0, 2] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[1, 0] == "X" && triquiM[2, 0] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[2, 1] == "X" && triquiM[2, 2] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[1, 2] == "X" && triquiM[2, 2] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                //PROTEJER
                //1Vertical
                else if (triquiM[0, 0] == "X" && triquiM[1, 0] == "X" && triquiM[2, 0] == "g")
                {
                    triquiM[2, 0] = "O";
                }
                else if (triquiM[0, 1] == "X" && triquiM[1, 1] == "X" && triquiM[2, 1] == "h")
                {
                    triquiM[2, 1] = "O";
                }
                else if (triquiM[0, 2] == "X" && triquiM[1, 2] == "X" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 2] = "O";
                }
                //2Vertical
                else if (triquiM[1, 0] == "X" && triquiM[2, 0] == "X" && triquiM[0, 0] == "a")
                {
                    triquiM[0, 0] = "O";
                }
                else if (triquiM[1, 1] == "X" && triquiM[2, 1] == "X" && triquiM[0, 1] == "b")
                {
                    triquiM[0, 1] = "O";
                }
                else if (triquiM[1, 2] == "X" && triquiM[2, 2] == "X" && triquiM[0, 2] == "c")
                {
                    triquiM[0, 2] = "O";
                }
                //1horizontal
                else if (triquiM[0, 0] == "X" && triquiM[0, 1] == "X" && triquiM[0, 2] == "c")
                {
                    triquiM[0, 2] = "O";
                }
                else if (triquiM[1, 0] == "X" && triquiM[1, 1] == "X" && triquiM[1, 2] == "f")
                {
                    triquiM[1, 2] = "O";
                }
                else if (triquiM[2, 0] == "X" && triquiM[2, 1] == "X" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 2] = "O";
                }
                //2horizontal
                else if (triquiM[0, 2] == "X" && triquiM[0, 1] == "X" && triquiM[0, 0] == "a")
                {
                    triquiM[0, 0] = "O";
                }
                else if (triquiM[1, 2] == "X" && triquiM[1, 1] == "X" && triquiM[1, 0] == "d")
                {
                    triquiM[1, 0] = "O";
                }
                else if (triquiM[2, 2] == "X" && triquiM[2, 1] == "X" && triquiM[2, 0] == "g")
                {
                    triquiM[2, 0] = "O";
                }
                //1cruzada
                else if (triquiM[0, 0] == "X" && triquiM[1, 1] == "X" && triquiM[2, 2] == "i")
                {
                    triquiM[2, 2] = "O";
                }
                else if (triquiM[2, 2] == "X" && triquiM[1, 1] == "X" && triquiM[0, 0] == "a")
                {
                    triquiM[0, 0] = "O";
                }
                //2cruzada
                else if (triquiM[2, 0] == "X" && triquiM[1, 1] == "X" && triquiM[0, 2] == "c")
                {
                    triquiM[0, 2] = "O";
                }
                else if (triquiM[0, 2] == "X" && triquiM[1, 1] == "X" && triquiM[2, 0] == "g")
                {
                    triquiM[2, 0] = "O";
                }
                //vertical separadas
                else if (triquiM[0, 0] == "X" && triquiM[2, 0] == "X" && triquiM[1, 0] == "d")
                {
                    triquiM[1, 0] = "O";
                }
                else if (triquiM[0, 1] == "X" && triquiM[2, 1] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[0, 2] == "X" && triquiM[2, 2] == "X" && triquiM[1, 2] == "f")
                {
                    triquiM[1, 2] = "O";
                }
                //Horizontal separadas
                else if (triquiM[0, 0] == "X" && triquiM[0, 2] == "X" && triquiM[0, 1] == "b")
                {
                    triquiM[0, 1] = "O";
                }
                else if (triquiM[1, 0] == "X" && triquiM[1, 2] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[2, 0] == "X" && triquiM[2, 2] == "X" && triquiM[2, 1] == "h")
                {
                    triquiM[2, 1] = "O";
                }
                //cruzadas separadas
                else if (triquiM[0, 0] == "X" && triquiM[2, 2] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else if (triquiM[2, 0] == "X" && triquiM[0, 2] == "X" && triquiM[1, 1] == "e")
                {
                    triquiM[1, 1] = "O";
                }
                else
                {
                    bool espacio = true;
                    while (espacio == true)
                    {
                        Random numero = new Random();
                        int fila = numero.Next(0, 3);
                        int columna = numero.Next(0, 3);

                        if (triquiM[fila, columna] != "X" && triquiM[fila, columna] != "O")
                        {
                            triquiM[fila, columna] = "O";
                            espacio = false;
                        }
                        else
                        {
                            espacio = true;
                        }
                    }
                }
            }
        }

        public static (int, int) VerificaCampo(string campo)
        {

            int fila = 0;
            int columna = 0;

            switch (campo)
            {
                case "a":
                    if (triquiM[0, 0] != "X" && triquiM[0, 0] != "O")
                    {
                        fila = 0;
                        columna = 0;
                    }
                    else
                    {
                        fila = 5;
                        columna = 5;
                    }
                    break;
                case "b":
                    if (triquiM[0, 1] != "X" && triquiM[0, 1] != "O")
                    {
                        fila = 0;
                        columna = 1;
                    }
                    else
                    {
                        fila = 5;
                        columna = 5;
                    }
                    break;
                case "c":
                    if (triquiM[0, 2] != "X" && triquiM[0, 2] != "O")
                    {
                        fila = 0;
                        columna = 2;
                    }
                    else
                    {
                        fila = 5;
                        columna = 5;
                    }
                    break;
                case "d":
                    if (triquiM[1, 0] != "X" && triquiM[1, 0] != "O")
                    {
                        fila = 1;
                        columna = 0;
                    }
                    else
                    {
                        fila = 5;
                        columna = 5;
                    }
                    break;
                case "e":
                    if (triquiM[1, 1] != "X" && triquiM[1, 1] != "O")
                    {
                        fila = 1;
                        columna = 1;
                    }
                    else
                    {
                        fila = 5;
                        columna = 5;
                    }
                    break;
                case "f":
                    if (triquiM[1, 2] != "X" && triquiM[1, 2] != "O")
                    {
                        fila = 1;
                        columna = 2;
                    }
                    else
                    {
                        fila = 5;
                        columna = 5;
                    }
                    break;
                case "g":
                    if (triquiM[2, 0] != "X" && triquiM[2, 0] != "O")
                    {
                        fila = 2;
                        columna = 0;
                    }
                    else
                    {
                        fila = 5;
                        columna = 5;
                    }
                    break;
                case "h":
                    if (triquiM[2, 1] != "X" && triquiM[2, 1] != "O")
                    {
                        fila = 2;
                        columna = 1;
                    }
                    else
                    {
                        fila = 5;
                        columna = 5;
                    }
                    break;
                case "i":
                    if (triquiM[2, 2] != "X" && triquiM[2, 2] != "O")
                    {
                        fila = 2;
                        columna = 2;
                    }
                    else
                    {
                        fila = 5;
                        columna = 5;
                    }
                    break;
            }
            return (fila, columna);
        }

        public static string VerificaGanadorM()
        {
            string ganador = "";
            if ((triquiM[0, 0] == "X" && triquiM[0, 1] == "X" && triquiM[0, 2] == "X") ||
               (triquiM[1, 0] == "X" && triquiM[1, 1] == "X" && triquiM[1, 2] == "X") ||
               (triquiM[2, 0] == "X" && triquiM[2, 1] == "X" && triquiM[2, 2] == "X") ||
               (triquiM[0, 0] == "X" && triquiM[1, 0] == "X" && triquiM[2, 0] == "X") ||
               (triquiM[0, 1] == "X" && triquiM[1, 1] == "X" && triquiM[2, 1] == "X") ||
               (triquiM[0, 2] == "X" && triquiM[1, 2] == "X" && triquiM[2, 2] == "X") ||
               (triquiM[0, 0] == "X" && triquiM[1, 1] == "X" && triquiM[2, 2] == "X") ||
               (triquiM[2, 0] == "X" && triquiM[1, 1] == "X" && triquiM[0, 2] == "X"))
            {
                ganador = "JUGADOR";
            }
            else if ((triquiM[0, 0] == "O" && triquiM[0, 1] == "O" && triquiM[0, 2] == "O") ||
              (triquiM[1, 0] == "O" && triquiM[1, 1] == "O" && triquiM[1, 2] == "O") ||
              (triquiM[2, 0] == "O" && triquiM[2, 1] == "O" && triquiM[2, 2] == "O") ||
              (triquiM[0, 0] == "O" && triquiM[1, 0] == "O" && triquiM[2, 0] == "O") ||
              (triquiM[0, 1] == "O" && triquiM[1, 1] == "O" && triquiM[2, 1] == "O") ||
              (triquiM[0, 2] == "O" && triquiM[1, 2] == "O" && triquiM[2, 2] == "O") ||
              (triquiM[0, 0] == "O" && triquiM[1, 1] == "O" && triquiM[2, 2] == "O") ||
              (triquiM[2, 0] == "O" && triquiM[1, 1] == "O" && triquiM[0, 2] == "O"))
            {
                ganador = "BOT";
            }
            return ganador;
        }

        public static string VerificaGanadorP()
        {
            string ganador = "";
            if ((triquiM[0, 0] == "X" && triquiM[0, 1] == "X" && triquiM[0, 2] == "X") ||
               (triquiM[1, 0] == "X" && triquiM[1, 1] == "X" && triquiM[1, 2] == "X") ||
               (triquiM[2, 0] == "X" && triquiM[2, 1] == "X" && triquiM[2, 2] == "X") ||
               (triquiM[0, 0] == "X" && triquiM[1, 0] == "X" && triquiM[2, 0] == "X") ||
               (triquiM[0, 1] == "X" && triquiM[1, 1] == "X" && triquiM[2, 1] == "X") ||
               (triquiM[0, 2] == "X" && triquiM[1, 2] == "X" && triquiM[2, 2] == "X") ||
               (triquiM[0, 0] == "X" && triquiM[1, 1] == "X" && triquiM[2, 2] == "X") ||
               (triquiM[2, 0] == "X" && triquiM[1, 1] == "X" && triquiM[0, 2] == "X"))
            {
                ganador = "JUG1";
            }
            else if ((triquiM[0, 0] == "O" && triquiM[0, 1] == "O" && triquiM[0, 2] == "O") ||
              (triquiM[1, 0] == "O" && triquiM[1, 1] == "O" && triquiM[1, 2] == "O") ||
              (triquiM[2, 0] == "O" && triquiM[2, 1] == "O" && triquiM[2, 2] == "O") ||
              (triquiM[0, 0] == "O" && triquiM[1, 0] == "O" && triquiM[2, 0] == "O") ||
              (triquiM[0, 1] == "O" && triquiM[1, 1] == "O" && triquiM[2, 1] == "O") ||
              (triquiM[0, 2] == "O" && triquiM[1, 2] == "O" && triquiM[2, 2] == "O") ||
              (triquiM[0, 0] == "O" && triquiM[1, 1] == "O" && triquiM[2, 2] == "O") ||
              (triquiM[2, 0] == "O" && triquiM[1, 1] == "O" && triquiM[0, 2] == "O"))
            {
                ganador = "JUG2";
            }
            return ganador;
        }

        //Lena el triqui inicial
        public static void LlenarArray()
        {
            triquiM[0, 0] = "a";
            triquiM[0, 1] = "b";
            triquiM[0, 2] = "c";
            triquiM[1, 0] = "d";
            triquiM[1, 1] = "e";
            triquiM[1, 2] = "f";
            triquiM[2, 0] = "g";
            triquiM[2, 1] = "h";
            triquiM[2, 2] = "i";
        }

        //Muestra el triqui
        public static void MostrarTriqui()
        {

            Console.WriteLine("|¯¯¯|¯¯¯|¯¯¯|");

            //Color primera linea
            Console.Write("| ");
            if (triquiM[0, 0] == "X")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(triquiM[0, 0]);
            }
            else if (triquiM[0, 0] == "O")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(triquiM[0, 0]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(triquiM[0, 0]);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" | ");
            if (triquiM[0, 1] == "X")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(triquiM[0, 1]);
            }
            else if (triquiM[0, 1] == "O")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(triquiM[0, 1]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(triquiM[0, 1]);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" | ");
            if (triquiM[0, 2] == "X")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(triquiM[0, 2]);
            }
            else if (triquiM[0, 2] == "O")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(triquiM[0, 2]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(triquiM[0, 2]);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" |");

            Console.WriteLine("|---|---|---|");
            //Color segunda linea
            Console.Write("| ");
            if (triquiM[1, 0] == "X")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(triquiM[1, 0]);
            }
            else if (triquiM[1, 0] == "O")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(triquiM[1, 0]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(triquiM[1, 0]);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" | ");
            if (triquiM[1, 1] == "X")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(triquiM[1, 1]);
            }
            else if (triquiM[1, 1] == "O")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(triquiM[1, 1]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(triquiM[1, 1]);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" | ");
            if (triquiM[1, 2] == "X")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(triquiM[1, 2]);
            }
            else if (triquiM[1, 2] == "O")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(triquiM[1, 2]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(triquiM[1, 2]);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" |");

            Console.WriteLine("|---|---|---|");
            //Color tercera linea
            Console.Write("| ");
            if (triquiM[2, 0] == "X")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(triquiM[2, 0]);
            }
            else if (triquiM[2, 0] == "O")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(triquiM[2, 0]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(triquiM[2, 0]);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" | ");
            if (triquiM[2, 1] == "X")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(triquiM[2, 1]);
            }
            else if (triquiM[2, 1] == "O")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(triquiM[2, 1]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(triquiM[2, 1]);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" | ");
            if (triquiM[2, 2] == "X")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(triquiM[2, 2]);
            }
            else if (triquiM[2, 2] == "O")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(triquiM[2, 2]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(triquiM[2, 2]);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" |");

            Console.WriteLine("|___|___|___|");
        }

        public static void MostrarTriquiP(int punJ1, int punJ2, int puntajeEmpate)
        {

            Console.WriteLine("|¯¯¯|¯¯¯|¯¯¯|                          SCORE:");

            //Color primera linea
            Console.Write("| ");
            if (triquiM[0, 0] == "X")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(triquiM[0, 0]);
            }
            else if (triquiM[0, 0] == "O")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(triquiM[0, 0]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(triquiM[0, 0]);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" | ");
            if (triquiM[0, 1] == "X")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(triquiM[0, 1]);
            }
            else if (triquiM[0, 1] == "O")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(triquiM[0, 1]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(triquiM[0, 1]);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" | ");
            if (triquiM[0, 2] == "X")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(triquiM[0, 2]);
            }
            else if (triquiM[0, 2] == "O")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(triquiM[0, 2]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(triquiM[0, 2]);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" |                            Jugador 1: " + punJ1);

            Console.WriteLine("|---|---|---|                            Jugador 2: " + punJ2);
            //Color segunda linea
            Console.Write("| ");
            if (triquiM[1, 0] == "X")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(triquiM[1, 0]);
            }
            else if (triquiM[1, 0] == "O")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(triquiM[1, 0]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(triquiM[1, 0]);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" | ");
            if (triquiM[1, 1] == "X")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(triquiM[1, 1]);
            }
            else if (triquiM[1, 1] == "O")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(triquiM[1, 1]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(triquiM[1, 1]);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" | ");
            if (triquiM[1, 2] == "X")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(triquiM[1, 2]);
            }
            else if (triquiM[1, 2] == "O")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(triquiM[1, 2]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(triquiM[1, 2]);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" |                            Empates:" + puntajeEmpate);

            Console.WriteLine("|---|---|---|");
            //Color tercera linea
            Console.Write("| ");
            if (triquiM[2, 0] == "X")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(triquiM[2, 0]);
            }
            else if (triquiM[2, 0] == "O")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(triquiM[2, 0]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(triquiM[2, 0]);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" | ");
            if (triquiM[2, 1] == "X")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(triquiM[2, 1]);
            }
            else if (triquiM[2, 1] == "O")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(triquiM[2, 1]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(triquiM[2, 1]);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" | ");
            if (triquiM[2, 2] == "X")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(triquiM[2, 2]);
            }
            else if (triquiM[2, 2] == "O")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(triquiM[2, 2]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(triquiM[2, 2]);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" |");

            Console.WriteLine("|___|___|___|");
        }
    }
}
