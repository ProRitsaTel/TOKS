using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TOKS_1
{
    class Class1
    {
        private SerialPort serialPort1;
        public void InitializePort(string port)
        {
            serialPort1 = new SerialPort(port,
            9600,
            Parity.None,
            8,
            StopBits.One);
            
            serialPort1.Open();
            serialPort1.ErrorReceived += new SerialErrorReceivedEventHandler(serialPort_ErrorReceived);
            //serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
        }

         public void Form1_Load()
        {
            InitializePort1();
            if (serialPort1.IsOpen)
            {
                byte[] send = new byte[256];
                serialPort1.Write(send, 0, 3);
            }
            serialPort1.Close();    
        }
       public void serialPort_DataReceived()
        {
            InitializePort1();
            byte[] data = new byte[serialPort1.BytesToRead];
            serialPort1.Read(data, 0, data.Length);
        }

        private static void serialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            SerialPort serialPort = sender as SerialPort;

            if (serialPort != null)
            {
                Console.WriteLine("Error recieved. Port name: {0}.", serialPort.PortName);
            }
        }
       
    }
}


