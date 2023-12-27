namespace PemesananTiketBus
{
    partial class LoginSuccesForm
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
            this.keberangkatan = new System.Windows.Forms.Button();
            this.penumpang = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbkelas = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboTujuan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboAsalkota = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tgl = new System.Windows.Forms.DateTimePicker();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // keberangkatan
            // 
            this.keberangkatan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.keberangkatan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.keberangkatan.Location = new System.Drawing.Point(733, 422);
            this.keberangkatan.Name = "keberangkatan";
            this.keberangkatan.Size = new System.Drawing.Size(226, 44);
            this.keberangkatan.TabIndex = 6;
            this.keberangkatan.Text = "Cari Keberangkatan";
            this.keberangkatan.UseVisualStyleBackColor = false;
            this.keberangkatan.Click += new System.EventHandler(this.button1_Click);
            // 
            // penumpang
            // 
            this.penumpang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.penumpang.BorderRadius = 6;
            this.penumpang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.penumpang.DefaultText = "";
            this.penumpang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.penumpang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.penumpang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.penumpang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.penumpang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.penumpang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.penumpang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.penumpang.ForeColor = System.Drawing.Color.DarkGray;
            this.penumpang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.penumpang.Location = new System.Drawing.Point(706, 307);
            this.penumpang.Name = "penumpang";
            this.penumpang.PasswordChar = '\0';
            this.penumpang.PlaceholderText = "";
            this.penumpang.SelectedText = "";
            this.penumpang.Size = new System.Drawing.Size(277, 38);
            this.penumpang.TabIndex = 45;
            // 
            // cbkelas
            // 
            this.cbkelas.BackColor = System.Drawing.Color.Transparent;
            this.cbkelas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbkelas.BorderRadius = 8;
            this.cbkelas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbkelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkelas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.cbkelas.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbkelas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbkelas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbkelas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbkelas.ItemHeight = 30;
            this.cbkelas.Location = new System.Drawing.Point(706, 371);
            this.cbkelas.Name = "cbkelas";
            this.cbkelas.Size = new System.Drawing.Size(277, 36);
            this.cbkelas.TabIndex = 44;
            // 
            // cboTujuan
            // 
            this.cboTujuan.BackColor = System.Drawing.Color.Transparent;
            this.cboTujuan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cboTujuan.BorderRadius = 8;
            this.cboTujuan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTujuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTujuan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.cboTujuan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTujuan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTujuan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTujuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cboTujuan.ItemHeight = 30;
            this.cboTujuan.Location = new System.Drawing.Point(706, 161);
            this.cboTujuan.Name = "cboTujuan";
            this.cboTujuan.Size = new System.Drawing.Size(277, 36);
            this.cboTujuan.TabIndex = 43;
            // 
            // cboAsalkota
            // 
            this.cboAsalkota.BackColor = System.Drawing.Color.Transparent;
            this.cboAsalkota.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cboAsalkota.BorderRadius = 8;
            this.cboAsalkota.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboAsalkota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAsalkota.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.cboAsalkota.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboAsalkota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboAsalkota.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboAsalkota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cboAsalkota.ItemHeight = 30;
            this.cboAsalkota.Location = new System.Drawing.Point(706, 99);
            this.cboAsalkota.Name = "cboAsalkota";
            this.cboAsalkota.Size = new System.Drawing.Size(277, 36);
            this.cboAsalkota.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(702, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Kelas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(702, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Penumpang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(702, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(702, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tanggal Keberangkatan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(702, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Ke";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(702, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Dari";
            // 
            // tgl
            // 
            this.tgl.CustomFormat = "MM/dd/yy";
            this.tgl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tgl.Location = new System.Drawing.Point(706, 236);
            this.tgl.Name = "tgl";
            this.tgl.Size = new System.Drawing.Size(277, 26);
            this.tgl.TabIndex = 35;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(702, 27);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(223, 31);
            this.guna2HtmlLabel1.TabIndex = 47;
            this.guna2HtmlLabel1.Text = "Detail Pembayaran";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::PemesananTiketBus.Properties.Resources.chris_wong_gBarvYyHUpU_unsplash;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(699, 514);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 46;
            this.guna2PictureBox1.TabStop = false;
            // 
            // LoginSuccesForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1048, 514);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.penumpang);
            this.Controls.Add(this.cbkelas);
            this.Controls.Add(this.cboTujuan);
            this.Controls.Add(this.cboAsalkota);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tgl);
            this.Controls.Add(this.keberangkatan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LoginSuccesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginSuccesForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button keberangkatan;
        private Guna.UI2.WinForms.Guna2TextBox penumpang;
        private Guna.UI2.WinForms.Guna2ComboBox cbkelas;
        private Guna.UI2.WinForms.Guna2ComboBox cboTujuan;
        private Guna.UI2.WinForms.Guna2ComboBox cboAsalkota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tgl;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}