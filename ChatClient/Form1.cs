using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChatClient
{
    public partial class FormP : Form
    {

        static private NetworkStream stream;
        static private StreamWriter streamW;
        static private StreamReader streamR;
        static private TcpClient client = new TcpClient();
        static private string nick = "unknown";

        public object ListBox1 { get; private set; }

        private delegate void DaddItem(string s);


        private void addItem(String s)
        {
            listBox1.Items.Add(s);        
        }

        public FormP()
        {
            InitializeComponent();
        }
        void Listen()
        {
            while (client.Connected)
            {
                try
                {
                    this.Invoke(new DaddItem(addItem), streamR.ReadLine());
                }
                catch
                {
                    MessageBox.Show("Could not connect to the server!");
                    Application.Exit();
                }
            }
        }

        void Connect()
        {
            try
            {
                client.Connect("127.0.0.1", 8000);
                if (client.Connected)
                {
                    Thread t = new Thread(Listen);

                    stream = client.GetStream();
                    streamW = new StreamWriter(stream);
                    streamR = new StreamReader(stream);

                    streamW.WriteLine(nick);
                    streamW.Flush();

                    t.Start();

                    toolStripStatusLabelStatus.Text = "Status: Connected";
                    toolStripStatusLabelServer.Text = "Server: Online";
                    button_send.Enabled = true;

                    buttonChanceNick.Visible = true;
                    button_Connect.Enabled = false;
                    Size = new Size(485, 368);

                }
                else
                {
                    MessageBox.Show("Server not available!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Server not available!");
                Application.Exit();
            }



        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_send_Click(object sender, EventArgs e)
        {           
            streamW.WriteLine(textBoxTextToSend.Text);
            streamW.Flush();
            textBoxTextToSend.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] malePetNames = { "Rufus", "Bear", "Dakota", "Fido",
                          "Vanya", "Samuel", "Koani", "Volodya",
                          "Prince", "Yiska" };


            nick = textBoxNickName.Text;

            if (nick == "")
            {
                int mIndex = rnd.Next(malePetNames.Length);               
                nick = malePetNames[mIndex];
                textBoxNickName.Text = nick;
            }
            Connect();
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            Size = new Size(738, 368);
            buttonConfig.Enabled = false;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Size = new Size(485, 368);
            buttonConfig.Enabled = true;
        }

        private void buttonChanceNick_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            string[] malePetNames = { "Rufus", "Bear", "Dakota", "Fido",
                          "Vanya", "Samuel", "Koani", "Volodya",
                          "Prince", "Yiska" };


            nick = textBoxTextToSend.Text;

            if (nick == "")
            {
                int mIndex = rnd.Next(malePetNames.Length);
                nick = malePetNames[mIndex];
                
            }

            streamW.WriteLine("ChangeNameConfig="+ nick);
            streamW.Flush();
            
        }
    }
}
