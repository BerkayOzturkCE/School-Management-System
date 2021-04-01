namespace WindowsFormsApp2
{
    partial class Kisisel_bilgiler
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
            this.txtkimlik_no = new System.Windows.Forms.TextBox();
            this.txtbxemail = new System.Windows.Forms.TextBox();
            this.txtbxtlfn = new System.Windows.Forms.TextBox();
            this.btnkyt = new System.Windows.Forms.Button();
            this.txtbxsfr = new System.Windows.Forms.TextBox();
            this.txtbxadrs = new System.Windows.Forms.TextBox();
            this.txbxism = new System.Windows.Forms.TextBox();
            this.txbxsyism = new System.Windows.Forms.TextBox();
            this.geri = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtkimlik_no
            // 
            this.txtkimlik_no.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtkimlik_no.BackColor = System.Drawing.Color.LightGray;
            this.txtkimlik_no.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtkimlik_no.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.txtkimlik_no.Location = new System.Drawing.Point(73, 256);
            this.txtkimlik_no.Margin = new System.Windows.Forms.Padding(2);
            this.txtkimlik_no.Multiline = true;
            this.txtkimlik_no.Name = "txtkimlik_no";
            this.txtkimlik_no.Size = new System.Drawing.Size(202, 32);
            this.txtkimlik_no.TabIndex = 73;
            this.txtkimlik_no.Text = "Kimlik no";
            // 
            // txtbxemail
            // 
            this.txtbxemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxemail.BackColor = System.Drawing.Color.LightGray;
            this.txtbxemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxemail.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.txtbxemail.Location = new System.Drawing.Point(373, 143);
            this.txtbxemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxemail.Multiline = true;
            this.txtbxemail.Name = "txtbxemail";
            this.txtbxemail.Size = new System.Drawing.Size(214, 32);
            this.txtbxemail.TabIndex = 72;
            this.txtbxemail.Text = "Email";
            // 
            // txtbxtlfn
            // 
            this.txtbxtlfn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxtlfn.BackColor = System.Drawing.Color.LightGray;
            this.txtbxtlfn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxtlfn.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.txtbxtlfn.Location = new System.Drawing.Point(373, 200);
            this.txtbxtlfn.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxtlfn.Multiline = true;
            this.txtbxtlfn.Name = "txtbxtlfn";
            this.txtbxtlfn.Size = new System.Drawing.Size(214, 32);
            this.txtbxtlfn.TabIndex = 71;
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
            this.btnkyt.Location = new System.Drawing.Point(373, 386);
            this.btnkyt.Margin = new System.Windows.Forms.Padding(2);
            this.btnkyt.Name = "btnkyt";
            this.btnkyt.Size = new System.Drawing.Size(214, 48);
            this.btnkyt.TabIndex = 70;
            this.btnkyt.Text = "Kaydet";
            this.btnkyt.UseVisualStyleBackColor = false;
            this.btnkyt.Click += new System.EventHandler(this.btnkyt_Click);
            // 
            // txtbxsfr
            // 
            this.txtbxsfr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxsfr.BackColor = System.Drawing.Color.LightGray;
            this.txtbxsfr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxsfr.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.txtbxsfr.Location = new System.Drawing.Point(73, 313);
            this.txtbxsfr.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxsfr.Multiline = true;
            this.txtbxsfr.Name = "txtbxsfr";
            this.txtbxsfr.Size = new System.Drawing.Size(202, 32);
            this.txtbxsfr.TabIndex = 69;
            this.txtbxsfr.Text = "Şifre";
            // 
            // txtbxadrs
            // 
            this.txtbxadrs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxadrs.BackColor = System.Drawing.Color.LightGray;
            this.txtbxadrs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxadrs.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.txtbxadrs.Location = new System.Drawing.Point(373, 256);
            this.txtbxadrs.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxadrs.Multiline = true;
            this.txtbxadrs.Name = "txtbxadrs";
            this.txtbxadrs.Size = new System.Drawing.Size(214, 89);
            this.txtbxadrs.TabIndex = 68;
            this.txtbxadrs.Text = "Adres";
            // 
            // txbxism
            // 
            this.txbxism.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbxism.BackColor = System.Drawing.Color.LightGray;
            this.txbxism.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbxism.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbxism.Location = new System.Drawing.Point(73, 143);
            this.txbxism.Margin = new System.Windows.Forms.Padding(2);
            this.txbxism.Multiline = true;
            this.txbxism.Name = "txbxism";
            this.txbxism.Size = new System.Drawing.Size(202, 32);
            this.txbxism.TabIndex = 67;
            this.txbxism.Text = "İsim";
            // 
            // txbxsyism
            // 
            this.txbxsyism.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbxsyism.BackColor = System.Drawing.Color.LightGray;
            this.txbxsyism.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbxsyism.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.txbxsyism.Location = new System.Drawing.Point(73, 200);
            this.txbxsyism.Margin = new System.Windows.Forms.Padding(2);
            this.txbxsyism.Multiline = true;
            this.txbxsyism.Name = "txbxsyism";
            this.txbxsyism.Size = new System.Drawing.Size(202, 32);
            this.txbxsyism.TabIndex = 66;
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
            this.geri.Location = new System.Drawing.Point(73, 386);
            this.geri.Margin = new System.Windows.Forms.Padding(2);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(202, 48);
            this.geri.TabIndex = 65;
            this.geri.Text = "Geri";
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 460);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(662, 22);
            this.statusBar1.TabIndex = 74;
            this.statusBar1.Text = "statusBar1";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "statusBarPanel1";
            this.statusBarPanel1.Width = 620;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bradley Hand ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(214, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 46);
            this.label1.TabIndex = 75;
            this.label1.Text = "Kisisel Bilgiler";
            // 
            // Kisisel_bilgiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Resource1.ana;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(662, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.txtkimlik_no);
            this.Controls.Add(this.txtbxemail);
            this.Controls.Add(this.txtbxtlfn);
            this.Controls.Add(this.btnkyt);
            this.Controls.Add(this.txtbxsfr);
            this.Controls.Add(this.txtbxadrs);
            this.Controls.Add(this.txbxism);
            this.Controls.Add(this.txbxsyism);
            this.Controls.Add(this.geri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Kisisel_bilgiler";
            this.Text = "Kisisel_bilgiler";
            this.Load += new System.EventHandler(this.Kisisel_bilgiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtkimlik_no;
        private System.Windows.Forms.TextBox txtbxemail;
        private System.Windows.Forms.TextBox txtbxtlfn;
        private System.Windows.Forms.Button btnkyt;
        private System.Windows.Forms.TextBox txtbxsfr;
        private System.Windows.Forms.TextBox txtbxadrs;
        private System.Windows.Forms.TextBox txbxism;
        private System.Windows.Forms.TextBox txbxsyism;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.Label label1;
    }
}