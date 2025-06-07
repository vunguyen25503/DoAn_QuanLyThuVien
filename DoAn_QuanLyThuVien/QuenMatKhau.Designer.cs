namespace DoAn_QuanLyThuVien
{
    partial class QuenMatKhau
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
            this.btnDangKy = new System.Windows.Forms.Button();
            this.txtacc = new System.Windows.Forms.TextBox();
            this.txtmkcu = new System.Windows.Forms.TextBox();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.txtxnmkmoi = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangKy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangKy.Location = new System.Drawing.Point(26, 434);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(411, 51);
            this.btnDangKy.TabIndex = 9;
            this.btnDangKy.Text = "Comfirm";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // txtacc
            // 
            this.txtacc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtacc.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtacc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtacc.Location = new System.Drawing.Point(26, 130);
            this.txtacc.Name = "txtacc";
            this.txtacc.ShortcutsEnabled = false;
            this.txtacc.Size = new System.Drawing.Size(411, 45);
            this.txtacc.TabIndex = 10;
            this.txtacc.Text = "Account";
            this.txtacc.Click += new System.EventHandler(this.txtacc_Click);
            // 
            // txtmkcu
            // 
            this.txtmkcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmkcu.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtmkcu.Location = new System.Drawing.Point(26, 206);
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.Size = new System.Drawing.Size(411, 45);
            this.txtmkcu.TabIndex = 11;
            this.txtmkcu.Tag = "";
            this.txtmkcu.Text = "Current Password";
            this.txtmkcu.WordWrap = false;
            this.txtmkcu.Click += new System.EventHandler(this.txtmkcu_Click);
            this.txtmkcu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtmkcu_MouseClick);
            // 
            // txtnewpass
            // 
            this.txtnewpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtnewpass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtnewpass.Location = new System.Drawing.Point(26, 282);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(411, 45);
            this.txtnewpass.TabIndex = 12;
            this.txtnewpass.Tag = "";
            this.txtnewpass.Text = "New Password";
            this.txtnewpass.WordWrap = false;
            this.txtnewpass.Click += new System.EventHandler(this.txtnewpass_Click);
            this.txtnewpass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtnewpass_MouseClick);
            // 
            // txtxnmkmoi
            // 
            this.txtxnmkmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtxnmkmoi.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtxnmkmoi.Location = new System.Drawing.Point(26, 358);
            this.txtxnmkmoi.Name = "txtxnmkmoi";
            this.txtxnmkmoi.Size = new System.Drawing.Size(411, 45);
            this.txtxnmkmoi.TabIndex = 13;
            this.txtxnmkmoi.Tag = "";
            this.txtxnmkmoi.Text = "Comfirm Password";
            this.txtxnmkmoi.WordWrap = false;
            this.txtxnmkmoi.Click += new System.EventHandler(this.txtxnmkmoi_Click);
            this.txtxnmkmoi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtxnmkmoi_MouseClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::DoAn_QuanLyThuVien.Properties.Resources.eye_password_hide_icon_512x512_iv45hct9__1_;
            this.button2.Location = new System.Drawing.Point(383, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 45);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = global::DoAn_QuanLyThuVien.Properties.Resources.eye_password_hide_icon_512x512_iv45hct9__1_;
            this.button1.Location = new System.Drawing.Point(383, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 45);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Image = global::DoAn_QuanLyThuVien.Properties.Resources.eye_password_hide_icon_512x512_iv45hct9__1_;
            this.button3.Location = new System.Drawing.Point(383, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 45);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 118);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHANGE PASSWORD";
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtxnmkmoi);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.txtmkcu);
            this.Controls.Add(this.txtacc);
            this.Controls.Add(this.btnDangKy);
            this.Name = "QuenMatKhau";
            this.Text = "Change password";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.TextBox txtacc;
        private System.Windows.Forms.TextBox txtmkcu;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.TextBox txtxnmkmoi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}