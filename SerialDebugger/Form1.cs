using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialDebugger
{
    public partial class Form1 : Form
    {
        ArduinoSerial Arduino = new ArduinoSerial();

        public Form1()
        {
            InitializeComponent();

            Arduino.ArduinoDefaults(baudrate_cbox, databit_cbox, parity_cbox, stopbit_cbox);

            serialPortAliveTimer.Enabled = true;
        }

        private void comport_cbox_Click(object sender, EventArgs e)
        {
            comport_cbox.Items.AddRange(Arduino.AvailablePorts());
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            Arduino.SetSerialPort(comport_cbox, baudrate_cbox, databit_cbox, parity_cbox, stopbit_cbox);

            /* Is not open */
            if (!Arduino.serialPort.IsOpen)
            {
                try
                {
                    Arduino.serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    Arduino.serialPort.Open();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Serial Port error");

                    Arduino.serialPort.Close();
                    Arduino.serialPort.Dispose();
                }
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            serialMonitor_rtbox.AppendText(DateTime.Now.ToString() + indata + "\n");
        }
 
        private void serialPortAlive_Tick(object sender, EventArgs e)
        {
            if(Arduino.serialPort.IsOpen)
            {
                connect_btn.Enabled = false;
                disconnect_btn.Enabled = true;

                connection_status_tSlabel.Text = "Connected";
                connection_status_tSlabel.BackColor = Color.Green;

                connected_comport_tSlabel.Text = Arduino.serialPort.PortName;
                baudrate_tSlabel.Text = Arduino.serialPort.BaudRate.ToString();
            }
            else
            {
                connect_btn.Enabled = true;
                disconnect_btn.Enabled = false;

                connection_status_tSlabel.Text = "Disconnected";
                connection_status_tSlabel.BackColor = Color.Empty;

                connected_comport_tSlabel.Text = " - ";
                baudrate_tSlabel.Text = " - ";
            }
        }

        private void disconnect_btn_Click(object sender, EventArgs e)
        {
            Arduino.serialPort.Close();
            Arduino.serialPort.Dispose();
        }
    }
}
