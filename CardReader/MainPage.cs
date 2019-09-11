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
using System.Data.SqlClient;
using System.IO;
namespace CardReader
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlConnection con;

        private void MainPage_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-JC7B9JP;Initial Catalog=db_KimlikTanimlama;User ID=sa; password=ahmtozdncr1748");
            cmd = new SqlCommand();
            con.Open();
            MessageBox.Show("Veritabanıyla Bağlantı kuruldu.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetPortNames(); //Port İsimleri Gelicek
            GetBaudRates(); //Bant Genişliği geliyor
            Control.CheckForIllegalCrossThreadCalls = false;

        }
        private void GetPortNames()
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
        }
        private void GetBaudRates()
        {
            comboBox2.Items.Add("300");
            comboBox2.Items.Add("1200");
            comboBox2.Items.Add("2400");
            comboBox2.Items.Add("9600");
            comboBox2.Items.Add("4800");
            comboBox2.Items.Add("14400");
            comboBox2.Items.Add("19200");
            comboBox2.Items.Add("28800");
            comboBox2.Items.Add("38400");
            comboBox2.Items.Add("57600");
            comboBox2.Items.Add("115200");
            comboBox2.Items.Add("230400");
        }
        private void OpenConnection()
        {
            if (!serialPort1.IsOpen)
            {
                if (comboBox1.Text == "")
                    serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = int.Parse(comboBox2.Text);
                try
                {
                    string[] pport = SerialPort.GetPortNames();
                    foreach (string port in pport)
                    {
                        serialPort1.Open();
                    }
                    MessageBox.Show("Kart Okuyucuya başarılı bir şekilde Bağlanıldı.");
                    button1.Enabled = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
            private void CloseConnection()
        {
            serialPort1.Close();
            button1.Enabled = true;
            button2.Enabled = false;
            MessageBox.Show("Kart Okuyucu ile bağlantı kesildi.");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CloseConnection();
        }
    private void kayıtlarıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayitGoruntule kayitshow = new KayitGoruntule();
            this.Hide();
            kayitshow.Show();
        }
       
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Station szCANData;

            //String szData ="";
            int nBytesToRead = serialPort1.BytesToRead;
            byte[] szBuff = new byte[nBytesToRead];
            //string szCOM= serialPort1.ReadExisting();
            //szData += serialPort1.ReadExisting();
            //ProcessBuffer(szData);
            serialPort1.Read(szBuff, 0, nBytesToRead);
            
            szCANData.StationID = szBuff[0];
            szCANData.StationCMD = szBuff[1];
            szCANData.StationMSG0 = szBuff[2];
            szCANData.StationMSG1 = szBuff[3];
            szCANData.StationMSG2 = szBuff[4];
            szCANData.StationMSG3 = szBuff[5];
            szCANData.StationMSG4 = szBuff[6];
            szCANData.StationMSG5 = szBuff[7];
            szCANData.StationMSG6 = szBuff[8];
            szCANData.StationMSG7 = szBuff[9];
            szCANData.EOD = szBuff[10];
        }
    }   
    }