namespace WindowsFormsApp2
{
    partial class YntciAnaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YntciAnaMenu));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kisidznle = new System.Windows.Forms.Button();
            this.kisileriListele = new System.Windows.Forms.Button();
            this.kişiEkle = new System.Windows.Forms.Button();
            this.bölümleriListele = new System.Windows.Forms.Button();
            this.dersleriListele = new System.Windows.Forms.Button();
            this.dersVeyaBölümEkle = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.dersVeyaBölümduzenle = new System.Windows.Forms.Button();
            this.notGirisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusBar1
            // 
            resources.ApplyResources(this.statusBar1, "statusBar1");
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.ShowPanels = true;
            // 
            // statusBarPanel1
            // 
            resources.ApplyResources(this.statusBarPanel1, "statusBarPanel1");
            this.statusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // kisidznle
            // 
            this.kisidznle.BackColor = System.Drawing.Color.SeaGreen;
            this.kisidznle.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.kisidznle, "kisidznle");
            this.kisidznle.ForeColor = System.Drawing.Color.White;
            this.kisidznle.Name = "kisidznle";
            this.kisidznle.UseVisualStyleBackColor = false;
            this.kisidznle.Click += new System.EventHandler(this.kisidznle_Click);
            // 
            // kisileriListele
            // 
            this.kisileriListele.BackColor = System.Drawing.Color.SeaGreen;
            this.kisileriListele.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.kisileriListele, "kisileriListele");
            this.kisileriListele.ForeColor = System.Drawing.Color.White;
            this.kisileriListele.Name = "kisileriListele";
            this.kisileriListele.UseVisualStyleBackColor = false;
            this.kisileriListele.Click += new System.EventHandler(this.kisileriListele_Click);
            // 
            // kişiEkle
            // 
            this.kişiEkle.BackColor = System.Drawing.Color.SeaGreen;
            this.kişiEkle.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.kişiEkle, "kişiEkle");
            this.kişiEkle.ForeColor = System.Drawing.Color.White;
            this.kişiEkle.Name = "kişiEkle";
            this.kişiEkle.UseVisualStyleBackColor = false;
            this.kişiEkle.Click += new System.EventHandler(this.kişiEkle_Click);
            // 
            // bölümleriListele
            // 
            this.bölümleriListele.BackColor = System.Drawing.Color.SeaGreen;
            this.bölümleriListele.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.bölümleriListele, "bölümleriListele");
            this.bölümleriListele.ForeColor = System.Drawing.Color.White;
            this.bölümleriListele.Name = "bölümleriListele";
            this.bölümleriListele.UseVisualStyleBackColor = false;
            this.bölümleriListele.Click += new System.EventHandler(this.bölümleriListele_Click);
            // 
            // dersleriListele
            // 
            this.dersleriListele.BackColor = System.Drawing.Color.SeaGreen;
            this.dersleriListele.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.dersleriListele, "dersleriListele");
            this.dersleriListele.ForeColor = System.Drawing.Color.White;
            this.dersleriListele.Name = "dersleriListele";
            this.dersleriListele.UseVisualStyleBackColor = false;
            this.dersleriListele.Click += new System.EventHandler(this.dersleriListele_Click);
            // 
            // dersVeyaBölümEkle
            // 
            this.dersVeyaBölümEkle.BackColor = System.Drawing.Color.SeaGreen;
            this.dersVeyaBölümEkle.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.dersVeyaBölümEkle, "dersVeyaBölümEkle");
            this.dersVeyaBölümEkle.ForeColor = System.Drawing.Color.White;
            this.dersVeyaBölümEkle.Name = "dersVeyaBölümEkle";
            this.dersVeyaBölümEkle.UseVisualStyleBackColor = false;
            this.dersVeyaBölümEkle.Click += new System.EventHandler(this.dersVeyaBölümEkle_Click);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.SeaGreen;
            this.geri.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.geri, "geri");
            this.geri.ForeColor = System.Drawing.Color.White;
            this.geri.Name = "geri";
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // dersVeyaBölümduzenle
            // 
            this.dersVeyaBölümduzenle.BackColor = System.Drawing.Color.SeaGreen;
            this.dersVeyaBölümduzenle.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.dersVeyaBölümduzenle, "dersVeyaBölümduzenle");
            this.dersVeyaBölümduzenle.ForeColor = System.Drawing.Color.White;
            this.dersVeyaBölümduzenle.Name = "dersVeyaBölümduzenle";
            this.dersVeyaBölümduzenle.UseVisualStyleBackColor = false;
            this.dersVeyaBölümduzenle.Click += new System.EventHandler(this.dersVeyaBölümduzenle_Click);
            // 
            // notGirisi
            // 
            this.notGirisi.BackColor = System.Drawing.Color.SeaGreen;
            this.notGirisi.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.notGirisi, "notGirisi");
            this.notGirisi.ForeColor = System.Drawing.Color.White;
            this.notGirisi.Name = "notGirisi";
            this.notGirisi.UseVisualStyleBackColor = false;
            this.notGirisi.Click += new System.EventHandler(this.notGirisi_Click);
            // 
            // YntciAnaMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.Controls.Add(this.notGirisi);
            this.Controls.Add(this.dersVeyaBölümduzenle);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.dersVeyaBölümEkle);
            this.Controls.Add(this.dersleriListele);
            this.Controls.Add(this.bölümleriListele);
            this.Controls.Add(this.kişiEkle);
            this.Controls.Add(this.kisileriListele);
            this.Controls.Add(this.kisidznle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "YntciAnaMenu";
            this.Load += new System.EventHandler(this.YntciAnaMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button kisidznle;
        private System.Windows.Forms.Button kisileriListele;
        private System.Windows.Forms.Button kişiEkle;
        private System.Windows.Forms.Button bölümleriListele;
        private System.Windows.Forms.Button dersleriListele;
        private System.Windows.Forms.Button dersVeyaBölümEkle;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button dersVeyaBölümduzenle;
        private System.Windows.Forms.Button notGirisi;
    }
}