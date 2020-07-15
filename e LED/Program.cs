using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
namespace e_LED
{
    class Program
    {
        // integrantes: Giuliana, Lineli, Isabel y Osmar
        //Link de programa de timkercad: https://www.tinkercad.com/things/fhzcfgRpY3h-copy-of-proyecto/editel?sharecode=jDVVtDaxlcMv5CfS0_lS0vUen1Q22n_CXrW8Jvmdwhs

        static char[,] datos = new char[3, 3];
        static SerialPort Arduino = new SerialPort("COM5", 9600); 
                                                                 
        static void Main(string[] args)
        {
            char menu = 'n';
            int op = 0;

            Arduino.Parity = Parity.None;
            Arduino.StopBits = StopBits.One;
            Arduino.DataBits = 8;
            Arduino.Handshake = Handshake.None;
            Arduino.RtsEnable = true;

            Arduino.Open();

          

            while (menu != 's')

            {
                Console.WriteLine(" \\ n ---------------------------------- \\ n ");
                Console.WriteLine(" _______________________________________________________________ ");
                Console.WriteLine(" 1.-encender LED verde ");
                Console.WriteLine(" 2.-encender LED amarillo ");
                Console.WriteLine(" 3.-encender LED rojo ");
                Console.WriteLine(" 4.-salir ");
                Console.WriteLine(" \\ n ---------------------------------- \\ n ");
                Console.WriteLine(" Igrese el numero de la opcion que desea ejecutar: ");

                op = int.Parse(Console.ReadLine());

                if (op == 1)

                {
                    if (Arduino.IsOpen)
                    {
                        Console.WriteLine(" \\ n ---------------------------------- \\ n ");
                        Console.WriteLine("com abierto");
                        byte[] data = Encoding.ASCII.GetBytes("V");
                        Arduino.Write(data, 0, data.Length);

                        Console.WriteLine(" ingrese: 'V' para encender el LED verde");

                        Console.WriteLine(" ingrese: 'A' para apagar el LED verde");

                        Arduino.Write("A");
                    }

                    else
                    {
                        Console.WriteLine(" \\ n ---------------------------------- \\ n ");
                        Console.WriteLine("com cerrado");
                    }
                }

                else if (op == 2)
                {
                    if (Arduino.IsOpen)
                    {
                        Console.WriteLine(" \\ n ---------------------------------- \\ n ");
                        Console.WriteLine("com abierto");
                        byte[] data = Encoding.ASCII.GetBytes("B");
                        Arduino.Write(data, 0, data.Length);

                        Console.WriteLine(" ingrese: 'B' para encender el LED amarillo");

                        Console.WriteLine(" ingrese: 'C' para apagar el LED amarilo");

                        Arduino.Write("C");
                    }

                    else
                    {
                        Console.WriteLine(" \\ n ---------------------------------- \\ n ");
                        Console.WriteLine("com cerrado");
                    }
                }

                else if (op == 3)
                {
                    if (Arduino.IsOpen)
                    {
                        Console.WriteLine(" \\ n ---------------------------------- \\ n ");
                        Console.WriteLine("com abierto");
                        byte[] data = Encoding.ASCII.GetBytes("D");
                        Arduino.Write(data, 0, data.Length);

                        Console.WriteLine(" ingrese: 'D' para encender el LED rojo");

                        Console.WriteLine(" ingrese: 'E' para apagar el LED rojo");

                        Arduino.Write("E");
                    }

                    else
                    {
                        Console.WriteLine(" \\ n ---------------------------------- \\ n ");
                        Console.WriteLine("com cerrado");
                    }

                }

                else if (op == 4)
                {

                    Console.WriteLine(" desea salir [s / n] ");
                    menu = char.Parse(Console.ReadLine());

                }

                Console.ReadKey();
            }

            Arduino.Close();
        }
    }
}
