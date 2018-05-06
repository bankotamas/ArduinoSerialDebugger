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

        private void connect_btn_Click(object sender, EventArgs e)
        {
            /* Is not open */
            if (!Arduino.serialPort.IsOpen)
            {
                try
                {
                    Arduino.serialPort.PortName = comport_cbox.SelectedItem.ToString();
                    Arduino.serialPort.BaudRate = Convert.ToInt32(baudrate_cbox.SelectedItem.ToString());

                    Arduino.serialPort.DataBits = Convert.ToInt32(databit_cbox.SelectedItem.ToString());

                    switch (parity_cbox.SelectedItem.ToString())
                    {
                        case "None":
                            Arduino.serialPort.Parity = Parity.None;
                            break;
                        case "Odd":
                            Arduino.serialPort.Parity = Parity.Odd;
                            break;
                        case "Even":
                            Arduino.serialPort.Parity = Parity.Even;
                            break;
                        case "Mark":
                            Arduino.serialPort.Parity = Parity.Mark;
                            break;
                        case "Space":
                            Arduino.serialPort.Parity = Parity.Space;
                            break;
                    }

                    switch (stopbit_cbox.SelectedItem.ToString())
                    {
                        case "None":
                            Arduino.serialPort.StopBits = StopBits.None;
                            break;
                        case "One":
                            Arduino.serialPort.StopBits = StopBits.One;
                            break;
                        case "Two":
                            Arduino.serialPort.StopBits = StopBits.Two;
                            break;
                        case "OnePointFive":
                            Arduino.serialPort.StopBits = StopBits.OnePointFive;
                            break;
                    }

                    Arduino.serialPort.Open();
                    Arduino.serialPort.DataReceived += new SerialDataReceivedEventHandler(Arduino_DataReceived);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Serial Port error");
                }
            }
            else
            {
                Arduino.serialPort.Close();
                Arduino.serialPort.Dispose();
            }
        }

        private void Arduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string incoming = Arduino.serialPort.ReadLine();
                BeginInvoke(new LineReceivedEvent(LineReceived), incoming);
            }
            catch { }
        }

        private delegate void LineReceivedEvent(string incomingData);

        private void LineReceived(string incomingData)
        {
            serialMonitor_rtbox.AppendText(DateTime.Now.ToLongTimeString() + " [Received] - " + incomingData.ToString() + "\n");
            serialMonitor_rtbox.ScrollToCaret();
        }

        private void serialPortAlive_Tick(object sender, EventArgs e)
        {
            if(Arduino.serialPort.IsOpen)
            {
                connect_btn.Enabled = false;
                disconnect_btn.Enabled = true;
                sendCommand_btn.Enabled = true;

                connection_status_tSlabel.Text = "Connected";
                connection_status_tSlabel.BackColor = Color.Green;

                connected_comport_tSlabel.Text = Arduino.serialPort.PortName;
                baudrate_tSlabel.Text = Arduino.serialPort.BaudRate.ToString();
            }
            else
            {
                connect_btn.Enabled = true;
                disconnect_btn.Enabled = false;
                sendCommand_btn.Enabled = false;

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

        private void sendCommand_btn_Click(object sender, EventArgs e)
        {
            getTemp();
        }

        private void getTemp()
        {
            String msg = "6,0,0,0\n";
            Arduino.serialPort.Write(msg);

            serialMonitor_rtbox.AppendText(DateTime.Now.ToLongTimeString() + " [Sent] - " + msg.ToString() + "\n");
            serialMonitor_rtbox.ScrollToCaret();
        }

        private void comport_cbox_Click(object sender, EventArgs e)
        {
            comport_cbox.Items.Clear();
            comport_cbox.Items.AddRange(Arduino.AvailablePorts());
        }
    }
}
