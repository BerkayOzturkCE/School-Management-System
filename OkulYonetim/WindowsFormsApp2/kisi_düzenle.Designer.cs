namespace WindowsFormsApp2
{
    partial class kisi_düzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kisi_düzenle));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtkimlik_no = new System.Windows.Forms.TextBox();
            this.txtbxemail = new System.Windows.Forms.TextBox();
            this.txtbxtlfn = new System.Windows.Forms.TextBox();
            this.btnkyt = new System.Windows.Forms.Button();
            this.txtbxadrs = new System.Windows.Forms.TextBox();
            this.txbxism = new System.Windows.Forms.TextBox();
            this.txbxsyism = new System.Windows.Forms.TextBox();
            this.geri = new System.Windows.Forms.Button();
            this.txtbxOgrNo = new System.Windows.Forms.TextBox();
            this.BtnAra = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtkimlik_no
            // 
            this.txtkimlik_no.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtkimlik_no.BackColor = System.Drawing.Color.LightGray;
            this.txtkimlik_no.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtkimlik_no.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.txtkimlik_no.Location = new System.Drawing.Point(120, 343);
            this.txtkimlik_no.Margin = new System.Windows.Forms.Padding(2);
            this.txtkimlik_no.Multiline = true;
            this.txtkimlik_no.Name = "txtkimlik_no";
            this.txtkimlik_no.Size = new System.Drawing.Size(214, 32);
            this.txtkimlik_no.TabIndex = 59;
            this.txtkimlik_no.Text = "Kimlik no";
            // 
            // txtbxemail
            // 
            this.txtbxemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxemail.BackColor = System.Drawing.Color.LightGray;
            this.txtbxemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxemail.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.txtbxemail.Location = new System.Drawing.Point(458, 173);
            this.txtbxemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxemail.Multiline = true;
            this.txtbxemail.Name = "txtbxemail";
            this.txtbxemail.Size = new System.Drawing.Size(214, 32);
            this.txtbxemail.TabIndex = 58;
            this.txtbxemail.Text = "Email";
            // 
            // txtbxtlfn
            // 
            this.txtbxtlfn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxtlfn.BackColor = System.Drawing.Color.LightGray;
            this.txtbxtlfn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxtlfn.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.txtbxtlfn.Location = new System.Drawing.Point(458, 230);
            this.txtbxtlfn.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxtlfn.Multiline = true;
            this.txtbxtlfn.Name = "txtbxtlfn";
            this.txtbxtlfn.Size = new System.Drawing.Size(214, 32);
            this.txtbxtlfn.TabIndex = 57;
            this.txtbxtlfn.Text = "Telefon";
            // 
            // btnkyt
            // 
            this.btnkyt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnkyt.BackColor = System.Drawing.Color.SeaGreen;
            this.btnkyt.FlatAppearance.BorderSize = 0;
            this.btnkyt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkyt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkyt.ForeColor = System.Drawing.Color.White;
            this.btnkyt.Location = new System.Drawing.Point(458, 487);
            this.btnkyt.Margin = new System.Windows.Forms.Padding(2);
            this.btnkyt.Name = "btnkyt";
            this.btnkyt.Size = new System.Drawing.Size(214, 48);
            this.btnkyt.TabIndex = 56;
            this.btnkyt.Text = "Güncelle";
            this.btnkyt.UseVisualStyleBackColor = false;
            this.btnkyt.Click += new System.EventHandler(this.btnkyt_Click);
            // 
            // txtbxadrs
            // 
            this.txtbxadrs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxadrs.BackColor = System.Drawing.Color.LightGray;
            this.txtbxadrs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxadrs.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.txtbxadrs.Location = new System.Drawing.Point(458, 287);
            this.txtbxadrs.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxadrs.Multiline = true;
            this.txtbxadrs.Name = "txtbxadrs";
            this.txtbxadrs.Size = new System.Drawing.Size(214, 88);
            this.txtbxadrs.TabIndex = 53;
            this.txtbxadrs.Text = "Adres";
            // 
            // txbxism
            // 
            this.txbxism.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbxism.BackColor = System.Drawing.Color.LightGray;
            this.txbxism.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbxism.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbxism.Location = new System.Drawing.Point(120, 230);
            this.txbxism.Margin = new System.Windows.Forms.Padding(2);
            this.txbxism.Multiline = true;
            this.txbxism.Name = "txbxism";
            this.txbxism.Size = new System.Drawing.Size(214, 32);
            this.txbxism.TabIndex = 51;
            this.txbxism.Text = "İsim";
            // 
            // txbxsyism
            // 
            this.txbxsyism.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbxsyism.BackColor = System.Drawing.Color.LightGray;
            this.txbxsyism.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbxsyism.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.txbxsyism.Location = new System.Drawing.Point(120, 287);
            this.txbxsyism.Margin = new System.Windows.Forms.Padding(2);
            this.txbxsyism.Multiline = true;
            this.txbxsyism.Name = "txbxsyism";
            this.txbxsyism.Size = new System.Drawing.Size(214, 32);
            this.txbxsyism.TabIndex = 50;
            this.txbxsyism.Text = "Soyisim";
            // 
            // geri
            // 
            this.geri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.geri.BackColor = System.Drawing.Color.SeaGreen;
            this.geri.FlatAppearance.BorderSize = 0;
            this.geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri.ForeColor = System.Drawing.Color.White;
            this.geri.Location = new System.Drawing.Point(120, 487);
            this.geri.Margin = new System.Windows.Forms.Padding(2);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(202, 48);
            this.geri.TabIndex = 49;
            this.geri.Text = "Geri";
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // txtbxOgrNo
            // 
            this.txtbxOgrNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxOgrNo.BackColor = System.Drawing.Color.LightGray;
            this.txtbxOgrNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxOgrNo.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxOgrNo.Location = new System.Drawing.Point(120, 173);
            this.txtbxOgrNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxOgrNo.Multiline = true;
            this.txtbxOgrNo.Name = "txtbxOgrNo";
            this.txtbxOgrNo.Size = new System.Drawing.Size(214, 32);
            this.txtbxOgrNo.TabIndex = 63;
            this.txtbxOgrNo.Text = "Öğrenci numarası";
            // 
            // BtnAra
            // 
            this.BtnAra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAra.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAra.FlatAppearance.BorderSize = 0;
            this.BtnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAra.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAra.ForeColor = System.Drawing.Color.White;
            this.BtnAra.Location = new System.Drawing.Point(458, 406);
            this.BtnAra.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(214, 48);
            this.BtnAra.TabIndex = 64;
            this.BtnAra.Text = "Ara";
            this.BtnAra.UseVisualStyleBackColor = false;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSil.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnSil.FlatAppearance.BorderSize = 0;
            this.BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSil.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.ForeColor = System.Drawing.Color.White;
            this.BtnSil.Location = new System.Drawing.Point(120, 406);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(202, 48);
            this.BtnSil.TabIndex = 65;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 626);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(784, 35);
            this.statusBar1.TabIndex = 66;
            this.statusBar1.Text = "statusBar1";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "statusBarPanel1";
            this.statusBarPanel1.Width = 750;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bradley Hand ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(247, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 60);
            this.label1.TabIndex = 67;
            this.label1.Text = "Kisi Bilgileri ";
            // 
            // kisi_düzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Resource1.ana;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.txtbxOgrNo);
            this.Controls.Add(this.txtkimlik_no);
            this.Controls.Add(this.txtbxemail);
            this.Controls.Add(this.txtbxtlfn);
            this.Controls.Add(this.btnkyt);
            this.Controls.Add(this.txtbxadrs);
            this.Controls.Add(this.txbxism);
            this.Controls.Add(this.txbxsyism);
            this.Controls.Add(this.geri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "kisi_düzenle";
            this.Text = "Okul Yönetim Sistemi";
            this.Load += new System.EventHandler(this.kisi_düzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtkimlik_no;
        private System.Windows.Forms.TextBox txtbxemail;
        private System.Windows.Forms.TextBox txtbxtlfn;
        private System.Windows.Forms.Button btnkyt;
        private System.Windows.Forms.TextBox txtbxadrs;
        private System.Windows.Forms.TextBox txbxism;
        private System.Windows.Forms.TextBox txbxsyism;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.TextBox txtbxOgrNo;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.Label label1;
    }
}