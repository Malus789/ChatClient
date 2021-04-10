
namespace ChatClient
{
    partial class FormP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormP));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_send = new System.Windows.Forms.Button();
            this.textBoxTextToSend = new System.Windows.Forms.TextBox();
            this.statusStripP = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonChanceNick = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Connect = new System.Windows.Forms.Button();
            this.textBoxNickName = new System.Windows.Forms.TextBox();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.buttonHideConfig = new System.Windows.Forms.Button();
            this.groupBoxPrivateMessage = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMessagePrivate = new System.Windows.Forms.ComboBox();
            this.buttonMessagePrivate = new System.Windows.Forms.Button();
            this.textBoxMessagePrivate = new System.Windows.Forms.TextBox();
            this.textBoxRoot = new System.Windows.Forms.TextBox();
            this.treeViewFile = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.treeViewFilesServer = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.statusStripP.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxPrivateMessage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(605, 484);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(313, 50);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseEnter += new System.EventHandler(this.listBox1_MouseEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_send);
            this.groupBox1.Controls.Add(this.textBoxTextToSend);
            this.groupBox1.Location = new System.Drawing.Point(936, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 61);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // button_send
            // 
            this.button_send.Enabled = false;
            this.button_send.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_send.Location = new System.Drawing.Point(207, 21);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(88, 32);
            this.button_send.TabIndex = 3;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // textBoxTextToSend
            // 
            this.textBoxTextToSend.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTextToSend.Location = new System.Drawing.Point(6, 21);
            this.textBoxTextToSend.Name = "textBoxTextToSend";
            this.textBoxTextToSend.Size = new System.Drawing.Size(195, 26);
            this.textBoxTextToSend.TabIndex = 2;
            this.textBoxTextToSend.TextChanged += new System.EventHandler(this.textBoxTextToSend_TextChanged);
            this.textBoxTextToSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTextToSend_KeyPress);
            // 
            // statusStripP
            // 
            this.statusStripP.Font = new System.Drawing.Font("Steinberg Chord Sym Sans Serif", 8F);
            this.statusStripP.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStatus,
            this.toolStripStatusLabelServer,
            this.toolStripStatusLabel3});
            this.statusStripP.Location = new System.Drawing.Point(0, 589);
            this.statusStripP.Name = "statusStripP";
            this.statusStripP.Size = new System.Drawing.Size(935, 25);
            this.statusStripP.TabIndex = 9;
            this.statusStripP.Text = "Status: Disconnected Users: 0";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelStatus.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.toolStripStatusLabelStatus.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelStatus.Image")));
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(91, 19);
            this.toolStripStatusLabelStatus.Text = "Status: offline";
            // 
            // toolStripStatusLabelServer
            // 
            this.toolStripStatusLabelServer.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.toolStripStatusLabelServer.Name = "toolStripStatusLabelServer";
            this.toolStripStatusLabelServer.Size = new System.Drawing.Size(62, 19);
            this.toolStripStatusLabelServer.Text = "Server: 0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(58, 19);
            this.toolStripStatusLabel3.Text = "Users: 0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonChanceNick);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button_Connect);
            this.groupBox2.Controls.Add(this.textBoxNickName);
            this.groupBox2.Location = new System.Drawing.Point(605, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 115);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // buttonChanceNick
            // 
            this.buttonChanceNick.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.buttonChanceNick.Location = new System.Drawing.Point(121, 77);
            this.buttonChanceNick.Name = "buttonChanceNick";
            this.buttonChanceNick.Size = new System.Drawing.Size(82, 32);
            this.buttonChanceNick.TabIndex = 3;
            this.buttonChanceNick.Text = "Change";
            this.buttonChanceNick.UseVisualStyleBackColor = true;
            this.buttonChanceNick.Visible = false;
            this.buttonChanceNick.Click += new System.EventHandler(this.buttonChanceNick_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter your nickname:";
            // 
            // button_Connect
            // 
            this.button_Connect.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Connect.Location = new System.Drawing.Point(215, 29);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(82, 46);
            this.button_Connect.TabIndex = 1;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // textBoxNickName
            // 
            this.textBoxNickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNickName.Location = new System.Drawing.Point(17, 49);
            this.textBoxNickName.Name = "textBoxNickName";
            this.textBoxNickName.Size = new System.Drawing.Size(184, 24);
            this.textBoxNickName.TabIndex = 2;
            // 
            // buttonConfig
            // 
            this.buttonConfig.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfig.Location = new System.Drawing.Point(490, 431);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(81, 28);
            this.buttonConfig.TabIndex = 12;
            this.buttonConfig.Text = "Config";
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // buttonHideConfig
            // 
            this.buttonHideConfig.Font = new System.Drawing.Font("PMingLiU-ExtB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHideConfig.Location = new System.Drawing.Point(605, 434);
            this.buttonHideConfig.Name = "buttonHideConfig";
            this.buttonHideConfig.Size = new System.Drawing.Size(44, 28);
            this.buttonHideConfig.TabIndex = 13;
            this.buttonHideConfig.Text = "<<<";
            this.buttonHideConfig.UseVisualStyleBackColor = true;
            this.buttonHideConfig.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBoxPrivateMessage
            // 
            this.groupBoxPrivateMessage.Controls.Add(this.label3);
            this.groupBoxPrivateMessage.Controls.Add(this.comboBoxMessagePrivate);
            this.groupBoxPrivateMessage.Controls.Add(this.buttonMessagePrivate);
            this.groupBoxPrivateMessage.Controls.Add(this.textBoxMessagePrivate);
            this.groupBoxPrivateMessage.Font = new System.Drawing.Font("Segoe UI", 9.3F);
            this.groupBoxPrivateMessage.Location = new System.Drawing.Point(936, 3);
            this.groupBoxPrivateMessage.Name = "groupBoxPrivateMessage";
            this.groupBoxPrivateMessage.Size = new System.Drawing.Size(313, 117);
            this.groupBoxPrivateMessage.TabIndex = 14;
            this.groupBoxPrivateMessage.TabStop = false;
            this.groupBoxPrivateMessage.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.4F);
            this.label3.Location = new System.Drawing.Point(13, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Private Message";
            // 
            // comboBoxMessagePrivate
            // 
            this.comboBoxMessagePrivate.FormattingEnabled = true;
            this.comboBoxMessagePrivate.Location = new System.Drawing.Point(6, 41);
            this.comboBoxMessagePrivate.Name = "comboBoxMessagePrivate";
            this.comboBoxMessagePrivate.Size = new System.Drawing.Size(152, 28);
            this.comboBoxMessagePrivate.TabIndex = 2;
            // 
            // buttonMessagePrivate
            // 
            this.buttonMessagePrivate.Enabled = false;
            this.buttonMessagePrivate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMessagePrivate.Location = new System.Drawing.Point(207, 78);
            this.buttonMessagePrivate.Name = "buttonMessagePrivate";
            this.buttonMessagePrivate.Size = new System.Drawing.Size(82, 34);
            this.buttonMessagePrivate.TabIndex = 1;
            this.buttonMessagePrivate.Text = "Send";
            this.buttonMessagePrivate.UseVisualStyleBackColor = true;
            this.buttonMessagePrivate.Click += new System.EventHandler(this.buttonMessagePrivate_Click);
            // 
            // textBoxMessagePrivate
            // 
            this.textBoxMessagePrivate.Location = new System.Drawing.Point(6, 82);
            this.textBoxMessagePrivate.Name = "textBoxMessagePrivate";
            this.textBoxMessagePrivate.Size = new System.Drawing.Size(195, 28);
            this.textBoxMessagePrivate.TabIndex = 0;
            // 
            // textBoxRoot
            // 
            this.textBoxRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoot.Location = new System.Drawing.Point(12, 19);
            this.textBoxRoot.Name = "textBoxRoot";
            this.textBoxRoot.Size = new System.Drawing.Size(483, 24);
            this.textBoxRoot.TabIndex = 16;
            this.textBoxRoot.Text = "D:\\Covers\\Ariana";
            // 
            // treeViewFile
            // 
            this.treeViewFile.Location = new System.Drawing.Point(12, 49);
            this.treeViewFile.Name = "treeViewFile";
            this.treeViewFile.Size = new System.Drawing.Size(559, 376);
            this.treeViewFile.TabIndex = 15;
            this.treeViewFile.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFile_AfterSelect);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonStatus);
            this.groupBox3.Controls.Add(this.buttonGo);
            this.groupBox3.Controls.Add(this.textBoxRoot);
            this.groupBox3.Controls.Add(this.treeViewFile);
            this.groupBox3.Controls.Add(this.buttonConfig);
            this.groupBox3.Location = new System.Drawing.Point(12, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(582, 474);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // buttonStatus
            // 
            this.buttonStatus.Location = new System.Drawing.Point(12, 431);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(75, 37);
            this.buttonStatus.TabIndex = 18;
            this.buttonStatus.Text = "Status";
            this.buttonStatus.UseVisualStyleBackColor = true;
            this.buttonStatus.Click += new System.EventHandler(this.buttonNeedList_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Enabled = false;
            this.buttonGo.Location = new System.Drawing.Point(501, 17);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(70, 26);
            this.buttonGo.TabIndex = 17;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // treeViewFilesServer
            // 
            this.treeViewFilesServer.Location = new System.Drawing.Point(605, 144);
            this.treeViewFilesServer.Name = "treeViewFilesServer";
            this.treeViewFilesServer.Size = new System.Drawing.Size(313, 284);
            this.treeViewFilesServer.TabIndex = 18;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 484);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(582, 96);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(618, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Files in Server:";
            // 
            // FormP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 614);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.treeViewFilesServer);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxPrivateMessage);
            this.Controls.Add(this.buttonHideConfig);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStripP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormP";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormP_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStripP.ResumeLayout(false);
            this.statusStripP.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxPrivateMessage.ResumeLayout(false);
            this.groupBoxPrivateMessage.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBoxTextToSend;
        private System.Windows.Forms.StatusStrip statusStripP;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelServer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.TextBox textBoxNickName;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.Button buttonHideConfig;
        private System.Windows.Forms.Button buttonChanceNick;
        private System.Windows.Forms.GroupBox groupBoxPrivateMessage;
        private System.Windows.Forms.ComboBox comboBoxMessagePrivate;
        private System.Windows.Forms.Button buttonMessagePrivate;
        private System.Windows.Forms.TextBox textBoxMessagePrivate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRoot;
        private System.Windows.Forms.TreeView treeViewFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonStatus;
        private System.Windows.Forms.TreeView treeViewFilesServer;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}