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
        static SerialPort Arduino = new SerialPort("COM5", 9600); // cambiar COM5 por puerto de arduino predeterminado
                                                                 
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

            Console.WriteLine(" Bienvenido, este programa fue creado para manipular las luces de un semaforo," +
                " donde el usuario puede seleccionar que luz desea encender "); 

            while (menu != 's')

            {
                Console.WriteLine(" \\ n ---------------------------------- \\ n ");
                Console.WriteLine(" _______________________________________________________________ ");
                Console.WriteLine(" 1.-encender luz verde ");
                Console.WriteLine(" 2.-encender luz amarilla ");
                Console.WriteLine(" 3.-encender luz roja ");
                Console.WriteLine(" 4.-salir ");
                Console.WriteLine(" \\ n ---------------------------------- \\ n ");
                Console.WriteLine(" seleccione la opcion que desea ejecutar: ");

                op = int.Parse(Console.ReadLine());

                if (op == 1)

                {
                    if (Arduino.IsOpen)
                    {
                        Console.WriteLine(" \\ n ---------------------------------- \\ n ");
                        Console.WriteLine("com abierto");
                        byte[] data = Encoding.ASCII.GetBytes("V");
                        Arduino.Write(data, 0, data.Length);

                        Console.WriteLine(" ingrese: 'V' para encender la luz verde");
                        Console.WriteLine(" ingrese: 'A' para apagar la luz verde");

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

                        Console.WriteLine(" ingrese: 'B' para encender la luz amarilla");
                        Console.WriteLine(" ingrese: 'C' para apagar la luz amarila");

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

                        Console.WriteLine(" ingrese: 'D' para encender la luz roja");
                        Console.WriteLine(" ingrese: 'E' para apagar la luz roja");

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
