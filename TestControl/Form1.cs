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
using System.Text.RegularExpressions;

namespace TestControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboSerial1.baudrate = 115200;

            // Add the Event Handler for the comboSerial1 object
            comboSerial1.DataReceived += new customControl.ComboSerialComm(comboSerial1_DataReceived);
            //comboSerial1.com.DataReceived += new SerialDataReceivedEventHandler(dataReceived);

        }

        private void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String recv = comboSerial1.ReadData();
            //label1.Text = recv;
            SetText(recv);
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.label1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.label1.Text = formatString( text);
            }
        }

        private void comboSerial1_DataReceived()
        {

            String recv = comboSerial1.ReadData();
            //label1.Text = recv;
            SetText(recv);
        }

        private void comboSerial1_Load(object sender, EventArgs e)
        {

        }

        public String formatString(string text)
        {
            string ret = "";

            text = Regex.Replace(text, @"\s+", "");
            text = text.Replace("||", ",");
            String[] parts = text.Split(',');
            string counts = parts[0];
            string dose = parts[1];
            ret = "Counts = " + counts + " CMP;   Dose = " + dose+" uSvh";
            return ret;

        }
    }
}
