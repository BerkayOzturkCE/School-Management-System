namespace WindowsFormsApp2
{
    partial class Ders_Bolum_ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ders_Bolum_ekle));
            this.txtAkts = new System.Windows.Forms.TextBox();
            this.txtKredi = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.rdb_Ders = new System.Windows.Forms.RadioButton();
            this.rdbBlm = new System.Windows.Forms.RadioButton();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.cmbxbolum = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAkts
            // 
            this.txtAkts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAkts.BackColor = System.Drawing.Color.LightGray;
            this.txtAkts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAkts.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAkts.Location = new System.Drawing.Point(70, 310);
            this.txtAkts.Margin = new System.Windows.Forms.Padding(2);
            this.txtAkts.Multiline = true;
            this.txtAkts.Name = "txtAkts";
            this.txtAkts.Size = new System.Drawing.Size(193, 33);
            this.txtAkts.TabIndex = 34;
            this.txtAkts.Text = "Akts";
            // 
            // txtKredi
            // 
            this.txtKredi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKredi.BackColor = System.Drawing.Color.LightGray;
            this.txtKredi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKredi.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKredi.Location = new System.Drawing.Point(70, 245);
            this.txtKredi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKredi.Multiline = true;
            this.txtKredi.Name = "txtKredi";
            this.txtKredi.Size = new System.Drawing.Size(193, 33);
            this.txtKredi.TabIndex = 35;
            this.txtKredi.Text = "Kredi";
            // 
            // txtIsim
            // 
            this.txtIsim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIsim.BackColor = System.Drawing.Color.LightGray;
            this.txtIsim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIsim.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsim.Location = new System.Drawing.Point(70, 168);
            this.txtIsim.Margin = new System.Windows.Forms.Padding(2);
            this.txtIsim.Multiline = true;
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(310, 33);
            this.txtIsim.TabIndex = 36;
            this.txtIsim.Text = "İsim";
            // 
            // rdb_Ders
            // 
            this.rdb_Ders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdb_Ders.AutoSize = true;
            this.rdb_Ders.BackColor = System.Drawing.Color.Transparent;
            this.rdb_Ders.Checked = true;
            this.rdb_Ders.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.rdb_Ders.ForeColor = System.Drawing.Color.White;
            this.rdb_Ders.Location = new System.Drawing.Point(411, 245);
            this.rdb_Ders.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_Ders.Name = "rdb_Ders";
            this.rdb_Ders.Size = new System.Drawing.Size(72, 31);
            this.rdb_Ders.TabIndex = 37;
            this.rdb_Ders.TabStop = true;
            this.rdb_Ders.Text = "Ders";
            this.rdb_Ders.UseVisualStyleBackColor = false;
            this.rdb_Ders.CheckedChanged += new System.EventHandler(this.rdb_Ders_CheckedChanged);
            // 
            // rdbBlm
            // 
            this.rdbBlm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbBlm.AutoSize = true;
            this.rdbBlm.BackColor = System.Drawing.Color.Transparent;
            this.rdbBlm.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.rdbBlm.ForeColor = System.Drawing.Color.White;
            this.rdbBlm.Location = new System.Drawing.Point(411, 310);
            this.rdbBlm.Margin = new System.Windows.Forms.Padding(2);
            this.rdbBlm.Name = "rdbBlm";
            this.rdbBlm.Size = new System.Drawing.Size(89, 31);
            this.rdbBlm.TabIndex = 38;
            this.rdbBlm.Text = "Bölüm";
            this.rdbBlm.UseVisualStyleBackColor = false;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnkaydet.BackColor = System.Drawing.Color.SeaGreen;
            this.btnkaydet.FlatAppearance.BorderSize = 0;
            this.btnkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkaydet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.ForeColor = System.Drawing.Color.White;
            this.btnkaydet.Location = new System.Drawing.Point(402, 409);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(194, 48);
            this.btnkaydet.TabIndex = 39;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btngeri
            // 
            this.btngeri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btngeri.BackColor = System.Drawing.Color.SeaGreen;
            this.btngeri.FlatAppearance.BorderSize = 0;
            this.btngeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngeri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngeri.ForeColor = System.Drawing.Color.White;
            this.btngeri.Location = new System.Drawing.Point(70, 409);
            this.btngeri.Margin = new System.Windows.Forms.Padding(2);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(193, 48);
            this.btngeri.TabIndex = 40;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // cmbxbolum
            // 
            this.cmbxbolum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbxbolum.BackColor = System.Drawing.Color.LightGray;
            this.cmbxbolum.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.cmbxbolum.FormattingEnabled = true;
            this.cmbxbolum.Location = new System.Drawing.Point(402, 165);
            this.cmbxbolum.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxbolum.Name = "cmbxbolum";
            this.cmbxbolum.Size = new System.Drawing.Size(194, 35);
            this.cmbxbolum.TabIndex = 41;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 492);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(662, 26);
            this.statusBar1.TabIndex = 42;
            this.statusBar1.Text = "statusBar1";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "statusBarPanel1";
            this.statusBarPanel1.Width = 630;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bradley Hand ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(160, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 46);
            this.label1.TabIndex = 43;
            this.label1.Text = "Ders veya Bölüm Ekle";
            // 
            // Ders_Bolum_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Resource1.ana;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(662, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.cmbxbolum);
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
            this.Name = "Ders_Bolum_ekle";
            this.Text = "Okul Yönetim Sistemi";
            this.Load += new System.EventHandler(this.Ders_Bolum_ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAkts;
        private System.Windows.Forms.TextBox txtKredi;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.RadioButton rdb_Ders;
        private System.Windows.Forms.RadioButton rdbBlm;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.ComboBox cmbxbolum;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.Label label1;
    }
}