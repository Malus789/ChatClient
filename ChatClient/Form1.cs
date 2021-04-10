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

        //LogChat
        string logFull;

        //Dictionary Test
        Dictionary<string, string> DictionaryData = new Dictionary<string, string>();

        string[] FileListServer = new string[100];
        string[] FileListClient = new string[100];

        string[] FileListDone = new string[100];
        string[] FileListClientNeed = new string[100];
        string[] FileListServerNeed = new string[100];
        private void addItem(String s)
        {
            listBox1.Items.Add(s);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;

            string tmp = s;
            int tmpPosition = tmp.IndexOf("=");
            if (tmpPosition != -1)
            {
                string findW = tmp.Substring(0, tmpPosition);

                if (findW == "FileList")
                {
                    string findWP = tmp.Substring(tmpPosition + 1);
                    MessageBox.Show(findWP);
                    String[] result = findWP.Split('=');
                    
                    for (int n = 0; n < result.Length; n++)
                    {
                        FileListServer[n] = result[n];
                        treeViewFilesServer.Nodes.Add(result[n]);
                    }


                    
                }
                //Log test

                //LogManager("addLog", s);

                //Dictionary Test
                // DictionaryMain("AddItem","ChatReciente",s);
                // DictionaryMain("ReadItem", "ChatReciente", "");
            }
        }
        private void DictionaryMain(string Order, string key, string value)
        {
            if (Order == "AddItem")
            {
                DictionaryData.Remove(key);
                DictionaryData.Add(key, value);               
            }
            if (Order == "ReadItem")
            {          
               // Console.WriteLine(DictionaryData[key]);
                MessageBox.Show(DictionaryData[key]);
            }

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
                {//create rules about this error
                    /*MessageBox.Show("Could not connect to the server! 3");
                    Application.Exit();*/
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

                    ChanceFormSize("size1");
                    ChanceFormSize("ConnectedMode");
                }
                else
                {
                    MessageBox.Show("Server not available! 1");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server not available!, try later...");
                ChanceFormSize("DisconectedMode");
                ChanceFormSize("size2");
            }
        }

        private void Connect_FuncB(string textBoxNickName)
        {
            Random rnd = new Random();
            string[] malePetNames = { "Rufus", "Bear", "Dakota", "Fido",
                          "Vanya", "Samuel", "Koani", "Volodya",
                          "Prince", "Yiska" };

            nick = textBoxNickName;

            if (nick == "")
            {
                int mIndex = rnd.Next(malePetNames.Length);
                nick = malePetNames[mIndex];
                textBoxNickName = nick;
            }
            Connect();
        }

        private void ChanceNick(string textBoxTextToSendt)
        {
            Random rnd = new Random();
            string[] malePetNames = { "Rufus", "Bear", "Dakota", "Fido",
                          "Vanya", "Samuel", "Koani", "Volodya",
                          "Prince", "Yiska" };

            nick = textBoxTextToSendt;

            if (nick == "")
            {
                int mIndex = rnd.Next(malePetNames.Length);
                nick = malePetNames[mIndex];
            }

            streamW.WriteLine("ChangeNickConfig=" + nick);
            textBoxNickName.Text = nick;
            streamW.Flush();

        }

        private void MessagePrivate(string textBoxTextToSendt, string destination)
        {
            //make message Private Function
            //thinking...
            Random rnd = new Random();
            string[] Words = { "Hi", "Hello", "How are you?" };
            string textToSend = textBoxTextToSendt;         
            if (textToSend == "")
            {
                int mIndex = rnd.Next(Words.Length);
                textToSend = Words[mIndex];
            }          
            streamW.WriteLine("MessagePrivate=" + destination+" <"+ textToSend);
            textBoxNickName.Text = nick;
            streamW.Flush();        
        }

        private void SendMessage(string textBoxText)
        {
            try
            {
                streamW.WriteLine(textBoxText);
                streamW.Flush();
                textBoxTextToSend.Clear();
            }

            catch
            {
                MessageBox.Show("The server was disconnected...");
                ChanceFormSize("DisconectedMode");
                ChanceFormSize("size2");
            }

        }

        private void ChanceFormSize(string state)
        {
            if (state == "size1")
            {
                Size = new Size(468, 528);
                buttonConfig.Enabled = true;

            } else
            if (state == "size2")
            {
                Size = new Size(718, 528);
                buttonConfig.Enabled = false;
            } else

            if (state == "DisconectedMode")
            {
                button_Connect.Enabled = true;
                button_send.Enabled = false;
                buttonMessagePrivate.Enabled = false;
                buttonChanceNick.Visible = false;
                toolStripStatusLabelStatus.Text = "Status: Offline";
                toolStripStatusLabelServer.Text = "Server: 0";

            } else

            if (state == "ConnectedMode")
            {
                button_Connect.Enabled = false;
                buttonMessagePrivate.Enabled = true;
                buttonChanceNick.Visible = true;           
                button_send.Enabled = true;
                buttonGo.Enabled = true;
                toolStripStatusLabelStatus.Text = "Status: Connected";
                toolStripStatusLabelServer.Text = "Server: Online";              
            }

        }

        public void LogManager(string order, string ItemToAdd)
        {
            if (order == "addLog")
            {
                logFull = logFull + "\n" + ItemToAdd;
                SaveData(nick + " cliente.txt", logFull );
            }
        }

        public void SaveData(string Filename, string contentToSave)
        {
            StreamWriter streamWrite = new StreamWriter(Filename);
            streamWrite.WriteLine(contentToSave);
            streamWrite.Close();
            Console.WriteLine("File done");
        }

        public string LoadData(string Filename)
        {
            StreamReader streamRead = new StreamReader(Filename);
            string Data = streamRead.ReadLine();
            Console.WriteLine("File done");
            return Data;
        }

        //
        string rootP;
        string LocalFiles;
        private TreeNode NewTree(DirectoryInfo directoryInfo)
        {
            TreeNode treeNodeP = new TreeNode(directoryInfo.Name);

            foreach (var item in directoryInfo.GetDirectories())
            {
                //recursive (llamamos a la misma funcion)
                treeNodeP.Nodes.Add(NewTree(item));
            }

            foreach (var item in directoryInfo.GetFiles())
            {
                treeNodeP.Nodes.Add(new TreeNode(item.FullName));
                LocalFiles = LocalFiles + "=" + item.FullName;
            }                 

            return treeNodeP;
        }

        private void LoadTreeView(string rootBase)
        {
            treeViewFile.Nodes.Clear();
            DirectoryInfo directoryinfo = new DirectoryInfo(rootBase);
            treeViewFile.Nodes.Add(NewTree(directoryinfo));

            //start list
            String[] result2 = LocalFiles.Split('=');

            for (int n = 0; n < result2.Length; n++)
            {
                FileListClient[n] = result2[n];
            }

            //MessageBox.Show(FileListClient[1]);
            streamW.WriteLine("NeedFileList=" + " <");
            streamW.Flush();

        }

        private void StartList(string[]FileListClient)
        {         
            ComparateList(FileListClient, FileListServer, FileListDone, FileListClientNeed, FileListServerNeed, 10);
        }

        private void ComparateList(string []FilesClient, string []FilesServer, string[] ResultFilesDone, string[] ResultFilesClientNeed, string[] ResultFilesServerNeed, int times)
        {
            int counterDone = 0;
            int counterClientNeed = 0;
            int counterServerNeed = 0;
            
            for (int n = 1; n<times; n++)
            {          
                int pos = Array.IndexOf(FilesServer, FilesClient[n]);
               
                if (pos > -1)
                {
                    //MessageBox.Show("We find the file: " + FilesClient[n] + " in FilesServer");
                    ResultFilesDone[counterDone] = FilesClient[n];
                    counterDone++;
                    //return true;
                }
                else
                {
                    ResultFilesServerNeed[counterServerNeed] = FilesClient[n];
                    counterServerNeed++;
                   // MessageBox.Show("We could not find the file: " + FilesClient[n] + " in FilesServer");
                    //return false;
                }
            }

            for (int n2 = 1; n2 < times; n2++)
            {
                int pos = Array.IndexOf(FilesClient, FilesServer[n2]);

                if (pos > -1)
                {
                    //MessageBox.Show("We find the file: " + FilesServer[n2] + " in FilesClient");
                    ResultFilesDone[counterDone] = FilesServer[n2];
                    counterDone++;
                    //return true;
                }
                else
                {
                    ResultFilesClientNeed[counterClientNeed] = FilesServer[n2];
                    counterClientNeed++;
                  // MessageBox.Show("We could not find the file: " + FilesServer[n2] + " in FilesClient");
                    
                    //return false;

                }
            }


            richTextBox1.Text = "Server need this File: " +
                                 ResultFilesServerNeed[0] + "\n\r" + "The client need this File: " + ResultFilesClientNeed[0] + "\n\r" +
                                 "Done: " + ResultFilesDone[0];
            ;

            /*for (int n2 = 1; n2<FilesServer.Length; n2++)
            {
                if (FilesClient[n] == FilesServer[n2])
                {
                    MessageBox.Show("el archivo del cliente: " + FilesClient[n] + " esta en el servidor" + FilesServer[n2]);
                    ResultFilesDone[counterDone] = FilesClient[n];
                    counterDone++;
                }
                else

                if (FilesClient[n] != FilesServer[n2])
                {
                    MessageBox.Show("el archivo del cliente: " + FilesClient[n] + " NO esta en el este index del servidor" + FilesServer[n2]);
                }
                    MessageBox.Show("el archivo " + FilesClient[n] + " se compara " + FilesServer[n2]);                
            }
*/

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_send_Click(object sender, EventArgs e)
        {
            SendMessage(textBoxTextToSend.Text);          
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            Connect_FuncB(textBoxNickName.Text);
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            ChanceFormSize("size2");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ChanceFormSize("size1");
        }

        private void buttonChanceNick_Click(object sender, EventArgs e)
        {
            ChanceNick(textBoxNickName.Text);
            
        }

        private void textBoxTextToSend_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_send_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBoxTextToSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SendMessage(textBoxTextToSend.Text);
            }
        }

        private void buttonMessagePrivate_Click(object sender, EventArgs e)
        {
            MessagePrivate(textBoxMessagePrivate.Text, comboBoxMessagePrivate.Text);
        }

        private void listBox1_MouseEnter(object sender, EventArgs e)
        {         
           
         
        }

        private void FormP_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            LoadTreeView(textBoxRoot.Text);
            //toolStripStatusLabel1.Text = textBoxRoot.Text;
        }

        private void buttonNeedList_Click(object sender, EventArgs e)
        {
            StartList(FileListClient);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void treeViewFile_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
