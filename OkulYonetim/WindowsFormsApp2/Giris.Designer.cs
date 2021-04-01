namespace WindowsFormsApp2
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOgrGrs = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkbxogr = new System.Windows.Forms.CheckBox();
            this.btnOgrSfrAl = new System.Windows.Forms.Button();
            this.txtBoxOgrsfr = new System.Windows.Forms.TextBox();
            this.txtBoxOgrGrs = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnYntciGiris = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkbxytk = new System.Windows.Forms.CheckBox();
            this.btnYntcSfrAl = new System.Windows.Forms.Button();
            this.txtBoxYntcsfr = new System.Windows.Forms.TextBox();
            this.txtBoxYntcGrs = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnOgrGrs);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkbxogr);
            this.panel1.Controls.Add(this.btnOgrSfrAl);
            this.panel1.Controls.Add(this.txtBoxOgrsfr);
            this.panel1.Controls.Add(this.txtBoxOgrGrs);
            this.panel1.Location = new System.Drawing.Point(47, 92);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 700);
            this.panel1.TabIndex = 4;
            // 
            // btnOgrGrs
            // 
            this.btnOgrGrs.BackColor = System.Drawing.Color.SeaGreen;
            this.btnOgrGrs.FlatAppearance.BorderSize = 0;
            this.btnOgrGrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrGrs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrGrs.ForeColor = System.Drawing.Color.White;
            this.btnOgrGrs.Location = new System.Drawing.Point(127, 321);
            this.btnOgrGrs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOgrGrs.Name = "btnOgrGrs";
            this.btnOgrGrs.Size = new System.Drawing.Size(300, 59);
            this.btnOgrGrs.TabIndex = 22;
            this.btnOgrGrs.Text = "GİRİŞ";
            this.btnOgrGrs.UseVisualStyleBackColor = false;
            this.btnOgrGrs.Click += new System.EventHandler(this.btnOgrGrs_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bradley Hand ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(117, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 50);
            this.label3.TabIndex = 21;
            this.label3.Text = "ÖGRENCI GIRISI";
            // 
            // checkbxogr
            // 
            this.checkbxogr.AutoSize = true;
            this.checkbxogr.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkbxogr.ForeColor = System.Drawing.Color.White;
            this.checkbxogr.Location = new System.Drawing.Point(127, 268);
            this.checkbxogr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkbxogr.Name = "checkbxogr";
            this.checkbxogr.Size = new System.Drawing.Size(130, 28);
            this.checkbxogr.TabIndex = 20;
            this.checkbxogr.Text = "Şifre Göster";
            this.checkbxogr.UseVisualStyleBackColor = true;
            this.checkbxogr.CheckedChanged += new System.EventHandler(this.checkbxogr_CheckedChanged);
            // 
            // btnOgrSfrAl
            // 
            this.btnOgrSfrAl.BackColor = System.Drawing.Color.SeaGreen;
            this.btnOgrSfrAl.FlatAppearance.BorderSize = 0;
            this.btnOgrSfrAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrSfrAl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrSfrAl.ForeColor = System.Drawing.Color.White;
            this.btnOgrSfrAl.Location = new System.Drawing.Point(127, 432);
            this.btnOgrSfrAl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOgrSfrAl.Name = "btnOgrSfrAl";
            this.btnOgrSfrAl.Size = new System.Drawing.Size(300, 59);
            this.btnOgrSfrAl.TabIndex = 19;
            this.btnOgrSfrAl.Text = "ŞİFREMİ UNUTTUM";
            this.btnOgrSfrAl.UseVisualStyleBackColor = false;
            this.btnOgrSfrAl.Click += new System.EventHandler(this.btnOgrSfrAl_Click);
            // 
            // txtBoxOgrsfr
            // 
            this.txtBoxOgrsfr.BackColor = System.Drawing.Color.LightGray;
            this.txtBoxOgrsfr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxOgrsfr.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxOgrsfr.Location = new System.Drawing.Point(127, 206);
            this.txtBoxOgrsfr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxOgrsfr.Multiline = true;
            this.txtBoxOgrsfr.Name = "txtBoxOgrsfr";
            this.txtBoxOgrsfr.Size = new System.Drawing.Size(300, 39);
            this.txtBoxOgrsfr.TabIndex = 16;
            this.txtBoxOgrsfr.Text = "Şifre";
            // 
            // txtBoxOgrGrs
            // 
            this.txtBoxOgrGrs.BackColor = System.Drawing.Color.LightGray;
            this.txtBoxOgrGrs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxOgrGrs.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxOgrGrs.Location = new System.Drawing.Point(127, 137);
            this.txtBoxOgrGrs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxOgrGrs.Multiline = true;
            this.txtBoxOgrGrs.Name = "txtBoxOgrGrs";
            this.txtBoxOgrGrs.Size = new System.Drawing.Size(300, 39);
            this.txtBoxOgrGrs.TabIndex = 15;
            this.txtBoxOgrGrs.Text = "Numara";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnYntciGiris);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.checkbxytk);
            this.panel2.Controls.Add(this.btnYntcSfrAl);
            this.panel2.Controls.Add(this.txtBoxYntcsfr);
            this.panel2.Controls.Add(this.txtBoxYntcGrs);
            this.panel2.Location = new System.Drawing.Point(661, 92);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 700);
            this.panel2.TabIndex = 5;
            this.panel2.TabStop = true;
            // 
            // btnYntciGiris
            // 
            this.btnYntciGiris.BackColor = System.Drawing.Color.SeaGreen;
            this.btnYntciGiris.FlatAppearance.BorderSize = 0;
            this.btnYntciGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYntciGiris.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYntciGiris.ForeColor = System.Drawing.Color.White;
            this.btnYntciGiris.Location = new System.Drawing.Point(127, 321);
            this.btnYntciGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYntciGiris.Name = "btnYntciGiris";
            this.btnYntciGiris.Size = new System.Drawing.Size(300, 59);
            this.btnYntciGiris.TabIndex = 23;
            this.btnYntciGiris.Text = "GİRİŞ";
            this.btnYntciGiris.UseVisualStyleBackColor = false;
            this.btnYntciGiris.Click += new System.EventHandler(this.btnYntciGiris_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bradley Hand ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(129, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 50);
            this.label4.TabIndex = 22;
            this.label4.Text = "YETKILI GIRISI";
            // 
            // checkbxytk
            // 
            this.checkbxytk.AutoSize = true;
            this.checkbxytk.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkbxytk.ForeColor = System.Drawing.Color.White;
            this.checkbxytk.Location = new System.Drawing.Point(139, 268);
            this.checkbxytk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkbxytk.Name = "checkbxytk";
            this.checkbxytk.Size = new System.Drawing.Size(130, 28);
            this.checkbxytk.TabIndex = 21;
            this.checkbxytk.Text = "Şifre Göster";
            this.checkbxytk.UseVisualStyleBackColor = true;
            this.checkbxytk.CheckedChanged += new System.EventHandler(this.checkbxytk_CheckedChanged);
            // 
            // btnYntcSfrAl
            // 
            this.btnYntcSfrAl.BackColor = System.Drawing.Color.SeaGreen;
            this.btnYntcSfrAl.FlatAppearance.BorderSize = 0;
            this.btnYntcSfrAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYntcSfrAl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYntcSfrAl.ForeColor = System.Drawing.Color.White;
            this.btnYntcSfrAl.Location = new System.Drawing.Point(127, 432);
            this.btnYntcSfrAl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYntcSfrAl.Name = "btnYntcSfrAl";
            this.btnYntcSfrAl.Size = new System.Drawing.Size(300, 59);
            this.btnYntcSfrAl.TabIndex = 18;
            this.btnYntcSfrAl.Text = "ŞİFREMİ UNUTTUM";
            this.btnYntcSfrAl.UseVisualStyleBackColor = false;
            this.btnYntcSfrAl.Click += new System.EventHandler(this.btnYntcSfrAl_Click);
            // 
            // txtBoxYntcsfr
            // 
            this.txtBoxYntcsfr.BackColor = System.Drawing.Color.LightGray;
            this.txtBoxYntcsfr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxYntcsfr.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxYntcsfr.Location = new System.Drawing.Point(127, 206);
            this.txtBoxYntcsfr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxYntcsfr.Multiline = true;
            this.txtBoxYntcsfr.Name = "txtBoxYntcsfr";
            this.txtBoxYntcsfr.Size = new System.Drawing.Size(300, 39);
            this.txtBoxYntcsfr.TabIndex = 17;
            this.txtBoxYntcsfr.TabStop = false;
            this.txtBoxYntcsfr.Text = "Şifre";
            // 
            // txtBoxYntcGrs
            // 
            this.txtBoxYntcGrs.BackColor = System.Drawing.Color.LightGray;
            this.txtBoxYntcGrs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxYntcGrs.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxYntcGrs.Location = new System.Drawing.Point(127, 137);
            this.txtBoxYntcGrs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxYntcGrs.Multiline = true;
            this.txtBoxYntcGrs.Name = "txtBoxYntcGrs";
            this.txtBoxYntcGrs.Size = new System.Drawing.Size(300, 39);
            this.txtBoxYntcGrs.TabIndex = 14;
            this.txtBoxYntcGrs.Text = "Numara";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 829);
            this.statusBar1.Margin = new System.Windows.Forms.Padding(4);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(1245, 46);
            this.statusBar1.TabIndex = 10;
            this.statusBar1.Text = "statusBar1";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "statusBarPanel1";
            this.statusBarPanel1.Width = 900;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1245, 875);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Giris";
            this.Text = "Okul Yönetim Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    
        private System.Windows.Forms.TextBox txtBoxYntcGrs;
        private System.Windows.Forms.TextBox txtBoxOgrsfr;
        private System.Windows.Forms.TextBox txtBoxOgrGrs;
        private System.Windows.Forms.TextBox txtBoxYntcsfr;
        private System.Windows.Forms.Button btnYntcSfrAl;
        private System.Windows.Forms.Button btnOgrSfrAl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkbxogr;
        private System.Windows.Forms.CheckBox checkbxytk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.Button btnOgrGrs;
        private System.Windows.Forms.Button btnYntciGiris;
    }
}