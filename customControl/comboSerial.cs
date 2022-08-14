using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace customControl
{
    public delegate void ComboSerialComm();  // delegate for read events
    public partial class comboSerial : UserControl
    {
        public SerialPort com ;
        public int baudrate=9600;
        public String log = "";
        string currentData = "";

        public event ComboSerialComm DataReceived; // event
        public comboSerial()
        {
            InitializeComponent();
            btnDisconnect.Enabled = false;
            com = new SerialPort();
            com.DataReceived += new SerialDataReceivedEventHandler(com_DataReceived);
        }

        private void com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ReadAndStoreData();
            DataReceived?.Invoke();
        }

        private void ReadAndStoreData()
        {
            try
            {
                int intBuffer;
                intBuffer = com.BytesToRead;
                byte[] byteBuffer = new byte[intBuffer];
                com.Read(byteBuffer, 0, intBuffer);
                currentData= com.ReadLine();
            }
            catch (Exception ex)
            {
                log = ex.Message;
            }
        }

        public String ReadData()
        {
            string data = "";
            try
            {
                int intBuffer;
                intBuffer = com.BytesToRead;
                byte[] byteBuffer = new byte[intBuffer];
                com.Read(byteBuffer, 0, intBuffer);
                data = com.ReadLine();
            }
            catch (Exception ex)
            {
                log = ex.Message;
            }
            return data;
            //return currentData;
        }




        public void setName(string name )
        {
            lbl.Text = lbl.Text + " " + name;
        }
        public void populateCombobox()
        {
            string[] ports = SerialPort.GetPortNames();
            cmbbx.Items.Clear();
            foreach (string port in ports)
            {
                cmbbx.Items.Add(port);
            }
        }

        private void connectCOM()
        {
            closeCOM();
            try
            {
                com.PortName = cmbbx.Text;
                com.BaudRate = baudrate;
                com.Parity = Parity.None;
                com.DataBits = 8;
                com.StopBits = StopBits.One;
                com.ReadTimeout = 2000;

                com.Open();
                btnDisconnect.Enabled = true;
                pnlLight.BackColor = Color.Lime;
                log = "Connected";

                // Enable Event Handler for receiveng data
                com.DataReceived += new SerialDataReceivedEventHandler(com_DataReceived);
            }
            catch (Exception ex)
            {
                log = ex.Message;
            }
        }

        


        public void closeCOM()
        {
            try
            {
                com.Close();
                btnDisconnect.Enabled = false;
                //writeLog("Stage Disconnected!");
                pnlLight.BackColor = Color.Gray;
                log = "Disconnected";
            }
            catch (Exception ex)
            {
                //writeLog(ex.Message);
                log = ex.Message;
            }
        }

        public void sendSerial(String text) {
            try
            {
                com.WriteLine(text);
                log = text;
            }
            catch (Exception ex)
            {
                log = ex.Message;
            }
        }


        public bool sendSerialFun(String text)
        {
            try
            {
                com.WriteLine(text);
                log = text;
                return true;
            }
            catch (Exception ex)
            {
                log = ex.Message;
                return false;
            }
        }

        private void cmbbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            connectCOM();
        }

        private void cmbbx_MouseClick(object sender, MouseEventArgs e)
        {
            populateCombobox();
        }

        // Destructor
        ~comboSerial()
        {
            closeCOM();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void baudrateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = baudrate.ToString();
            ShowInputDialogBox(ref input, "Enter the Baudrate", "Baudrate", 200, 80);
            try
            {
                baudrate = int.Parse(input);
            }
            catch (Exception)
            {

                
            }
        }
        private static DialogResult ShowInputDialogBox(ref string input, string prompt, string title = "Title", int width = 300, int height = 200)
        {
            //This function creates the custom input dialog box by individually creating the different window elements and adding them to the dialog box

            //Specify the size of the window using the parameters passed
            Size size = new Size(width, height);
            //Create a new form using a System.Windows Form
            Form inputBox = new Form();

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            //Set the window title using the parameter passed
            inputBox.Text = title;

            //Create a new label to hold the prompt
            Label label = new Label();
            label.Text = prompt;
            label.Location = new Point(5, 5);
            label.Width = size.Width - 10;
            inputBox.Controls.Add(label);

            //Create a textbox to accept the user's input
            TextBox textBox = new TextBox();
            textBox.Size = new Size(size.Width - 10, 23);
            textBox.Location = new Point(5, label.Location.Y + 20);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            //Create an OK Button 
            Button okButton = new Button();
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new Point(size.Width - 80 - 80, size.Height - 30);
            inputBox.Controls.Add(okButton);

            //Create a Cancel Button
            Button cancelButton = new Button();
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new Point(size.Width - 80, size.Height - 30);
            inputBox.Controls.Add(cancelButton);

            //Set the input box's buttons to the created OK and Cancel Buttons respectively so the window appropriately behaves with the button clicks
            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            //Show the window dialog box 
            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;

            //After input has been submitted, return the input value
            return result;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            closeCOM();
        }

        private void comboSerial_Load(object sender, EventArgs e)
        {

        }

        //   ################### Reading Serial #########################
        //Enable Event Handler
        
    }
}
