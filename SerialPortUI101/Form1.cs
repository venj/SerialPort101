using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialPortUI101
{
    public partial class Form1 : Form
    {
        List<SerialPort> spList = new List<SerialPort>();

        public Form1()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            foreach (var port in ports)
            {
                serialPortsComboBox.Items.Add(port);
            }
            if (ports.Count() < 2)
            {
                MessageBox.Show("少于2个COM口，无法通讯。");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentPortName = serialPortsComboBox.Text;
            if (currentPortName.Length == 0)
            {
                return;
            }
            if (openCloseButton.Text == "打开")
            {
                openPortWithName(currentPortName);
                if (spList.Count < 2)
                {
                    return;
                }
                else
                {
                    sendButton.Enabled = true;
                    openCloseButton.Text = "关闭";
                }
            }
            else
            {
                closePortWithName(currentPortName);
                if (spList.Count < 2)
                {
                    sendButton.Enabled = false;
                }
                if (spList.Count == 0)
                {
                    openCloseButton.Text = "打开";
                }
            }
        }

        private void openPortWithName(string portName)
        {
            SerialPort p = getPortWithPortName(portName);
            if (p != null)
            {
                return;
            }
            else
            {
                p = new SerialPort(portName);
                p.Open();
                p.BaudRate = 4800;
                spList.Add(p);
                logBox.Text += portName + " opened. " + portName + " status: " + (p.IsOpen ? "Opened" : "Closed") + ". Number of port opened: " + spList.Count + ".\r\n";
            }
        }

        
        private SerialPort getPortWithPortName(string portname)
        {
            foreach (var p in spList)
            {
                if (p.PortName == portname)
                {
                    return p;
                }
            }

            return null;
        }

        private void closePortWithName(string portName)
        {
            SerialPort p = getPortWithPortName(portName);
            if (p != null)
            {
                p.Close();
                if (!p.IsOpen)
                {
                    spList.Remove(p);
                    logBox.Text += portName + " closed. " + spList.Count() + " ports left.\r\n";
                }
                else
                {
                    logBox.Text += "Failed to close SerialPort: " + portName + ".\r\n";
                }
            }
        }

        private void logBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            logBox.Text += "Try to send message from " + spList[0].PortName + " to " + spList[1].PortName + "...";
            sendMessage(spList[0], spList[1], sourceTextBox.Text);
            logBox.Text += "Done. \r\n";
        }

        private void sendMessage(SerialPort from, SerialPort to, string message)
        {
            if (message.Length == 0)
            {
                return;
            }
            byte[] writeData;
            writeData = Encoding.Unicode.GetBytes(message);
            string convertedString = Convert.ToBase64String(writeData);
            from.WriteLine(convertedString);

            byte[] data;
            do
            {
                data = Convert.FromBase64String(to.ReadLine());
            } while (data.Count() == 0);

            string destination = Encoding.Unicode.GetString(data);
            destinationTextBox.Text = destination;
        }

        private void clearLogButton_Click(object sender, EventArgs e)
        {
            logBox.Text = "";
        }
    }
}
