using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace Serial_Logger_Two_Port
{
    public partial class Main : Form
    {
        private byte _terminator = 0x4;

        Boolean newLine1 = false;
        Boolean newLine2 = false;
        Boolean autoscroll = false;
        Boolean autoscroll2 = false;
        Boolean saveLog1 = false;
        Boolean saveLog2 = false;
        Boolean savetime2 = false;
        Boolean savetime = false;
        string fileLog1 = "";
        string fileLog2 = "";
        string RxString;
        string RxString2;
        int byteToread;
       // char[] data;
        Boolean pc1 = false;
        Boolean pc2 = false;
        //TimeSpan TodayTime = ;
        public Main()
        {
            InitializeComponent();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            RxString = serialPort1.ReadExisting();
           // string data = serialPort1.ReadExisting();
           
            this.Invoke(new EventHandler(DisplayText));
            this.Invoke(new EventHandler(DisplayTimeLog));
            this.Invoke(new EventHandler(WriteFile)); //write File
            // Debug.Print(e.ToString());
        }
        private void serialPort2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            RxString2 = serialPort2.ReadExisting();
            // string data = serialPort1.ReadExisting();
            Console.Write(RxString2);
            this.Invoke(new EventHandler(DisplayText2));
            this.Invoke(new EventHandler(DisplayTimeLog2));
            this.Invoke(new EventHandler(WriteFile2)); //write File
            // Debug.Print(e.ToString());
        }
        public void WriteFile(object sender, EventArgs e)
        {
            string path = @fileLog1;
            // This text is added only once to the file.
            
            if (saveLog1)
            {
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        // sw.WriteLine("Welcome");
                    }
                }
                using (StreamWriter sw = File.AppendText(path))
                {
                    //   string clr = DecWrite().Replace("0A", "0\r\n");
                    if(savetime)
                        sw.Write("\r\nTime : " + GetTime() + " Value: ");

                    if (type1.SelectedIndex == 0)
                        sw.Write(RxString);
                    else if (type1.SelectedIndex == 1)
                        sw.Write(DecWrite());
                    else
                        sw.Write(HexWrite());

                    //sw.Write(HexWrite()); //Line same rishbox
                }
            }

        }
        public void WriteFile2(object sender, EventArgs e)
        {
            string path = @fileLog2;

            if (saveLog2)
            {
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                      
                    }
                }
                using (StreamWriter sw = File.AppendText(path))
                {
                    //   string clr = DecWrite().Replace("0A", "0\r\n");
                    if (savetime2)
                        sw.Write("\r\nTime : " + GetTime() + " Value: ");

                    if (type2.SelectedIndex == 0)
                        sw.Write(RxString2);
                    else if (type2.SelectedIndex == 1)
                        sw.Write(DecWrite2());
                    else
                        sw.Write(HexWrite2());

                }
            }

        }
        public string GetTime()
        {
            String timelog = DateTime.Now.ToString("HH:mm:ss.ff");
            return timelog;

        }
        public string HexWrite()
        {
            string hex = "";
            foreach (char c in RxString)
            {
                int tmp = c;
                hex += String.Format("{0:x2}", (uint)System.Convert.ToUInt32(tmp.ToString())) + " ";
            }
            if (newLine1)
                hex = hex.Replace("0a", "0a\r\n");

            return hex;
        }
        public string HexWrite2()
        {
            string hex = "";
            foreach (char c in RxString2)
            {
                int tmp = c;
                hex += String.Format("{0:x2}", (uint)System.Convert.ToUInt32(tmp.ToString())) + " ";
            }
            if (newLine2)
                hex = hex.Replace("0a", "0a\r\n");

            return hex;
        }
        public string DecWrite()
        {
            byte[] uni = Encoding.Unicode.GetBytes(RxString);
            string str = "";
            foreach (char x in uni)
            {
                if (Convert.ToUInt32(x) != 0 && Convert.ToUInt32(x) != 10)
                    str += (Convert.ToUInt32(x)).ToString() + " ";
                if (Convert.ToUInt32(x) == 10 && newLine1 == true)
                    str += "\r\n";
                else if (Convert.ToUInt32(x) == 10)
                    str += Convert.ToUInt32(x) + " ";
            }
            return str;
        }
        public string DecWrite2()
        {
            byte[] uni = Encoding.Unicode.GetBytes(RxString2);
            string str = "";
            foreach (char x in uni)
            {
                if (Convert.ToUInt32(x) != 0 && Convert.ToUInt32(x) != 10)
                    str += (Convert.ToUInt32(x)).ToString() + " ";
                if (Convert.ToUInt32(x) == 10 && newLine2 == true)
                    str += "\r\n";
                else if (Convert.ToUInt32(x) == 10)
                    str += Convert.ToUInt32(x) + " ";
            }
            return str;
        }
        private void DisplayText(object sender, EventArgs e)
        {
            if (type1.SelectedIndex == 0)
               Display1.AppendText(RxString);
            else if (type1.SelectedIndex == 1)
                Display1.AppendText(DecWrite());
            else
                Display1.AppendText(HexWrite());
        }
        private void DisplayText2(object sender, EventArgs e)
        {
            if (type2.SelectedIndex == 0)
                Display2.AppendText(RxString2);
            else if (type2.SelectedIndex == 1)
                Display2.AppendText(DecWrite2());
            else
                Display2.AppendText(HexWrite2());
        }
        private void DisplayTimeLog(object sender, EventArgs e)
        {
          //  String timelog = DateTime.Now.ToString("HH:mm:ss.ff"); //MM/dd/yyy 
            Timelog1.AppendText(GetTime() + "\n");
        }
        private void DisplayTimeLog2(object sender, EventArgs e)
        {
            //  String timelog = DateTime.Now.ToString("HH:mm:ss.ff"); //MM/dd/yyy 
            Timelog2.AppendText(GetTime() + "\n");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshportList();
            RefreshportList2();
            comBobox();
          //  Display1.Text = "";
        }
        public void RefreshportList()
        {
            string[] ports = SerialPort.GetPortNames();
            Boolean seePort = false;
            Port1.Items.Clear();
            foreach (string port in ports)
            {
                Port1.Items.Add(port);
                seePort = true;
            }
            if(seePort)
                Port1.SelectedIndex = 0;
        }
        public void RefreshportList2()
        {
            string[] ports = SerialPort.GetPortNames();
            Boolean seePort = false;
            Port2.Items.Clear();
            foreach (string port in ports)
            {
                Port2.Items.Add(port);
                seePort = true;
            }
            if (seePort)
                Port2.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ConnectP1();
        }
        public void ConnectP1()
        {
            try
            {
                if (!pc1)
                {
                    // serialPort1 = null;

                    serialPort1.PortName = Port1.Text;
                    serialPort1.BaudRate = int.Parse(buadrate1.Text);
                    serialPort1.Open();
                    if (serialPort1.IsOpen)
                    {
                        Debug.Print("Connected");
                        ChangeStatus1(0);
                        
                    }
                }
                else
                {
                    serialPort1.DiscardInBuffer();
                    serialPort1.Close();
                    ChangeStatus1(1);
                }
               // serialPort1.DiscardOutBuffer();
            }
            catch (System.InvalidOperationException ex)
            {
                ChangeStatus1(1);
                MessageBox.Show("กรุณาตรวจสอบพอร์ตอีกครั้ง");
            }
            catch (System.IO.IOException ex)
            {
                ChangeStatus1(1);
                MessageBox.Show("กรุณาเชื่อมต่อพอร์ตอีกครั้ง");
            }catch(System.ArgumentException ex)
            {
                ChangeStatus1(1);
                MessageBox.Show("ไม่พบพอร์ตที่ต้องการเชื่อมต่อ");
            }
            catch (System.UnauthorizedAccessException ex)
            {
                ChangeStatus1(1);
                MessageBox.Show("พอร์ต "+ Port1.Text+" มีการใช้งานอยู่");
            }
        }
        public void ConnectP2()
        {
            try
            {
                if (!pc2)
                {
                    // serialPort1 = null;

                    serialPort2.PortName = Port2.Text;
                    serialPort2.BaudRate = int.Parse(buadrate2.Text);
                    serialPort2.Open();
                    if (serialPort2.IsOpen)
                    {
                        Debug.Print("Connected");
                        ChangeStatus2(0);

                    }
                }
                else
                {
                    serialPort2.DiscardInBuffer();
                    serialPort2.Close();
                    ChangeStatus2(1);
                }
                // serialPort1.DiscardOutBuffer();
            }
            catch (System.InvalidOperationException ex)
            {
                ChangeStatus2(1);
                MessageBox.Show("กรุณาตรวจสอบพอร์ตอีกครั้ง");
            }
            catch (System.IO.IOException ex)
            {
                ChangeStatus2(1);
                MessageBox.Show("กรุณาเชื่อมต่อพอร์ตอีกครั้ง");
            }
            catch (System.ArgumentException ex)
            {
                ChangeStatus2(1);
                MessageBox.Show("ไม่พบพอร์ตที่ต้องการเชื่อมต่อ");
            }
            catch (System.UnauthorizedAccessException ex)
            {
                ChangeStatus2(1);
                MessageBox.Show("พอร์ต " + Port2.Text + " มีการใช้งานอยู่");
            }
        }
        public void comBobox()
        {
            buadrate1.SelectedIndex = 3;
            buadrate2.SelectedIndex = 3;
            type1.SelectedIndex = 0;
            type2.SelectedIndex = 0;
            typeS1.SelectedIndex = 0;
            typeS2.SelectedIndex = 0;
            //ComboboxItem item = new ComboboxItem();
            // item.Text = "Item text1";
            //item.Value = 12;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void ChangeStatus1(int num)
        {
            if (num == 1)
            {
                statusSerial1.BackgroundImage = Serial_Logger_Two_Port.Resource1.discon;
                Connect1.Text = "Connect";
                Connect1.BackColor = Color.FromArgb(244, 67, 54);
                pc1 = false;
                buadrate1.Enabled = true;
                refreshBtn1.Enabled = true;
                Port1.Enabled = true;
            }
            else
            {
                Connect1.Text = "Connected";
                Connect1.BackColor = Color.FromArgb(63, 255, 99);
                pc1 = true;
                statusSerial1.BackgroundImage = Serial_Logger_Two_Port.Resource1.con;
                buadrate1.Enabled = false;
                refreshBtn1.Enabled = false;
                Port1.Enabled = false;
            }
        }
        private void ChangeStatus2(int num)
        {
            if (num == 1)
            {
                statusSerial2.BackgroundImage = Serial_Logger_Two_Port.Resource1.discon;
                Connect2.Text = "Connect";
                Connect2.BackColor = Color.FromArgb(244, 67, 54);
                pc2 = false;
                buadrate2.Enabled = true;
                refreshBtn2.Enabled = true;
                Port2.Enabled = true;
            }
            else
            {
                Connect2.Text = "Connected";
                Connect2.BackColor = Color.FromArgb(8, 205, 252);
                pc2 = true;
                statusSerial2.BackgroundImage = Serial_Logger_Two_Port.Resource1.con2;
                buadrate2.Enabled = false;
                refreshBtn2.Enabled = false;
                Port2.Enabled = false;
            }
        }

        private void newlineChbox_CheckStateChanged(object sender, EventArgs e)
        {
            if (newlineChbox1.Checked)
                newLine1 = true;
            else
                newLine1 = false;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            RefreshportList();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Timelog2.SelectionStart = Timelog2.Text.Length;
            Timelog2.ScrollToCaret();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display1.Clear();
        }

        private void Display1_TextChanged(object sender, EventArgs e)
        {
            if (autoscroll)
            {
                Display1.SelectionStart = Display1.Text.Length;
                Display1.ScrollToCaret();
            }
        }

        private void Autoscroll_CheckStateChanged(object sender, EventArgs e)
        {
            if(Autoscroll1.Checked)
                 autoscroll = true;
            else
                autoscroll = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // SaveLog1.o();
           
            SaveLog1.InitialDirectory = "c:";
            SaveLog1.Title = "Save as Excel File";
            SaveLog1.FileName = "";
            SaveLog1.Filter = "Text File|*.txt";
            if (SaveLog1.ShowDialog() != DialogResult.Cancel)
            {
                // SaveLog1.FileName.ToString();
                fileLog1 = SaveLog1.FileName.ToString();
                LocationLink1.Text = fileLog1;
                SavelogBtn1.Text = "Saving Log";
                StopSave1.Enabled = true;
                saveTime1.Enabled = true;
                SavelogBtn1.BackColor = Color.FromArgb(137, 255, 142);
                saveLog1 = true;
            }
        }

        private void saveTime_CheckedChanged(object sender, EventArgs e)
        {
            if (saveTime1.Checked)
                savetime = true;
            else
                savetime = false;
        }

        private void LocationLink_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", fileLog1);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SavelogBtn1.BackColor = Color.FromArgb(255, 229, 137);
            SavelogBtn1.Text = "Save Log";
            saveLog1 = false;
            //fileLog1 = "";
            StopSave1.Enabled = false;
            saveTime1.Enabled = false;
            //LocationLink.Text = "Null";
        }

        private void clear2_Click(object sender, EventArgs e)
        {
            Display2.Clear();
        }

        private void refreshBtn2_Click(object sender, EventArgs e)
        {
            RefreshportList2();
        }

        private void Connect2_Click(object sender, EventArgs e)
        {
            ConnectP2();
        }

        private void refreshBtn1_Click(object sender, EventArgs e)
        {
            RefreshportList();
        }

        private void SavelogBtn2_Click(object sender, EventArgs e)
        {

            SaveLog2.InitialDirectory = "c:";
            SaveLog2.Title = "Save as Excel File";
            SaveLog2.FileName = "";
            SaveLog2.Filter = "Text File|*.txt";
            if (SaveLog2.ShowDialog() != DialogResult.Cancel)
            {
                // SaveLog1.FileName.ToString();
                fileLog2 = SaveLog2.FileName.ToString();
                LocationLink2.Text = fileLog2;
                SavelogBtn2.Text = "Saving Log";
                StopSave2.Enabled = true;
                saveTime2.Enabled = true;
                SavelogBtn2.BackColor = Color.FromArgb(137, 255, 142);
                saveLog2 = true;
            }
        }

        private void StopSave2_Click(object sender, EventArgs e)
        {
            SavelogBtn2.BackColor = Color.FromArgb(255, 229, 137);
            SavelogBtn2.Text = "Save Log";
            saveLog2 = false;
            //fileLog1 = "";
            StopSave2.Enabled = false;
            saveTime2.Enabled = false;
            //LocationLink.Text = "Null";
        }

        private void LocationLink1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LocationLink2_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", fileLog2);
        }

        private void saveTime2_CheckedChanged(object sender, EventArgs e)
        {
            if (saveTime2.Checked)
                savetime2 = true;
            else
                savetime2 = false;
        }

        private void newlineChbox2_CheckStateChanged(object sender, EventArgs e)
        {
            if (newlineChbox2.Checked)
                newLine2 = true;
            else
                newLine2 = false;
        }

        private void Autoscroll2_CheckStateChanged(object sender, EventArgs e)
        {
            if (Autoscroll2.Checked)
                autoscroll2 = true;
            else
                autoscroll2 = false;
        }

        private void Display2_TextChanged(object sender, EventArgs e)
        {
            if (autoscroll2)
            {
                Display2.SelectionStart = Display2.Text.Length;
                Display2.ScrollToCaret();
            }
        }

        private void Timelog1_TextChanged(object sender, EventArgs e)
        {
            Timelog1.SelectionStart = Timelog1.Text.Length;
            Timelog1.ScrollToCaret();
        }

        private void clear1_Click(object sender, EventArgs e)
        {
            Display1.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SendP1();
        }
        public void SendP1()
        {
            try
            {
                serialPort1.Write(inputSerial1.Text);
               
                if (typeS1.SelectedIndex == 1)
                    serialPort1.Write("\n");
                else if (typeS1.SelectedIndex == 2)
                    serialPort1.Write("\r");
                else if (typeS1.SelectedIndex == 3)
                    serialPort1.Write("\r\n");
                inputSerial1.Clear();
            }
            catch (Exception ex)
            {
                ChangeStatus1(1);
                MessageBox.Show("กรุณาตรวจสอบการเชื่อมต่อ");
                
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Display2.Clear();
        }
        public void SendP2()
        {
            try
            {
                serialPort2.Write(inputSerial2.Text);

                if (typeS2.SelectedIndex == 1)
                    serialPort2.Write("\n");
                else if (typeS2.SelectedIndex == 2)
                    serialPort2.Write("\r");
                else if (typeS2.SelectedIndex == 3)
                    serialPort2.Write("\r\n");
                inputSerial2.Clear();
            }
            catch (Exception ex)
            {
                ChangeStatus2(1);
                MessageBox.Show("กรุณาตรวจสอบการเชื่อมต่อ");
            }

        }

        private void sendP2(object sender, EventArgs e)
        {
            SendP2();
        }

        private void inputSerial1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendP1();
            }
        }

        private void inputSerial2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendP2();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Close this", "คุณต้องจากโปรแกรมใช่ไหม",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);
        }
    }
}
