namespace Digitalizacion_3000_Empleados
{
    partial class Loging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loging));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logg = new System.Windows.Forms.Button();
            this.btnclosed = new System.Windows.Forms.PictureBox();
            this.btnminus = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(44, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(39, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "MUNICIPALITY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(302, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "_____________________________________________________________________";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textuser
            // 
            this.textuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textuser.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textuser.ForeColor = System.Drawing.Color.DimGray;
            this.textuser.Location = new System.Drawing.Point(305, 88);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(418, 20);
            this.textuser.TabIndex = 2;
            this.textuser.Text = "USER";
            this.textuser.TextChanged += new System.EventHandler(this.label3_Click);
            this.textuser.Enter += new System.EventHandler(this.textuser_Enter);
            this.textuser.Leave += new System.EventHandler(this.textuser_Leave);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtpass.ForeColor = System.Drawing.Color.DimGray;
            this.txtpass.Location = new System.Drawing.Point(305, 179);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(418, 20);
            this.txtpass.TabIndex = 4;
            this.txtpass.Text = "PASSWORD";
            this.txtpass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(302, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "_____________________________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(452, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "LOGING";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // logg
            // 
            this.logg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.logg.FlatAppearance.BorderSize = 0;
            this.logg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.logg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logg.ForeColor = System.Drawing.Color.LightGray;
            this.logg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logg.Location = new System.Drawing.Point(305, 251);
            this.logg.Name = "logg";
            this.logg.Size = new System.Drawing.Size(408, 40);
            this.logg.TabIndex = 6;
            this.logg.Text = "ACCESS";
            this.logg.UseVisualStyleBackColor = false;
            this.logg.Click += new System.EventHandler(this.logg_Click);
            // 
            // btnclosed
            // 
            this.btnclosed.BackColor = System.Drawing.Color.DarkGray;
            this.btnclosed.Image = ((System.Drawing.Image)(resources.GetObject("btnclosed.Image")));
            this.btnclosed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnclosed.Location = new System.Drawing.Point(764, 0);
            this.btnclosed.Name = "btnclosed";
            this.btnclosed.Size = new System.Drawing.Size(15, 15);
            this.btnclosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclosed.TabIndex = 7;
            this.btnclosed.TabStop = false;
            this.btnclosed.Click += new System.EventHandler(this.btnclosed_Click);
            // 
            // btnminus
            // 
            this.btnminus.BackColor = System.Drawing.Color.DarkGray;
            this.btnminus.Image = ((System.Drawing.Image)(resources.GetObject("btnminus.Image")));
            this.btnminus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnminus.Location = new System.Drawing.Point(743, 0);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(15, 15);
            this.btnminus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminus.TabIndex = 8;
            this.btnminus.TabStop = false;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // Loging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnclosed);
            this.Controls.Add(this.logg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loging";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loging";
            this.Load += new System.EventHandler(this.Loging_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Loging_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logg;
        private System.Windows.Forms.PictureBox btnclosed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnminus;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}