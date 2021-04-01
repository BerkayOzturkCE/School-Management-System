namespace WindowsFormsApp2
{
    partial class Yeni_Kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yeni_Kayit));
            this.geri = new System.Windows.Forms.Button();
            this.txbxsyism = new System.Windows.Forms.TextBox();
            this.txbxism = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rb_erkk = new System.Windows.Forms.RadioButton();
            this.rb_kdn = new System.Windows.Forms.RadioButton();
            this.txtbxadrs = new System.Windows.Forms.TextBox();
            this.cmbxblm = new System.Windows.Forms.ComboBox();
            this.txtbxsfr = new System.Windows.Forms.TextBox();
            this.btnkyt = new System.Windows.Forms.Button();
            this.txtbxtlfn = new System.Windows.Forms.TextBox();
            this.txtbxemail = new System.Windows.Forms.TextBox();
            this.txtkimlik_no = new System.Windows.Forms.TextBox();
            this.gbcinsiyet = new System.Windows.Forms.GroupBox();
            this.gbunvan = new System.Windows.Forms.GroupBox();
            this.rb_ogr = new System.Windows.Forms.RadioButton();
            this.rb_ytkili = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.gbcinsiyet.SuspendLayout();
            this.gbunvan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // geri
            // 
            this.geri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.geri.BackColor = System.Drawing.Color.SeaGreen;
            this.geri.FlatAppearance.BorderSize = 0;
            this.geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri.ForeColor = System.Drawing.Color.White;
            this.geri.Location = new System.Drawing.Point(660, 395);
            this.geri.Margin = new System.Windows.Forms.Padding(2);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(214, 48);
            this.geri.TabIndex = 25;
            this.geri.Text = "Geri";
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // txbxsyism
            // 
            this.txbxsyism.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbxsyism.BackColor = System.Drawing.Color.LightGray;
            this.txbxsyism.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbxsyism.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.txbxsyism.Location = new System.Drawing.Point(58, 212);
            this.txbxsyism.Margin = new System.Windows.Forms.Padding(2);
            this.txbxsyism.Multiline = true;
            this.txbxsyism.Name = "txbxsyism";
            this.txbxsyism.Size = new System.Drawing.Size(202, 32);
            this.txbxsyism.TabIndex = 30;
            this.txbxsyism.Text = "Soyisim";
            // 
            // txbxism
            // 
            this.txbxism.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbxism.BackColor = System.Drawing.Color.LightGray;
            this.txbxism.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbxism.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbxism.Location = new System.Drawing.Point(58, 147);
            this.txbxism.Margin = new System.Windows.Forms.Padding(2);
            this.txbxism.Multiline = true;
            this.txbxism.Name = "txbxism";
            this.txbxism.Size = new System.Drawing.Size(202, 32);
            this.txbxism.TabIndex = 31;
            this.txbxism.Text = "İsim";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(353, 147);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 34);
            this.dateTimePicker1.TabIndex = 32;
            this.dateTimePicker1.Value = new System.DateTime(2020, 4, 28, 0, 0, 0, 0);
            // 
            // rb_erkk
            // 
            this.rb_erkk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_erkk.AutoSize = true;
            this.rb_erkk.BackColor = System.Drawing.Color.Transparent;
            this.rb_erkk.Checked = true;
            this.rb_erkk.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.rb_erkk.ForeColor = System.Drawing.Color.White;
            this.rb_erkk.Location = new System.Drawing.Point(21, 20);
            this.rb_erkk.Margin = new System.Windows.Forms.Padding(2);
            this.rb_erkk.Name = "rb_erkk";
            this.rb_erkk.Size = new System.Drawing.Size(79, 31);
            this.rb_erkk.TabIndex = 33;
            this.rb_erkk.TabStop = true;
            this.rb_erkk.Text = "Erkek";
            this.rb_erkk.UseVisualStyleBackColor = false;
            // 
            // rb_kdn
            // 
            this.rb_kdn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_kdn.AutoSize = true;
            this.rb_kdn.BackColor = System.Drawing.Color.Transparent;
            this.rb_kdn.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.rb_kdn.ForeColor = System.Drawing.Color.White;
            this.rb_kdn.Location = new System.Drawing.Point(108, 20);
            this.rb_kdn.Margin = new System.Windows.Forms.Padding(2);
            this.rb_kdn.Name = "rb_kdn";
            this.rb_kdn.Size = new System.Drawing.Size(81, 31);
            this.rb_kdn.TabIndex = 34;
            this.rb_kdn.TabStop = true;
            this.rb_kdn.Text = "Kadın";
            this.rb_kdn.UseVisualStyleBackColor = false;
            // 
            // txtbxadrs
            // 
            this.txtbxadrs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxadrs.BackColor = System.Drawing.Color.LightGray;
            this.txtbxadrs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxadrs.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.txtbxadrs.Location = new System.Drawing.Point(660, 212);
            this.txtbxadrs.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxadrs.Multiline = true;
            this.txtbxadrs.Name = "txtbxadrs";
            this.txtbxadrs.Size = new System.Drawing.Size(214, 89);
            this.txtbxadrs.TabIndex = 35;
            this.txtbxadrs.Text = "Adres";
            // 
            // cmbxblm
            // 
            this.cmbxblm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbxblm.BackColor = System.Drawing.Color.LightGray;
            this.cmbxblm.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.cmbxblm.FormattingEnabled = true;
            this.cmbxblm.Location = new System.Drawing.Point(660, 147);
            this.cmbxblm.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxblm.Name = "cmbxblm";
            this.cmbxblm.Size = new System.Drawing.Size(214, 35);
            this.cmbxblm.TabIndex = 37;
            this.cmbxblm.Text = "Bölüm";
            // 
            // txtbxsfr
            // 
            this.txtbxsfr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxsfr.BackColor = System.Drawing.Color.LightGray;
            this.txtbxsfr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxsfr.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.txtbxsfr.Location = new System.Drawing.Point(58, 407);
            this.txtbxsfr.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxsfr.Multiline = true;
            this.txtbxsfr.Name = "txtbxsfr";
            this.txtbxsfr.Size = new System.Drawing.Size(202, 32);
            this.txtbxsfr.TabIndex = 38;
            this.txtbxsfr.Text = "Şifre";
            // 
            // btnkyt
            // 
            this.btnkyt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnkyt.BackColor = System.Drawing.Color.SeaGreen;
            this.btnkyt.FlatAppearance.BorderSize = 0;
            this.btnkyt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkyt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkyt.ForeColor = System.Drawing.Color.White;
            this.btnkyt.Location = new System.Drawing.Point(660, 326);
            this.btnkyt.Margin = new System.Windows.Forms.Padding(2);
            this.btnkyt.Name = "btnkyt";
            this.btnkyt.Size = new System.Drawing.Size(214, 48);
            this.btnkyt.TabIndex = 39;
            this.btnkyt.Text = "Kaydet";
            this.btnkyt.UseVisualStyleBackColor = false;
            this.btnkyt.Click += new System.EventHandler(this.btnkyt_Click);
            // 
            // txtbxtlfn
            // 
            this.txtbxtlfn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxtlfn.BackColor = System.Drawing.Color.LightGray;
            this.txtbxtlfn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxtlfn.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.txtbxtlfn.Location = new System.Drawing.Point(58, 342);
            this.txtbxtlfn.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxtlfn.Multiline = true;
            this.txtbxtlfn.Name = "txtbxtlfn";
            this.txtbxtlfn.Size = new System.Drawing.Size(202, 32);
            this.txtbxtlfn.TabIndex = 41;
            this.txtbxtlfn.Text = "Telefon";
            // 
            // txtbxemail
            // 
            this.txtbxemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxemail.BackColor = System.Drawing.Color.LightGray;
            this.txtbxemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxemail.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.txtbxemail.Location = new System.Drawing.Point(353, 212);
            this.txtbxemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxemail.Multiline = true;
            this.txtbxemail.Name = "txtbxemail";
            this.txtbxemail.Size = new System.Drawing.Size(214, 32);
            this.txtbxemail.TabIndex = 43;
            this.txtbxemail.Text = "Email";
            // 
            // txtkimlik_no
            // 
            this.txtkimlik_no.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtkimlik_no.BackColor = System.Drawing.Color.LightGray;
            this.txtkimlik_no.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtkimlik_no.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.txtkimlik_no.Location = new System.Drawing.Point(58, 277);
            this.txtkimlik_no.Margin = new System.Windows.Forms.Padding(2);
            this.txtkimlik_no.Multiline = true;
            this.txtkimlik_no.Name = "txtkimlik_no";
            this.txtkimlik_no.Size = new System.Drawing.Size(202, 32);
            this.txtkimlik_no.TabIndex = 44;
            this.txtkimlik_no.Text = "Kimlik no";
            // 
            // gbcinsiyet
            // 
            this.gbcinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.gbcinsiyet.Controls.Add(this.rb_erkk);
            this.gbcinsiyet.Controls.Add(this.rb_kdn);
            this.gbcinsiyet.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.gbcinsiyet.ForeColor = System.Drawing.Color.White;
            this.gbcinsiyet.Location = new System.Drawing.Point(353, 382);
            this.gbcinsiyet.Margin = new System.Windows.Forms.Padding(2);
            this.gbcinsiyet.Name = "gbcinsiyet";
            this.gbcinsiyet.Padding = new System.Windows.Forms.Padding(2);
            this.gbcinsiyet.Size = new System.Drawing.Size(214, 57);
            this.gbcinsiyet.TabIndex = 45;
            this.gbcinsiyet.TabStop = false;
            this.gbcinsiyet.Text = "Cinsiyet";
            // 
            // gbunvan
            // 
            this.gbunvan.BackColor = System.Drawing.Color.Transparent;
            this.gbunvan.Controls.Add(this.rb_ogr);
            this.gbunvan.Controls.Add(this.rb_ytkili);
            this.gbunvan.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.gbunvan.ForeColor = System.Drawing.Color.White;
            this.gbunvan.Location = new System.Drawing.Point(353, 277);
            this.gbunvan.Margin = new System.Windows.Forms.Padding(2);
            this.gbunvan.Name = "gbunvan";
            this.gbunvan.Padding = new System.Windows.Forms.Padding(2);
            this.gbunvan.Size = new System.Drawing.Size(214, 80);
            this.gbunvan.TabIndex = 46;
            this.gbunvan.TabStop = false;
            this.gbunvan.Text = "Ünvan";
            // 
            // rb_ogr
            // 
            this.rb_ogr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_ogr.AutoSize = true;
            this.rb_ogr.BackColor = System.Drawing.Color.Transparent;
            this.rb_ogr.Checked = true;
            this.rb_ogr.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.rb_ogr.ForeColor = System.Drawing.Color.White;
            this.rb_ogr.Location = new System.Drawing.Point(21, 30);
            this.rb_ogr.Margin = new System.Windows.Forms.Padding(2);
            this.rb_ogr.Name = "rb_ogr";
            this.rb_ogr.Size = new System.Drawing.Size(100, 31);
            this.rb_ogr.TabIndex = 33;
            this.rb_ogr.TabStop = true;
            this.rb_ogr.Text = "Öğrenci";
            this.rb_ogr.UseVisualStyleBackColor = false;
            // 
            // rb_ytkili
            // 
            this.rb_ytkili.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_ytkili.AutoSize = true;
            this.rb_ytkili.BackColor = System.Drawing.Color.Transparent;
            this.rb_ytkili.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.rb_ytkili.ForeColor = System.Drawing.Color.White;
            this.rb_ytkili.Location = new System.Drawing.Point(119, 30);
            this.rb_ytkili.Margin = new System.Windows.Forms.Padding(2);
            this.rb_ytkili.Name = "rb_ytkili";
            this.rb_ytkili.Size = new System.Drawing.Size(82, 31);
            this.rb_ytkili.TabIndex = 34;
            this.rb_ytkili.Text = "Yetkili";
            this.rb_ytkili.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 524);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(934, 37);
            this.statusBar1.TabIndex = 49;
            this.statusBar1.Text = "statusBar1";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "statusBarPanel1";
            this.statusBarPanel1.Width = 900;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bradley Hand ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(349, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 60);
            this.label1.TabIndex = 50;
            this.label1.Text = "Yeni Kayıt";
            // 
            // Yeni_Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Resource1.ana;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.gbunvan);
            this.Controls.Add(this.gbcinsiyet);
            this.Controls.Add(this.txtkimlik_no);
            this.Controls.Add(this.txtbxemail);
            this.Controls.Add(this.txtbxtlfn);
            this.Controls.Add(this.btnkyt);
            this.Controls.Add(this.txtbxsfr);
            this.Controls.Add(this.cmbxblm);
            this.Controls.Add(this.txtbxadrs);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txbxism);
            this.Controls.Add(this.txbxsyism);
            this.Controls.Add(this.geri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Yeni_Kayit";
            this.Text = "Okul Yönetim Sistemi";
            this.Load += new System.EventHandler(this.Ogr_Kayit_Load);
            this.gbcinsiyet.ResumeLayout(false);
            this.gbcinsiyet.PerformLayout();
            this.gbunvan.ResumeLayout(false);
            this.gbunvan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.TextBox txbxsyism;
        private System.Windows.Forms.TextBox txbxism;
        private System.Windows.Forms.RadioButton rb_erkk;
        private System.Windows.Forms.RadioButton rb_kdn;
        private System.Windows.Forms.TextBox txtbxadrs;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbxblm;
        private System.Windows.Forms.TextBox txtbxsfr;
        private System.Windows.Forms.Button btnkyt;
        private System.Windows.Forms.TextBox txtbxtlfn;
        private System.Windows.Forms.TextBox txtbxemail;
        private System.Windows.Forms.TextBox txtkimlik_no;
        private System.Windows.Forms.GroupBox gbcinsiyet;
        private System.Windows.Forms.GroupBox gbunvan;
        private System.Windows.Forms.RadioButton rb_ogr;
        private System.Windows.Forms.RadioButton rb_ytkili;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.Label label1;
    }
}