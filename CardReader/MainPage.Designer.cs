namespace CardReader
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kAYITLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtlarıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtlarıDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yOKLAMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yoklamaAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yARDIMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kartSistemiHakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtlarHakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.kartnumtx = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BAĞLANTI";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Bağlantıyı Kes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bağlan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "BaudRate:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(94, 72);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Noktası:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kAYITLARToolStripMenuItem,
            this.yOKLAMAToolStripMenuItem,
            this.yARDIMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kAYITLARToolStripMenuItem
            // 
            this.kAYITLARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtlarıGörüntüleToolStripMenuItem,
            this.kayıtlarıDüzenleToolStripMenuItem});
            this.kAYITLARToolStripMenuItem.Name = "kAYITLARToolStripMenuItem";
            this.kAYITLARToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.kAYITLARToolStripMenuItem.Text = "KAYITLAR";
            // 
            // kayıtlarıGörüntüleToolStripMenuItem
            // 
            this.kayıtlarıGörüntüleToolStripMenuItem.Name = "kayıtlarıGörüntüleToolStripMenuItem";
            this.kayıtlarıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.kayıtlarıGörüntüleToolStripMenuItem.Text = "Kayıtları Görüntüle";
            // 
            // kayıtlarıDüzenleToolStripMenuItem
            // 
            this.kayıtlarıDüzenleToolStripMenuItem.Name = "kayıtlarıDüzenleToolStripMenuItem";
            this.kayıtlarıDüzenleToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.kayıtlarıDüzenleToolStripMenuItem.Text = "Kayıtları Düzenle";
            // 
            // yOKLAMAToolStripMenuItem
            // 
            this.yOKLAMAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yoklamaAlToolStripMenuItem});
            this.yOKLAMAToolStripMenuItem.Name = "yOKLAMAToolStripMenuItem";
            this.yOKLAMAToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.yOKLAMAToolStripMenuItem.Text = "YOKLAMA";
            // 
            // yoklamaAlToolStripMenuItem
            // 
            this.yoklamaAlToolStripMenuItem.Name = "yoklamaAlToolStripMenuItem";
            this.yoklamaAlToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.yoklamaAlToolStripMenuItem.Text = "Yoklama Al";
            // 
            // yARDIMToolStripMenuItem
            // 
            this.yARDIMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kartSistemiHakkındaToolStripMenuItem,
            this.kayıtlarHakkındaToolStripMenuItem});
            this.yARDIMToolStripMenuItem.Name = "yARDIMToolStripMenuItem";
            this.yARDIMToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.yARDIMToolStripMenuItem.Text = "YARDIM";
            // 
            // kartSistemiHakkındaToolStripMenuItem
            // 
            this.kartSistemiHakkındaToolStripMenuItem.Name = "kartSistemiHakkındaToolStripMenuItem";
            this.kartSistemiHakkındaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.kartSistemiHakkındaToolStripMenuItem.Text = "Kart Sistemi Hakkında";
            // 
            // kayıtlarHakkındaToolStripMenuItem
            // 
            this.kayıtlarHakkındaToolStripMenuItem.Name = "kayıtlarHakkındaToolStripMenuItem";
            this.kayıtlarHakkındaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.kayıtlarHakkındaToolStripMenuItem.Text = "Kayıtlar Hakkında";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.kartnumtx);
            this.groupBox3.Location = new System.Drawing.Point(513, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 203);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "KART KAYDETME";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(70, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Kart Numarası:";
            // 
            // kartnumtx
            // 
            this.kartnumtx.Location = new System.Drawing.Point(149, 69);
            this.kartnumtx.Name = "kartnumtx";
            this.kartnumtx.Size = new System.Drawing.Size(160, 20);
            this.kartnumtx.TabIndex = 8;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAĞLANTI ";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kAYITLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtlarıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtlarıDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yOKLAMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yoklamaAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yARDIMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kartSistemiHakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtlarHakkındaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        public System.IO.Ports.SerialPort serialPort1;
        public System.Windows.Forms.TextBox kartnumtx;
    }
}