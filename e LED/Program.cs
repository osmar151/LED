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
        static char[,] datos = new char[3, 3];
        static SerialPort Arduino = new SerialPort("COM5, 9600"); // en la parte de COM5 que esta a la izquieda
                                                                  //poner el que diga Arduino.
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
                Console.WriteLine(" 1.-encender luz roja ");
                Console.WriteLine(" 2.-encender el amarilla ");
                Console.WriteLine(" 3.-encender el azul ");

                op = int.Parse(Console.ReadLine());

                if (op == 1)

                {
                    if (Arduino.IsOpen)
                    {
                        Console.WriteLine("com abierto");
                        byte[] data = Encoding.ASCII.GetBytes("R");
                        Arduino.Write(data, 0, data.Length);

                        Arduino.Write("a");
                    }

                    else
                    {
                        Console.WriteLine("com cerrado");
                    }
                }

                else if (op == 2)
                {
                    if (Arduino.IsOpen)
                    {
                        Console.WriteLine("com abierto");
                        byte[] data = Encoding.ASCII.GetBytes("A");
                        Arduino.Write(data, 0, data.Length);

                        Arduino.Write("a");
                    }

                    else
                    {
                        Console.WriteLine("com cerrado");
                    }
                }

                else if (op == 3)
                {
                    if (Arduino.IsOpen)
                    {
                        Console.WriteLine("com abierto");
                        byte[] data = Encoding.ASCII.GetBytes("V");
                        Arduino.Write(data, 0, data.Length);

                        Arduino.Write("a");
                    }

                    else
                    {
                        Console.WriteLine("com cerrado");
                    }

                }

                    Console.ReadKey();
            }
        }
    }
}
