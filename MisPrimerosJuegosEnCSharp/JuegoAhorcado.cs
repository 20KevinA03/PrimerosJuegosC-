using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisPrimerosJuegosEnCSharp
{
    class JuegoAhorcado
    {
        public static void Ahorcado()
        {
            palabras palabra = new palabras();

            bool continuar = true;

            while (continuar == true)
            {

                bool proceso = true;
                int CantDibujo = 1;
                //int cantErrores=0;
                int cantIntentosI = 0;
                int cantIntentosF = 0;
                int cantAcertaciones = 0;
                int NumPalabra = Rnumero();

                switch (NumPalabra)
                {
                    case 1:
                        int CantLetras1 = 9;
                        string[] frase1 = new string[CantLetras1];
                        List<string> ListaMala1 = new List<string>();
                        while (proceso == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("     AHORCADO EL JUEGO     ");
                            Console.WriteLine("**************************\n\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            creacionD(CantDibujo);
                            Console.Write("\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("\nDigite una palabra: ");
                            string LetraI = Console.ReadLine();

                            //Verifica palabras ingresadas
                            for (int i = 0; i < CantLetras1; i++)
                            {
                                int numero = palabra.palabra1(LetraI, i);
                                if (numero != 30)
                                {
                                    frase1[i] = LetraI + " ";
                                    cantAcertaciones = cantAcertaciones + 1;
                                    //Console.WriteLine(CantLetras/*"Felicidades has completado la palabra"*/);
                                    if (cantAcertaciones == CantLetras1)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        creacionD(10);
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("Felicidades has completado la palabra");
                                        proceso = false;
                                    }

                                }
                                else if (frase1[i] == "" || frase1[i] == null)
                                {
                                    frase1[i] = "  ";
                                    cantIntentosI = cantIntentosI + 1;
                                    //Console.WriteLine(cantIntentosI);
                                    if (cantIntentosI >= CantLetras1)
                                    {
                                        //cantErrores=cantErrores+1;
                                        CantDibujo = CantDibujo + 1;
                                        ListaMala1.Add(LetraI + " ");
                                    }
                                }
                                else
                                {
                                    frase1[i] = frase1[i];
                                    cantIntentosF = cantIntentosF + 1;
                                    //Console.WriteLine(cantIntentosF);
                                    if (cantIntentosF >= CantLetras1)
                                    {
                                        //cantErrores=cantErrores+1;
                                        CantDibujo = CantDibujo + 1;
                                        ListaMala1.Add(LetraI + " ");
                                    }
                                }
                            }
                            cantIntentosI = 0;
                            cantIntentosF = 0;

                            if (CantDibujo > 8)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                creacionD(11);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("Perdiste, intentalo de nuevo");
                                proceso = false;
                            }

                            //Escribe la frase
                            for (int j = 0; j <= 8; j++)
                            {
                                Console.Write(frase1[j]);
                            }

                            //Escribe las lineas guias
                            Console.Write("\n");
                            for (int rayas = 1; rayas <= CantLetras1; rayas++)
                            {
                                Console.Write("_ ");
                            }

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n\nPALABRAS MAL ESCRITAS");
                            for (int k = 0; k < ListaMala1.Count; k++)
                            {
                                Console.Write(ListaMala1[k]);
                            }
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 2:
                        int CantLetras2 = 6;
                        string[] frase2 = new string[CantLetras2];
                        List<string> ListaMala2 = new List<string>();
                        while (proceso == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("     AHORCADO EL JUEGO     ");
                            Console.WriteLine("**************************\n\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            creacionD(CantDibujo);
                            Console.Write("\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("\nDigite una palabra: ");
                            string LetraI = Console.ReadLine();

                            //Verifica palabras ingresadas
                            for (int i = 0; i < CantLetras2; i++)
                            {
                                int numero = palabra.palabra2(LetraI, i);
                                if (numero != 30)
                                {
                                    frase2[i] = LetraI + " ";
                                    cantAcertaciones = cantAcertaciones + 1;
                                    //Console.WriteLine(CantLetras/*"Felicidades has completado la palabra"*/);
                                    if (cantAcertaciones == CantLetras2)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        creacionD(10);
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("Felicidades has completado la palabra");
                                        proceso = false;
                                    }

                                }
                                else if (frase2[i] == "" || frase2[i] == null)
                                {
                                    frase2[i] = "  ";
                                    cantIntentosI = cantIntentosI + 1;
                                    //Console.WriteLine(cantIntentosI);
                                    if (cantIntentosI >= CantLetras2)
                                    {
                                        //cantErrores=cantErrores+1;
                                        CantDibujo = CantDibujo + 1;
                                        ListaMala2.Add(LetraI + " ");

                                    }
                                }
                                else
                                {
                                    frase2[i] = frase2[i];
                                    cantIntentosF = cantIntentosF + 1;
                                    //Console.WriteLine(cantIntentosF);
                                    if (cantIntentosF >= CantLetras2)
                                    {
                                        //cantErrores=cantErrores+1;
                                        CantDibujo = CantDibujo + 1;
                                        ListaMala2.Add(LetraI + " ");
                                    }
                                }
                            }
                            cantIntentosI = 0;
                            cantIntentosF = 0;

                            if (CantDibujo > 8)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                creacionD(11);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("Perdiste, intentalo de nuevo");
                                proceso = false;
                            }

                            //Escribe la frase
                            for (int j = 0; j < CantLetras2; j++)
                            {
                                Console.Write(frase2[j]);
                            }

                            //Escribe las lineas guias
                            Console.Write("\n");
                            for (int rayas = 1; rayas <= CantLetras2; rayas++)
                            {
                                Console.Write("_ ");
                            }

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n\nPALABRAS MAL ESCRITAS");
                            for (int k = 0; k < ListaMala2.Count; k++)
                            {
                                Console.Write(ListaMala2[k]);
                            }

                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 3:
                        int CantLetras3 = 8;
                        string[] frase3 = new string[CantLetras3];
                        List<string> ListaMala3 = new List<string>();
                        while (proceso == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("     AHORCADO EL JUEGO     ");
                            Console.WriteLine("**************************\n\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            creacionD(CantDibujo);
                            Console.Write("\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("\nDigite una palabra: ");
                            string LetraI = Console.ReadLine();

                            //Verifica palabras ingresadas
                            for (int i = 0; i < CantLetras3; i++)
                            {
                                int numero = palabra.palabra3(LetraI, i);
                                if (numero != 30)
                                {
                                    frase3[i] = LetraI + " ";
                                    cantAcertaciones = cantAcertaciones + 1;
                                    //Console.WriteLine(CantLetras/*"Felicidades has completado la palabra"*/);
                                    if (cantAcertaciones == CantLetras3)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        creacionD(10);
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("Felicidades has completado la palabra");
                                        proceso = false;
                                    }

                                }
                                else if (frase3[i] == "" || frase3[i] == null)
                                {
                                    frase3[i] = "  ";
                                    cantIntentosI = cantIntentosI + 1;
                                    //Console.WriteLine(cantIntentosI);
                                    if (cantIntentosI >= CantLetras3)
                                    {
                                        //cantErrores=cantErrores+1;
                                        CantDibujo = CantDibujo + 1;
                                        ListaMala3.Add(LetraI + " ");
                                    }
                                }
                                else
                                {
                                    frase3[i] = frase3[i];
                                    cantIntentosF = cantIntentosF + 1;
                                    //Console.WriteLine(cantIntentosF);
                                    if (cantIntentosF >= CantLetras3)
                                    {
                                        //cantErrores=cantErrores+1;
                                        CantDibujo = CantDibujo + 1;
                                        ListaMala3.Add(LetraI + " ");
                                    }
                                }
                            }
                            cantIntentosI = 0;
                            cantIntentosF = 0;

                            if (CantDibujo > 8)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                creacionD(11);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("Perdiste, intentalo de nuevo");
                                proceso = false;
                            }

                            //Escribe la frase
                            for (int j = 0; j < CantLetras3; j++)
                            {
                                Console.Write(frase3[j]);
                            }

                            //Escribe las lineas guias
                            Console.Write("\n");
                            for (int rayas = 1; rayas <= CantLetras3; rayas++)
                            {
                                Console.Write("_ ");
                            }

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n\nPALABRAS MAL ESCRITAS");
                            for (int k = 0; k < ListaMala3.Count; k++)
                            {
                                Console.Write(ListaMala3[k]);
                            }

                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 4:
                        int CantLetras4 = 12;
                        string[] frase4 = new string[CantLetras4];
                        List<string> ListaMala4 = new List<string>();
                        while (proceso == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("     AHORCADO EL JUEGO     ");
                            Console.WriteLine("**************************\n\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            creacionD(CantDibujo);
                            Console.Write("\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("\nDigite una palabra: ");
                            string LetraI = Console.ReadLine();

                            //Verifica palabras ingresadas
                            for (int i = 0; i < CantLetras4; i++)
                            {
                                int numero = palabra.palabra4(LetraI, i);
                                if (numero != 30)
                                {
                                    frase4[i] = LetraI + " ";
                                    cantAcertaciones = cantAcertaciones + 1;
                                    //Console.WriteLine(CantLetras/*"Felicidades has completado la palabra"*/);
                                    if (cantAcertaciones == CantLetras4)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        creacionD(10);
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("Felicidades has completado la palabra");
                                        proceso = false;
                                    }

                                }
                                else if (frase4[i] == "" || frase4[i] == null)
                                {
                                    frase4[i] = "  ";
                                    cantIntentosI = cantIntentosI + 1;
                                    //Console.WriteLine(cantIntentosI);
                                    if (cantIntentosI >= CantLetras4)
                                    {
                                        //cantErrores=cantErrores+1;
                                        CantDibujo = CantDibujo + 1;
                                        ListaMala4.Add(LetraI + " ");
                                    }
                                }
                                else
                                {
                                    frase4[i] = frase4[i];
                                    cantIntentosF = cantIntentosF + 1;
                                    //Console.WriteLine(cantIntentosF);
                                    if (cantIntentosF >= CantLetras4)
                                    {
                                        //cantErrores=cantErrores+1;
                                        CantDibujo = CantDibujo + 1;
                                        ListaMala4.Add(LetraI + " ");
                                    }
                                }
                            }
                            cantIntentosI = 0;
                            cantIntentosF = 0;

                            if (CantDibujo > 8)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                creacionD(11);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("Perdiste, intentalo de nuevo");
                                proceso = false;
                            }

                            //Escribe la frase
                            for (int j = 0; j < CantLetras4; j++)
                            {
                                Console.Write(frase4[j]);
                            }

                            //Escribe las lineas guias
                            Console.Write("\n");
                            for (int rayas = 1; rayas <= CantLetras4; rayas++)
                            {
                                Console.Write("_ ");
                            }

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n\nPALABRAS MAL ESCRITAS");
                            for (int k = 0; k < ListaMala4.Count; k++)
                            {
                                Console.Write(ListaMala4[k]);
                            }

                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 5:
                        int CantLetras5 = 7;
                        string[] frase5 = new string[CantLetras5];
                        List<string> ListaMala5 = new List<string>();
                        while (proceso == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("     AHORCADO EL JUEGO     ");
                            Console.WriteLine("**************************\n\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            creacionD(CantDibujo);
                            Console.Write("\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("\nDigite una palabra: ");
                            string LetraI = Console.ReadLine();

                            //Verifica palabras ingresadas
                            for (int i = 0; i < CantLetras5; i++)
                            {
                                int numero = palabra.palabra5(LetraI, i);
                                if (numero != 30)
                                {
                                    frase5[i] = LetraI + " ";
                                    cantAcertaciones = cantAcertaciones + 1;
                                    //Console.WriteLine(CantLetras/*"Felicidades has completado la palabra"*/);
                                    if (cantAcertaciones == CantLetras5)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        creacionD(10);
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("Felicidades has completado la palabra");
                                        proceso = false;
                                    }

                                }
                                else if (frase5[i] == "" || frase5[i] == null)
                                {
                                    frase5[i] = "  ";
                                    cantIntentosI = cantIntentosI + 1;
                                    //Console.WriteLine(cantIntentosI);
                                    if (cantIntentosI >= CantLetras5)
                                    {
                                        //cantErrores=cantErrores+1;
                                        CantDibujo = CantDibujo + 1;
                                        ListaMala5.Add(LetraI + " ");
                                    }
                                }
                                else
                                {
                                    frase5[i] = frase5[i];
                                    cantIntentosF = cantIntentosF + 1;
                                    //Console.WriteLine(cantIntentosF);
                                    if (cantIntentosF >= CantLetras5)
                                    {
                                        //cantErrores=cantErrores+1;
                                        CantDibujo = CantDibujo + 1;
                                        ListaMala5.Add(LetraI + " ");
                                    }
                                }
                            }
                            cantIntentosI = 0;
                            cantIntentosF = 0;

                            if (CantDibujo > 8)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                creacionD(11);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("Perdiste, intentalo de nuevo");
                                proceso = false;
                            }

                            //Escribe la frase
                            for (int j = 0; j < CantLetras5; j++)
                            {
                                Console.Write(frase5[j]);
                            }

                            //Escribe las lineas guias
                            Console.Write("\n");
                            for (int rayas = 1; rayas <= CantLetras5; rayas++)
                            {
                                Console.Write("_ ");
                            }

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n\nPALABRAS MAL ESCRITAS");
                            for (int k = 0; k < ListaMala5.Count; k++)
                            {
                                Console.Write(ListaMala5[k]);
                            }

                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 6:
                        int CantLetras6 = 9;
                        string[] frase6 = new string[CantLetras6];
                        List<string> ListaMala6 = new List<string>();
                        while (proceso == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("     AHORCADO EL JUEGO     ");
                            Console.WriteLine("**************************\n\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            creacionD(CantDibujo);
                            Console.Write("\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("\nDigite una palabra: ");
                            string LetraI = Console.ReadLine();

                            //Verifica palabras ingresadas
                            for (int i = 0; i < CantLetras6; i++)
                            {
                                int numero = palabra.palabra6(LetraI, i);
                                if (numero != 30)
                                {
                                    frase6[i] = LetraI + " ";
                                    cantAcertaciones = cantAcertaciones + 1;
                                    //Console.WriteLine(CantLetras/*"Felicidades has completado la palabra"*/);
                                    if (cantAcertaciones == CantLetras6)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        creacionD(10);
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("Felicidades has completado la palabra");
                                        proceso = false;
                                    }

                                }
                                else if (frase6[i] == "" || frase6[i] == null)
                                {
                                    frase6[i] = "  ";
                                    cantIntentosI = cantIntentosI + 1;
                                    //Console.WriteLine(cantIntentosI);
                                    if (cantIntentosI >= CantLetras6)
                                    {
                                        //cantErrores=cantErrores+1;
                                        CantDibujo = CantDibujo + 1;
                                        ListaMala6.Add(LetraI + " ");
                                    }
                                }
                                else
                                {
                                    frase6[i] = frase6[i];
                                    cantIntentosF = cantIntentosF + 1;
                                    //Console.WriteLine(cantIntentosF);
                                    if (cantIntentosF >= CantLetras6)
                                    {
                                        //cantErrores=cantErrores+1;
                                        CantDibujo = CantDibujo + 1;
                                        ListaMala6.Add(LetraI + " ");
                                    }
                                }
                            }
                            cantIntentosI = 0;
                            cantIntentosF = 0;

                            if (CantDibujo > 8)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                creacionD(11);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("Perdiste, intentalo de nuevo");
                                proceso = false;
                            }

                            //Escribe la frase
                            for (int j = 0; j < CantLetras6; j++)
                            {
                                Console.Write(frase6[j]);
                            }

                            //Escribe las lineas guias
                            Console.Write("\n");
                            for (int rayas = 1; rayas <= CantLetras6; rayas++)
                            {
                                Console.Write("_ ");
                            }

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n\nPALABRAS MAL ESCRITAS");
                            for (int k = 0; k < ListaMala6.Count; k++)
                            {
                                Console.Write(ListaMala6[k]);
                            }

                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 7:
                        int CantLetras7 = 7;
                        string[] frase7 = new string[CantLetras7];
                        List<string> ListaMala7 = new List<string>();
                        while (proceso == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("     AHORCADO EL JUEGO     ");
                            Console.WriteLine("**************************\n\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            creacionD(CantDibujo);
                            Console.Write("\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("\nDigite una palabra: ");
                            string LetraI = Console.ReadLine();

                            //Verifica palabras ingresadas
                            for (int i = 0; i < CantLetras7; i++)
                            {
                                int numero = palabra.palabra7(LetraI, i);
                                if (numero != 30)
                                {
                                    frase7[i] = LetraI + " ";
                                    cantAcertaciones = cantAcertaciones + 1;
                                    //Console.WriteLine(CantLetras/*"Felicidades has completado la palabra"*/);
                                    if (cantAcertaciones == CantLetras7)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        creacionD(10);
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("Felicidades has completado la palabra");
                                        proceso = false;
                                    }

                                }
                                else if (frase7[i] == "" || frase7[i] == null)
                                {
                                    frase7[i] = "  ";
                                    cantIntentosI = cantIntentosI + 1;
                                    //Console.WriteLine(cantIntentosI);
                                    if (cantIntentosI >= CantLetras7)
                                    {
                                        //cantErrores=cantErrores+1;
                                        CantDibujo = CantDibujo + 1;
                                        ListaMala7.Add(LetraI + " ");
                                    }
                                }
                                else
                                {
                                    frase7[i] = frase7[i];
                                    cantIntentosF = cantIntentosF + 1;
                                    //Console.WriteLine(cantIntentosF);
                                    if (cantIntentosF >= CantLetras7)
                                    {
                                        //cantErrores=cantErrores+1;
                                        CantDibujo = CantDibujo + 1;
                                        ListaMala7.Add(LetraI + " ");
                                    }
                                }
                            }
                            cantIntentosI = 0;
                            cantIntentosF = 0;

                            if (CantDibujo > 8)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                creacionD(11);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("Perdiste, intentalo de nuevo");
                                proceso = false;
                            }

                            //Escribe la frase
                            for (int j = 0; j < CantLetras7; j++)
                            {
                                Console.Write(frase7[j]);
                            }

                            //Escribe las lineas guias
                            Console.Write("\n");
                            for (int rayas = 1; rayas <= CantLetras7; rayas++)
                            {
                                Console.Write("_ ");
                            }

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n\nPALABRAS MAL ESCRITAS");
                            for (int k = 0; k < ListaMala7.Count; k++)
                            {
                                Console.Write(ListaMala7[k]);
                            }

                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 8:
                        int CantLetras8 = 9;
                        string[] frase8 = new string[CantLetras8];
                        List<string> ListaMala8 = new List<string>();
                        while (proceso == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("     AHORCADO EL JUEGO     ");
                            Console.WriteLine("**************************\n\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            creacionD(CantDibujo);
                            Console.Write("\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("\nDigite una palabra: ");
                            string LetraI = Console.ReadLine();

                            //Verifica palabras ingresadas
                            for (int i = 0; i < CantLetras8; i++)
                            {
                                int numero = palabra.palabra8(LetraI, i);
                                if (numero != 30)
                                {
                                    frase8[i] = LetraI + " ";
                                    cantAcertaciones = cantAcertaciones + 1;
                                    //Console.WriteLine(CantLetras/*"Felicidades has completado la palabra"*/);
                                    if (cantAcertaciones == CantLetras8)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        creacionD(10);
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("Felicidades has completado la palabra");
                                        proceso = false;
                                    }

                                }
                                else if (frase8[i] == "" || frase8[i] == null)
                                {
                                    frase8[i] = "  ";
                                    cantIntentosI = cantIntentosI + 1;
                                    //Console.WriteLine(cantIntentosI);
                                    if (cantIntentosI >= CantLetras8)
                                    {
                                        //cantErrores=cantErrores+1;
                                        CantDibujo = CantDibujo + 1;
                                        ListaMala8.Add(LetraI + " ");
                                    }
                                }
                                else
                                {
                                    frase8[i] = frase8[i];
                                    cantIntentosF = cantIntentosF + 1;
                                    //Console.WriteLine(cantIntentosF);
                                    if (cantIntentosF >= CantLetras8)
                                    {
                                        //cantErrores=cantErrores+1;
                                        CantDibujo = CantDibujo + 1;
                                        ListaMala8.Add(LetraI + " ");
                                    }
                                }
                            }
                            cantIntentosI = 0;
                            cantIntentosF = 0;

                            if (CantDibujo > 8)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                creacionD(11);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("Perdiste, intentalo de nuevo");
                                proceso = false;
                            }

                            //Escribe la frase
                            for (int j = 0; j < CantLetras8; j++)
                            {
                                Console.Write(frase8[j]);
                            }

                            //Escribe las lineas guias
                            Console.Write("\n");
                            for (int rayas = 1; rayas <= CantLetras8; rayas++)
                            {
                                Console.Write("_ ");
                            }

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n\nPALABRAS MAL ESCRITAS");
                            for (int k = 0; k < ListaMala8.Count; k++)
                            {
                                Console.Write(ListaMala8[k]);
                            }

                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 9:
                        int CantLetras9 = 10;
                        string[] frase9 = new string[CantLetras9];
                        List<string> ListaMala9 = new List<string>();
                        while (proceso == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("     AHORCADO EL JUEGO     ");
                            Console.WriteLine("**************************\n\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            creacionD(CantDibujo);
                            Console.Write("\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("\nDigite una palabra: ");
                            string LetraI = Console.ReadLine();

                            //Verifica palabras ingresadas
                            for (int i = 0; i < CantLetras9; i++)
                            {
                                int numero = palabra.palabra9(LetraI, i);
                                if (numero != 30)
                                {
                                    frase9[i] = LetraI + " ";
                                    cantAcertaciones = cantAcertaciones + 1;
                                    //Console.WriteLine(CantLetras/*"Felicidades has completado la palabra"*/);
                                    if (cantAcertaciones == CantLetras9)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        creacionD(10);
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("Felicidades has completado la palabra");
                                        proceso = false;
                                    }

                                }
                                else if (frase9[i] == "" || frase9[i] == null)
                                {
                                    frase9[i] = "  ";
                                    cantIntentosI = cantIntentosI + 1;
                                    //Console.WriteLine(cantIntentosI);
                                    if (cantIntentosI >= CantLetras9)
                                    {
                                        //cantErrores=cantErrores+1;
                                        CantDibujo = CantDibujo + 1;
                                        ListaMala9.Add(LetraI + " ");
                                    }
                                }
                                else
                                {
                                    frase9[i] = frase9[i];
                                    cantIntentosF = cantIntentosF + 1;
                                    //Console.WriteLine(cantIntentosF);
                                    if (cantIntentosF >= CantLetras9)
                                    {
                                        //cantErrores=cantErrores+1;
                                        CantDibujo = CantDibujo + 1;
                                        ListaMala9.Add(LetraI + " ");
                                    }
                                }
                            }
                            cantIntentosI = 0;
                            cantIntentosF = 0;

                            if (CantDibujo > 8)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                creacionD(11);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("Perdiste, intentalo de nuevo");
                                proceso = false;
                            }

                            //Escribe la frase
                            for (int j = 0; j < CantLetras9; j++)
                            {
                                Console.Write(frase9[j]);
                            }

                            //Escribe las lineas guias
                            Console.Write("\n");
                            for (int rayas = 1; rayas <= CantLetras9; rayas++)
                            {
                                Console.Write("_ ");
                            }

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n\nPALABRAS MAL ESCRITAS");
                            for (int k = 0; k < ListaMala9.Count; k++)
                            {
                                Console.Write(ListaMala9[k]);
                            }

                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 10:
                        int CantLetras10 = 7;
                        string[] frase10 = new string[CantLetras10];
                        List<string> ListaMala10 = new List<string>();
                        while (proceso == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("     AHORCADO EL JUEGO     ");
                            Console.WriteLine("**************************\n\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            creacionD(CantDibujo);
                            Console.Write("\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("\nDigite una palabra: ");
                            string LetraI = Console.ReadLine();

                            //Verifica palabras ingresadas
                            for (int i = 0; i < CantLetras10; i++)
                            {
                                int numero = palabra.palabra10(LetraI, i);
                                if (numero != 30)
                                {
                                    frase10[i] = LetraI + " ";
                                    cantAcertaciones = cantAcertaciones + 1;
                                    //Console.WriteLine(CantLetras/*"Felicidades has completado la palabra"*/);
                                    if (cantAcertaciones == CantLetras10)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        creacionD(10);
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("Felicidades has completado la palabra");
                                        proceso = false;
                                    }

                                }
                                else if (frase10[i] == "" || frase10[i] == null)
                                {
                                    frase10[i] = "  ";
                                    cantIntentosI = cantIntentosI + 1;
                                    //Console.WriteLine(cantIntentosI);
                                    if (cantIntentosI >= CantLetras10)
                                    {
                                        //cantErrores=cantErrores+1;
                                        CantDibujo = CantDibujo + 1;
                                        ListaMala10.Add(LetraI + " ");
                                    }
                                }
                                else
                                {
                                    frase10[i] = frase10[i];
                                    cantIntentosF = cantIntentosF + 1;
                                    //Console.WriteLine(cantIntentosF);
                                    if (cantIntentosF >= CantLetras10)
                                    {
                                        //cantErrores=cantErrores+1;
                                        CantDibujo = CantDibujo + 1;
                                        ListaMala10.Add(LetraI + " ");
                                    }
                                }
                            }
                            cantIntentosI = 0;
                            cantIntentosF = 0;

                            if (CantDibujo > 8)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                creacionD(11);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("Perdiste, intentalo de nuevo");
                                proceso = false;
                            }

                            //Escribe la frase
                            for (int j = 0; j < CantLetras10; j++)
                            {
                                Console.Write(frase10[j]);
                            }

                            //Escribe las lineas guias
                            Console.Write("\n");
                            for (int rayas = 1; rayas <= CantLetras10; rayas++)
                            {
                                Console.Write("_ ");
                            }

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n\nPALABRAS MAL ESCRITAS");
                            for (int k = 0; k < ListaMala10.Count; k++)
                            {
                                Console.Write(ListaMala10[k]);
                            }

                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\n Desea volver a jugar? si o no: ");
                string cont = Console.ReadLine();

                if (cont == "no" || cont == "NO" || cont == "No")
                {
                    continuar = false;
                }
            }

        }
        public static void creacionD(int Valordibujo)
        {
            muñeco dibujo = new muñeco();
            switch (Valordibujo)
            {
                case 1:
                    //Console.Clear();
                    Console.WriteLine("\n\n");
                    dibujo.barra();
                    break;
                case 2:
                    //Console.Clear();
                    dibujo.barra1();
                    break;
                case 3:
                    //Console.Clear();
                    dibujo.barra2();
                    break;
                case 4:
                    //Console.Clear();
                    dibujo.barra3();
                    break;
                case 5:
                    //Console.Clear();
                    dibujo.barra4();
                    break;
                case 6:
                    //Console.Clear();
                    dibujo.barra5();
                    break;
                case 7:
                    //Console.Clear();
                    dibujo.barra6();
                    break;
                case 8:
                    //Console.Clear();
                    dibujo.barra7();
                    break;
                case 10:
                    dibujo.Ganador();
                    break;
                case 11:
                    dibujo.Perdedor();
                    break;

            }
        }

        public static int Rnumero()
        {
            Random numeroA = new Random();
            int aleatorio = numeroA.Next(1, 10);
            return aleatorio;
        }
    }   

}

class muñeco
{

    public void barra()
    {
        Console.WriteLine("|--------------");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
    }

    public void barra1()
    {
        Console.WriteLine("|--------------");
        Console.WriteLine("|      ||      ");
        Console.WriteLine("|      ||");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
    }

    public void barra2()
    {
        Console.WriteLine("|--------------");
        Console.WriteLine("|      ||      ");
        Console.WriteLine("|      ||      ");
        Console.WriteLine("|     ****     ");
        Console.WriteLine("|    *    *    ");
        Console.WriteLine("|    *    *    ");
        Console.WriteLine("|     ****     ");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
    }

    public void barra3()
    {
        Console.WriteLine("|--------------");
        Console.WriteLine("|      ||      ");
        Console.WriteLine("|      ||      ");
        Console.WriteLine("|     ****     ");
        Console.WriteLine("|    *    *    ");
        Console.WriteLine("|    *    *    ");
        Console.WriteLine("|     ****     ");
        Console.WriteLine("|      **      ");
        Console.WriteLine("|     ****     ");
        Console.WriteLine("|     ****     ");
        Console.WriteLine("|     ****     ");
        Console.WriteLine("|     ****     ");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
    }

    public void barra4()
    {
        Console.WriteLine("|--------------");
        Console.WriteLine("|      ||      ");
        Console.WriteLine("|      ||      ");
        Console.WriteLine("|     ****     ");
        Console.WriteLine("|    *    *    ");
        Console.WriteLine("|    *    *    ");
        Console.WriteLine("|     ****     ");
        Console.WriteLine("|      **      ");
        Console.WriteLine("|  *******     ");
        Console.WriteLine("|  *  ****     ");
        Console.WriteLine("|  *  ****     ");
        Console.WriteLine("|  *  ****     ");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
    }

    public void barra5()
    {
        Console.WriteLine("|--------------");
        Console.WriteLine("|      ||      ");
        Console.WriteLine("|      ||      ");
        Console.WriteLine("|     ****     ");
        Console.WriteLine("|    *    *    ");
        Console.WriteLine("|    *    *    ");
        Console.WriteLine("|     ****     ");
        Console.WriteLine("|      **      ");
        Console.WriteLine("|  **********  ");
        Console.WriteLine("|  *  ****  *  ");
        Console.WriteLine("|  *  ****  *  ");
        Console.WriteLine("|  *  ****  *  ");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
    }

    public void barra6()
    {
        Console.WriteLine("|--------------");
        Console.WriteLine("|      ||      ");
        Console.WriteLine("|      ||      ");
        Console.WriteLine("|     ****     ");
        Console.WriteLine("|    *    *    ");
        Console.WriteLine("|    *    *    ");
        Console.WriteLine("|     ****     ");
        Console.WriteLine("|      **      ");
        Console.WriteLine("|  **********  ");
        Console.WriteLine("|  *  ****  *  ");
        Console.WriteLine("|  *  ****  *  ");
        Console.WriteLine("|  *  ****  *  ");
        Console.WriteLine("|     *        ");
        Console.WriteLine("|    *         ");
        Console.WriteLine("|   *          ");
        Console.WriteLine("|  *           ");
    }

    public void barra7()
    {
        Console.WriteLine("|--------------");
        Console.WriteLine("|      ||      ");
        Console.WriteLine("|      ||      ");
        Console.WriteLine("|     ****     ");
        Console.WriteLine("|    *    *    ");
        Console.WriteLine("|    *    *    ");
        Console.WriteLine("|     ****     ");
        Console.WriteLine("|      **      ");
        Console.WriteLine("|  **********  ");
        Console.WriteLine("|  *  ****  *  ");
        Console.WriteLine("|  *  ****  *  ");
        Console.WriteLine("|  *  ****  *  ");
        Console.WriteLine("|     *  *     ");
        Console.WriteLine("|    *    *    ");
        Console.WriteLine("|   *      *   ");
        Console.WriteLine("|  *        *  ");
    }

    public void Ganador()
    {
        Console.WriteLine("  ***               ***  ***********  ******    ***  ");
        Console.WriteLine("   ***             ***   ***********  ******    ***  ");
        Console.WriteLine("    ***    ***    ***        ***      *** ***   ***  ");
        Console.WriteLine("     ***   ***   ***         ***      ***  ***  ***  ");
        Console.WriteLine("      *** ***** ***          ***      ***   *** ***  ");
        Console.WriteLine("       ***********       ***********  ***    ******  ");
        Console.WriteLine("        ***   ***        ***********  ***     *****  ");
    }

    public void Perdedor()
    {
        Console.WriteLine("  *********  ");
        Console.WriteLine("  *********  ");
        Console.WriteLine("  ***        ");
        Console.WriteLine("  ******     ");
        Console.WriteLine("  ******     ");
        Console.WriteLine("  ***        ");
        Console.WriteLine("  ***        ");
    }
}

class palabras
{

    public int palabra1(string LetraI, int i)
    {

        string[] texto1 = { "U", "N", "I", "C", "O", "R", "N", "I", "O" };

        if (texto1[i] == LetraI)
        {
            return i;
        }
        else
        {
            return 30;
        }
    }
    public int palabra2(string LetraI, int i)
    {

        string[] texto2 = { "A", "B", "U", "E", "L", "O" };

        if (texto2[i] == LetraI)
        {
            return i;
        }
        else
        {
            return 30;
        }

    }
    public int palabra3(string LetraI, int i)
    {

        string[] texto3 = { "L", "A", "N", "G", "O", "S", "T", "A" };

        if (texto3[i] == LetraI)
        {
            return i;
        }
        else
        {
            return 30;
        }

    }
    public int palabra4(string LetraI, int i)
    {

        string[] texto4 = { "O", "R", "N", "I", "T", "O", "R", "R", "I", "N", "C", "O" };

        if (texto4[i] == LetraI)
        {
            return i;
        }
        else
        {
            return 30;
        }

    }
    public int palabra5(string LetraI, int i)
    {

        string[] texto5 = { "F", "A", "M", "I", "L", "I", "A" };

        if (texto5[i] == LetraI)
        {
            return i;
        }
        else
        {
            return 30;
        }

    }
    public int palabra6(string LetraI, int i)
    {

        string[] texto6 = { "Z", "A", "N", "A", "H", "O", "R", "I", "A" };

        if (texto6[i] == LetraI)
        {
            return i;
        }
        else
        {
            return 30;
        }

    }
    public int palabra7(string LetraI, int i)
    {

        string[] texto7 = { "S", "A", "X", "O", "F", "O", "N" };

        if (texto7[i] == LetraI)
        {
            return i;
        }
        else
        {
            return 30;
        }

    }
    public int palabra8(string LetraI, int i)
    {

        string[] texto8 = { "S", "E", "R", "P", "I", "E", "N", "T", "E" };

        if (texto8[i] == LetraI)
        {
            return i;
        }
        else
        {
            return 30;
        }

    }
    public int palabra9(string LetraI, int i)
    {

        string[] texto9 = { "N", "A", "T", "U", "R", "A", "L", "E", "Z", "A" };

        if (texto9[i] == LetraI)
        {
            return i;
        }
        else
        {
            return 30;
        }

    }
    public int palabra10(string LetraI, int i)
    {

        string[] texto10 = { "A", "B", "A", "N", "I", "C", "O" };

        if (texto10[i] == LetraI)
        {
            return i;
        }
        else
        {
            return 30;
        }

    }
}
