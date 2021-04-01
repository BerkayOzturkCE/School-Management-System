namespace WindowsFormsApp2
{
    partial class yazdir
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
            this.dGwogr = new System.Windows.Forms.DataGridView();
            this.btngeri = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dGwogr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // dGwogr
            // 
            this.dGwogr.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dGwogr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGwogr.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dGwogr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGwogr.GridColor = System.Drawing.SystemColors.Control;
            this.dGwogr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dGwogr.Location = new System.Drawing.Point(9, 34);
            this.dGwogr.Margin = new System.Windows.Forms.Padding(2);
            this.dGwogr.Name = "dGwogr";
            this.dGwogr.ReadOnly = true;
            this.dGwogr.RowHeadersWidth = 51;
            this.dGwogr.RowTemplate.Height = 24;
            this.dGwogr.Size = new System.Drawing.Size(644, 312);
            this.dGwogr.TabIndex = 0;
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.SeaGreen;
            this.btngeri.FlatAppearance.BorderSize = 0;
            this.btngeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngeri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngeri.ForeColor = System.Drawing.Color.White;
            this.btngeri.Location = new System.Drawing.Point(9, 369);
            this.btngeri.Margin = new System.Windows.Forms.Padding(2);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(193, 48);
            this.btngeri.TabIndex = 29;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 453);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(662, 28);
            this.statusBar1.TabIndex = 30;
            this.statusBar1.Text = "statusBar1";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "statusBarPanel1";
            this.statusBarPanel1.Width = 630;
            // 
            // yazdir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Resource1.ana;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(662, 481);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.dGwogr);
            this.Controls.Add(this.btngeri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "yazdir";
            this.Text = "yazdir";
            this.Load += new System.EventHandler(this.yazdir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGwogr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGwogr;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
    }
}