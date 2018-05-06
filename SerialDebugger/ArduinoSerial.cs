using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialDebugger
{
    
    public class ArduinoSerial
    {
        public SerialPort serialPort = new SerialPort();

        public void ArduinoDefaults(ComboBox baud, ComboBox dataBit, ComboBox parity, ComboBox stopBit)
        {
            baud.Items.AddRange(new string[] { "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "28800", "38400", "57600", "115200" });
            dataBit.Items.AddRange(new string[] { "5", "6", "7", "8", "9" });
            parity.Items.AddRange(new string[] { "None", "Odd", "Even", "Mark", "Space" });
            stopBit.Items.AddRange(new string[] { "None", "One", "Two", "OnePointFive" });

            baud.SelectedIndex = 5;
            dataBit.SelectedIndex = 3;
            parity.SelectedIndex = 0;
            stopBit.SelectedIndex = 1;
        }

        public string[] AvailablePorts()
        {
            string[] portNames;

            portNames = SerialPort.GetPortNames();

            return portNames;
        }

        public void SetSerialPort(ComboBox portName, ComboBox baud, ComboBox dataBit, ComboBox parity, ComboBox stopBit)
        {
            try
            {
                serialPort.PortName = portName.SelectedItem.ToString();
                serialPort.BaudRate = Convert.ToInt32(baud.SelectedItem.ToString());
                serialPort.DataBits = Convert.ToInt32(dataBit.SelectedItem.ToString());

                switch(parity.SelectedItem.ToString())
                {
                    case "None":
                        serialPort.Parity = Parity.None;
                        break;
                    case "Odd":
                        serialPort.Parity = Parity.Odd;
                        break;
                    case "Even":
                        serialPort.Parity = Parity.Even;
                        break;
                    case "Mark":
                        serialPort.Parity = Parity.Mark;
                        break;
                    case "Space":
                        serialPort.Parity = Parity.Space;
                        break;
                }

                switch (stopBit.SelectedItem.ToString())
                {
                    case "None":
                        serialPort.StopBits = StopBits.None;
                        break;
                    case "One":
                        serialPort.StopBits = StopBits.One;
                        break;
                    case "Two":
                        serialPort.StopBits = StopBits.Two;
                        break;
                    case "OnePointFive":
                        serialPort.StopBits = StopBits.OnePointFive;
                        break;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Serial Port error");
            }
        }

    }
}
