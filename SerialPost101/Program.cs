using System;
using static System.Console;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Me.Venj;

namespace SerialPost101
{
    public class Program {
        static void Main(string[] args) {
            sendToSelf();
        }

        public static void sendToOthers()
        {
            SerialPort sp = new SerialPort();
            string[] spNames = SerialPort.GetPortNames();
            if (spNames.Count() < 2)
            {
                WriteLine("No serial ports found!!!");
                ReadLine();
                return;
            }
            sp.PortName = spNames[1];
            sp.BaudRate = 4800;
            sp.Open();


            SerialPort sp2 = new SerialPort();
            sp2.PortName = spNames[0];
            sp2.BaudRate = 4800;
            sp2.Open();

            byte[] writeData;
            writeData = Encoding.Unicode.GetBytes("Hello world.");
            string convertedString = Convert.ToBase64String(writeData);
            sp.WriteLine(convertedString);
            WriteLine("Message Sent!");


            byte[] data;
            do
            {
                data = Convert.FromBase64String(sp2.ReadLine());
            } while (data.Count() == 0);

            string result = Encoding.Unicode.GetString(data);
            WriteLine("Message Received!");
            WriteLine(result);
            sp.Close();
            sp2.Close();
            Helper.Pause();
        }

        static void sendToSelf()
        {
            SerialPort sp = new SerialPort();
            string[] spNames = SerialPort.GetPortNames();
            if (spNames.Count() == 0)
            {
                WriteLine("No serial ports found!!!");
                ReadLine();
                return;
            }
            sp.PortName = spNames[0];
            sp.BaudRate = 4800;
            sp.Open();
            byte[] writeData;
            writeData = Encoding.Unicode.GetBytes("Hello world.");
            string convertedString = Convert.ToBase64String(writeData);
            sp.WriteLine(convertedString);
            WriteLine("Message Sent!");

            byte[] data;
            do
            {
                data = Convert.FromBase64String(sp.ReadLine());
            } while (data.Count() == 0);

            string result = Encoding.Unicode.GetString(data);
            WriteLine("Message Received!");
            WriteLine(result);
            sp.Close();
            Helper.Pause();
        }
    }
}
