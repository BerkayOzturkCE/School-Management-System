namespace WindowsFormsApp2
{
    partial class OgrAnaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrAnaMenu));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.geri = new System.Windows.Forms.Button();
            this.ders_kayit = new System.Windows.Forms.Button();
            this.kisisel = new System.Windows.Forms.Button();
            this.notlar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bradley Hand ITC", 24F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(428, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 50);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ögrenci Paneli";
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 831);
            this.statusBar1.Margin = new System.Windows.Forms.Padding(4);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(1179, 44);
            this.statusBar1.TabIndex = 33;
            this.statusBar1.Text = "statusBar1";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "statusBarPanel1";
            this.statusBarPanel1.Width = 865;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(966, 80);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 83);
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(966, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 24);
            this.comboBox1.TabIndex = 47;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.SeaGreen;
            this.geri.FlatAppearance.BorderSize = 0;
            this.geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri.ForeColor = System.Drawing.Color.White;
            this.geri.Location = new System.Drawing.Point(594, 300);
            this.geri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(300, 59);
            this.geri.TabIndex = 48;
            this.geri.Text = "Geri";
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // ders_kayit
            // 
            this.ders_kayit.BackColor = System.Drawing.Color.SeaGreen;
            this.ders_kayit.FlatAppearance.BorderSize = 0;
            this.ders_kayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ders_kayit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ders_kayit.ForeColor = System.Drawing.Color.White;
            this.ders_kayit.Location = new System.Drawing.Point(138, 300);
            this.ders_kayit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ders_kayit.Name = "ders_kayit";
            this.ders_kayit.Size = new System.Drawing.Size(300, 59);
            this.ders_kayit.TabIndex = 49;
            this.ders_kayit.Text = "Ders Kaydı";
            this.ders_kayit.UseVisualStyleBackColor = false;
            this.ders_kayit.Click += new System.EventHandler(this.ders_kayit_Click_1);
            // 
            // kisisel
            // 
            this.kisisel.BackColor = System.Drawing.Color.SeaGreen;
            this.kisisel.FlatAppearance.BorderSize = 0;
            this.kisisel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kisisel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kisisel.ForeColor = System.Drawing.Color.White;
            this.kisisel.Location = new System.Drawing.Point(594, 200);
            this.kisisel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kisisel.Name = "kisisel";
            this.kisisel.Size = new System.Drawing.Size(300, 59);
            this.kisisel.TabIndex = 50;
            this.kisisel.Text = "Kisisel Bilgilerim";
            this.kisisel.UseVisualStyleBackColor = false;
            this.kisisel.Click += new System.EventHandler(this.kisisel_Click_1);
            // 
            // notlar
            // 
            this.notlar.BackColor = System.Drawing.Color.SeaGreen;
            this.notlar.FlatAppearance.BorderSize = 0;
            this.notlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notlar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notlar.ForeColor = System.Drawing.Color.White;
            this.notlar.Location = new System.Drawing.Point(138, 200);
            this.notlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.notlar.Name = "notlar";
            this.notlar.Size = new System.Drawing.Size(300, 59);
            this.notlar.TabIndex = 51;
            this.notlar.Text = "Notlarım";
            this.notlar.UseVisualStyleBackColor = false;
            this.notlar.Click += new System.EventHandler(this.notlar_Click_1);
            // 
            // OgrAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 875);
            this.Controls.Add(this.notlar);
            this.Controls.Add(this.kisisel);
            this.Controls.Add(this.ders_kayit);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "OgrAnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "OgrAnaMenu";
            this.Load += new System.EventHandler(this.OgrAnaMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button ders_kayit;
        private System.Windows.Forms.Button kisisel;
        private System.Windows.Forms.Button notlar;
    }
}