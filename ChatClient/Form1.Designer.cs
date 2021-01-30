
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_send = new System.Windows.Forms.Button();
            this.textBoxTextToSend = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStripP = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Connect = new System.Windows.Forms.Button();
            this.textBoxNickName = new System.Windows.Forms.TextBox();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.buttonHideConfig = new System.Windows.Forms.Button();
            this.buttonChanceNick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStripP.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(16, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(551, 234);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.button_send);
            this.groupBox1.Controls.Add(this.textBoxTextToSend);
            this.groupBox1.Location = new System.Drawing.Point(21, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 318);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // button_send
            // 
            this.button_send.Enabled = false;
            this.button_send.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_send.Location = new System.Drawing.Point(482, 271);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(85, 30);
            this.button_send.TabIndex = 3;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // textBoxTextToSend
            // 
            this.textBoxTextToSend.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTextToSend.Location = new System.Drawing.Point(16, 273);
            this.textBoxTextToSend.Name = "textBoxTextToSend";
            this.textBoxTextToSend.Size = new System.Drawing.Size(386, 24);
            this.textBoxTextToSend.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "MChat Client";
            // 
            // statusStripP
            // 
            this.statusStripP.Font = new System.Drawing.Font("Steinberg Chord Sym Sans Serif", 8F);
            this.statusStripP.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStatus,
            this.toolStripStatusLabelServer,
            this.toolStripStatusLabel3});
            this.statusStripP.Location = new System.Drawing.Point(0, 379);
            this.statusStripP.Name = "statusStripP";
            this.statusStripP.Size = new System.Drawing.Size(963, 25);
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
            this.groupBox2.Location = new System.Drawing.Point(628, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 115);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter your nickname:";
            // 
            // button_Connect
            // 
            this.button_Connect.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Connect.Location = new System.Drawing.Point(209, 55);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(82, 27);
            this.button_Connect.TabIndex = 1;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // textBoxNickName
            // 
            this.textBoxNickName.Location = new System.Drawing.Point(20, 57);
            this.textBoxNickName.Name = "textBoxNickName";
            this.textBoxNickName.Size = new System.Drawing.Size(181, 22);
            this.textBoxNickName.TabIndex = 2;
            // 
            // buttonConfig
            // 
            this.buttonConfig.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfig.Location = new System.Drawing.Point(531, 25);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(75, 23);
            this.buttonConfig.TabIndex = 12;
            this.buttonConfig.Text = "Config";
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // buttonHideConfig
            // 
            this.buttonHideConfig.Font = new System.Drawing.Font("PMingLiU-ExtB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHideConfig.Location = new System.Drawing.Point(627, 26);
            this.buttonHideConfig.Name = "buttonHideConfig";
            this.buttonHideConfig.Size = new System.Drawing.Size(44, 23);
            this.buttonHideConfig.TabIndex = 13;
            this.buttonHideConfig.Text = "<<<";
            this.buttonHideConfig.UseVisualStyleBackColor = true;
            this.buttonHideConfig.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonChanceNick
            // 
            this.buttonChanceNick.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.buttonChanceNick.Location = new System.Drawing.Point(209, 84);
            this.buttonChanceNick.Name = "buttonChanceNick";
            this.buttonChanceNick.Size = new System.Drawing.Size(82, 25);
            this.buttonChanceNick.TabIndex = 3;
            this.buttonChanceNick.Text = "Change";
            this.buttonChanceNick.UseVisualStyleBackColor = true;
            this.buttonChanceNick.Visible = false;
            this.buttonChanceNick.Click += new System.EventHandler(this.buttonChanceNick_Click);
            // 
            // FormP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 404);
            this.Controls.Add(this.buttonHideConfig);
            this.Controls.Add(this.buttonConfig);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStripP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormP";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStripP.ResumeLayout(false);
            this.statusStripP.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBoxTextToSend;
        private System.Windows.Forms.Label label1;
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
    }
}