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
            Arduino.Parity = Parity.None;
            Arduino.StopBits = StopBits.One;
            Arduino.DataBits = 8;
            Arduino.Handshake = Handshake.None;
            Arduino.RtsEnable = true;

            Arduino.Open();

            if (Arduino.IsOpen)
            {
                Console.WriteLine("com abierto");
                byte[] data = Encoding.ASCII.GetBytes("e");
                Arduino.Write(data, 0, data.Length);

                Arduino.Write("a");
            }

            else 
            {
                Console.WriteLine("com cerrado");
            }

            Console.ReadKey();
        }
    }
}
