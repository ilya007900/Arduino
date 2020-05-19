using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Arduino
{
    public partial class Form1 : Form
    {
        private const string OnCommand = "ON";
        private const string OffCommand = "OFF";

        private const string InitCommand = "Basler_arduino_init";
        private const string IRLEDSwitchCommand = "LEDA";
        private const string BlueLedSwitchCommand = "LEDB";
        private const string PWMSetCommand = "PWMB";
        private const string LEDNSwitchCommad = "LED";
        private const string EnableCommand = "ENBL";
        private const string StopCommand = "STOP";

        private const string ConnectSuccessCommand = "Basler_helmet_arduin";
        private const string DoneCommand = "Done!";


        private SerialPort SerialPort { get; set; }

        public Form1()
        {
            InitializeComponent();
            var ports = SerialPort.GetPortNames();
            PortsComboBox.Items.AddRange(ports);
        }

        private void RefreshPortsButton_Click(object sender, EventArgs e)
        {
            var ports = SerialPort.GetPortNames();
            PortsComboBox.Items.Clear();
            PortsComboBox.Items.AddRange(ports);
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            var portName = PortsComboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(portName))
            {
                throw new Exception("Port not selected");
            }

            SerialPort = new SerialPort(portName, 9600, Parity.None, 8, StopBits.One);
            SerialPort.Open();
            SerialPort.DataReceived += SerialPort_DataReceived;
            SendCommand(InitCommand);
            SerialPort.Write(InitCommand);

            ConnectButton.Enabled = false;
            DisconnectButton.Enabled = true;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var data = SerialPort.ReadLine();
            ReceivedCommandsList.Items.Add(data);
            ReceivedCommandsList.SelectedIndex = ReceivedCommandsList.Items.Count - 1;
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            SerialPort.DataReceived -= SerialPort_DataReceived;
            SerialPort.Close();

            ConnectButton.Enabled = true;
            DisconnectButton.Enabled = false;
        }

        private void SendCommand(string command)
        {
            if (SerialPort == null)
            {
                throw new Exception("Port not selected");
            }

            if (!SerialPort.IsOpen)
            {
                throw new Exception("Port is not open");
            }

            SentCommandsList.Items.Add(command);
            SentCommandsList.SelectedIndex = SentCommandsList.Items.Count - 1;
            SerialPort.Write(command);
        }

        private void IRLed1OnButton_Click(object sender, EventArgs e)
        {
            var command = GetLedNSwitchCommand(1, true);
            SendCommand(command);
            IRLed1OnButton.Enabled = false;
            IRLed1OffButton.Enabled = true;
        }

        private void IRLed1OffButton_Click(object sender, EventArgs e)
        {
            var command = GetLedNSwitchCommand(1, false);
            SendCommand(command);
            IRLed1OnButton.Enabled = true;
            IRLed1OffButton.Enabled = false;
        }

        private void BlueLed1OnButton_Click(object sender, EventArgs e)
        {
            var command = GetLedNSwitchCommand(2, true);
            SendCommand(command);
            BlueLed1OnButton.Enabled = false;
            BlueLed1OffButton.Enabled = true;
        }

        private void BlueLed1OffButton_Click(object sender, EventArgs e)
        {
            var command = GetLedNSwitchCommand(2, false);
            SendCommand(command);
            BlueLed1OnButton.Enabled = true;
            BlueLed1OffButton.Enabled = false;
        }

        private void SendPWMButton_Click(object sender, EventArgs e)
        {
            var pwm = PWMTextBox.Text;
            if (!byte.TryParse(pwm, out var result))
            {
                throw new Exception($"{pwm} is not byte number (0-255)");
            }

            var command = PWMSetCommand + result.ToString();
            SendCommand(command);
        }

        private static string GetLedNSwitchCommand(int index, bool flag)
        {
            var command = LEDNSwitchCommad + index.ToString();
            var commandWithFlag = GetCommandWithFlag(command, flag);
            return commandWithFlag;
        }

        private static string GetCommandWithFlag(string command, bool flag)
        {
            return command + (flag ? OnCommand : OffCommand);
        }
    }
}
