using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        Jason serializer = new Jason();
        public string SettingsFolderPath = "Settings";

        public List<ArduinoSerial.serialportData> dataList = new List<ArduinoSerial.serialportData>();

        public Form1()
        {
            InitializeComponent();

            /* Check Settings folder is Exist or not. If not, we need to create it. */
            if(!Directory.Exists(SettingsFolderPath))
            {
                Directory.CreateDirectory(SettingsFolderPath);
            }

            /* Set default serialport parameters for arduino */
            Arduino.ArduinoDefaults(baudrate_cbox, databit_cbox, parity_cbox, stopbit_cbox);

            /* Alive timer... */
            serialPortAliveTimer.Enabled = true;

            /* Data structures for read and handling settings data */
            ArduinoSerial.saveSettings readSettings = new ArduinoSerial.saveSettings();
            ArduinoSerial.serialportData portData = new ArduinoSerial.serialportData();

            List<string> settingsList = new List<string>();

            /* Find all settings file in Settings directory */
            foreach (string filePath in Directory.EnumerateFiles(SettingsFolderPath, "*.settings"))
            {
                settingsList.Add(filePath);
            }

            /* If the result is higher than zero, we have settings */
            if (settingsList.Count > 0)
            {
                foreach (string filePath in settingsList)
                {
                    /* Read settings from json file format */
                    try
                    {
                        readSettings = Jason.ReadFromJsonFile<ArduinoSerial.saveSettings>(filePath);
                        portData = new ArduinoSerial.serialportData(readSettings);
                        dataList.Add(portData);
                        settings_lbox.Items.Add(portData.dataName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Sajna nem sikerült beolvasni");
                    }
                }
            }
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            /* Is not open */
            if (!Arduino.serialPort.IsOpen)
            {
                Arduino.SetSerialPort(comport_cbox, baudrate_cbox, databit_cbox, parity_cbox, stopbit_cbox);

                Arduino.serialPort.Open();
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
            int existIndex;

            /* Fill comport combobox */
            foreach (string port in Arduino.AvailablePorts())
            {
                /* Check that port name is in the combobox already */
                existIndex = comport_cbox.FindString(port);

                /* If not, than add to combobox */
                if (!(existIndex >= 0))
                {
                    comport_cbox.Items.Add(port);
                }
            }
        }

        private void saveSettings_btn_Click(object sender, EventArgs e)
        {
            settings_lbox.Items.Add(settingsName_tbox.Text.ToString());
            ArduinoSerial.saveSettings actual = new ArduinoSerial.saveSettings();

            actual = new ArduinoSerial.saveSettings(settingsName_tbox.Text.ToString(), Arduino.serialPort);

            /* Add serial port informations to list, then write to a file (and in this way, we can read) */
            //dataList.Add(actual);

            Jason.WriteToJsonFile(SettingsFolderPath + "/" + settingsName_tbox.Text.ToString() + ".settings", actual);

            settingsName_tbox.Text = string.Empty;
        }

        private void deleteSettings_btn_Click(object sender, EventArgs e)
        {
            if(settings_lbox.SelectedIndex > -1)
            {
                File.Delete(SettingsFolderPath + "/" + settings_lbox.SelectedItem.ToString() + ".settings");
                settings_lbox.Items.Remove(settings_lbox.SelectedItem);
            }
        }

        private void loadSettings_btn_Click(object sender, EventArgs e)
        {
            /* If one settings is active in list */
            if (settings_lbox.SelectedIndex >= 0)
            {
                /* Find this settings details in dataList and set serialport parameters for connection */
                foreach (ArduinoSerial.serialportData spData in dataList)
                {
                    /* If selected settings is in the list */
                    if (spData.dataName == settings_lbox.SelectedItem.ToString())
                    {
                        /* If the comport combobox not contain */
                        if (!comport_cbox.Items.Contains(spData.serialInformations.PortName))
                        {
                            /* Add this comport name and select */
                            comport_cbox.Items.Add(spData.serialInformations.PortName);
                            comport_cbox.SelectedIndex = comport_cbox.Items.Count - 1;
                        }
                        else
                        {
                            /* If it contain it, select */
                            comport_cbox.SelectedItem = spData.serialInformations.PortName;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose one settings from list.", "Error");
            }
        }
    }
}
