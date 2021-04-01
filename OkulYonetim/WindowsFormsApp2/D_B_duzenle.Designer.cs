namespace WindowsFormsApp2
{
    partial class D_B_duzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(D_B_duzenle));
            this.btngeri = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.rdbBlm = new System.Windows.Forms.RadioButton();
            this.rdb_Ders = new System.Windows.Forms.RadioButton();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtKredi = new System.Windows.Forms.TextBox();
            this.txtAkts = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // btngeri
            // 
            this.btngeri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btngeri.BackColor = System.Drawing.Color.SeaGreen;
            this.btngeri.FlatAppearance.BorderSize = 0;
            this.btngeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngeri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngeri.ForeColor = System.Drawing.Color.White;
            this.btngeri.Location = new System.Drawing.Point(92, 487);
            this.btngeri.Margin = new System.Windows.Forms.Padding(2);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(193, 48);
            this.btngeri.TabIndex = 49;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnkaydet.BackColor = System.Drawing.Color.SeaGreen;
            this.btnkaydet.FlatAppearance.BorderSize = 0;
            this.btnkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkaydet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.ForeColor = System.Drawing.Color.White;
            this.btnkaydet.Location = new System.Drawing.Point(394, 487);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(193, 48);
            this.btnkaydet.TabIndex = 48;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // rdbBlm
            // 
            this.rdbBlm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbBlm.AutoSize = true;
            this.rdbBlm.BackColor = System.Drawing.Color.Transparent;
            this.rdbBlm.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.rdbBlm.ForeColor = System.Drawing.Color.White;
            this.rdbBlm.Location = new System.Drawing.Point(331, 307);
            this.rdbBlm.Margin = new System.Windows.Forms.Padding(2);
            this.rdbBlm.Name = "rdbBlm";
            this.rdbBlm.Size = new System.Drawing.Size(89, 31);
            this.rdbBlm.TabIndex = 47;
            this.rdbBlm.Text = "Bölüm";
            this.rdbBlm.UseVisualStyleBackColor = false;
            // 
            // rdb_Ders
            // 
            this.rdb_Ders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdb_Ders.AutoSize = true;
            this.rdb_Ders.BackColor = System.Drawing.Color.Transparent;
            this.rdb_Ders.Checked = true;
            this.rdb_Ders.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.rdb_Ders.ForeColor = System.Drawing.Color.White;
            this.rdb_Ders.Location = new System.Drawing.Point(331, 259);
            this.rdb_Ders.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_Ders.Name = "rdb_Ders";
            this.rdb_Ders.Size = new System.Drawing.Size(72, 31);
            this.rdb_Ders.TabIndex = 46;
            this.rdb_Ders.TabStop = true;
            this.rdb_Ders.Text = "Ders";
            this.rdb_Ders.UseVisualStyleBackColor = false;
            // 
            // txtIsim
            // 
            this.txtIsim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIsim.BackColor = System.Drawing.Color.LightGray;
            this.txtIsim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIsim.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsim.Location = new System.Drawing.Point(331, 206);
            this.txtIsim.Margin = new System.Windows.Forms.Padding(2);
            this.txtIsim.Multiline = true;
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(310, 33);
            this.txtIsim.TabIndex = 45;
            this.txtIsim.Text = "İsim";
            // 
            // txtKredi
            // 
            this.txtKredi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKredi.BackColor = System.Drawing.Color.LightGray;
            this.txtKredi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKredi.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKredi.Location = new System.Drawing.Point(92, 270);
            this.txtKredi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKredi.Multiline = true;
            this.txtKredi.Name = "txtKredi";
            this.txtKredi.Size = new System.Drawing.Size(193, 33);
            this.txtKredi.TabIndex = 44;
            this.txtKredi.Text = "Kredi";
            // 
            // txtAkts
            // 
            this.txtAkts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAkts.BackColor = System.Drawing.Color.LightGray;
            this.txtAkts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAkts.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAkts.Location = new System.Drawing.Point(92, 337);
            this.txtAkts.Margin = new System.Windows.Forms.Padding(2);
            this.txtAkts.Multiline = true;
            this.txtAkts.Name = "txtAkts";
            this.txtAkts.Size = new System.Drawing.Size(193, 33);
            this.txtAkts.TabIndex = 43;
            this.txtAkts.Text = "Akts";
            // 
            // txtid
            // 
            this.txtid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtid.BackColor = System.Drawing.Color.LightGray;
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtid.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Location = new System.Drawing.Point(92, 203);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(193, 33);
            this.txtid.TabIndex = 52;
            this.txtid.Text = "Id Girin";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(92, 419);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 48);
            this.button1.TabIndex = 53;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(394, 419);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 48);
            this.button2.TabIndex = 54;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 591);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(684, 38);
            this.statusBar1.TabIndex = 55;
            this.statusBar1.Text = "statusBar1";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "statusBarPanel1";
            this.statusBarPanel1.Width = 650;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bradley Hand ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(142, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 46);
            this.label1.TabIndex = 56;
            this.label1.Text = "Ders ve Bölüm Düzenleme";
            // 
            // D_B_duzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Resource1.ana;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.rdbBlm);
            this.Controls.Add(this.rdb_Ders);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.txtKredi);
            this.Controls.Add(this.txtAkts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "D_B_duzenle";
            this.Text = "Okul Yönetim Sistemi";
            this.Load += new System.EventHandler(this.D_B_duzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.RadioButton rdbBlm;
        private System.Windows.Forms.RadioButton rdb_Ders;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtKredi;
        private System.Windows.Forms.TextBox txtAkts;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.Label label1;
    }
}