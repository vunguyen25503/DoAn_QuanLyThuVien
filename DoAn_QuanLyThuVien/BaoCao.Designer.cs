namespace DoAn_QuanLyThuVien
{
    partial class BaoCao
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MaBaoCao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChatLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoSung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HuySach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.laber2 = new System.Windows.Forms.Label();
            this.laber1 = new System.Windows.Forms.Label();
            this.combChatLuong = new System.Windows.Forms.ComboBox();
            this.txttimkiemsach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaBaoCao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoSung = new System.Windows.Forms.TextBox();
            this.txtHuySach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBaoCao,
            this.MaSach,
            this.TenSach,
            this.ChatLuong,
            this.SoLuong,
            this.BoSung,
            this.HuySach});
            this.dataGridView2.Location = new System.Drawing.Point(15, 253);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(803, 281);
            this.dataGridView2.TabIndex = 22;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // MaBaoCao
            // 
            this.MaBaoCao.DataPropertyName = "MaBaoCao";
            this.MaBaoCao.HeaderText = "Mã báo cáo";
            this.MaBaoCao.MinimumWidth = 6;
            this.MaBaoCao.Name = "MaBaoCao";
            this.MaBaoCao.Width = 125;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 125;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 125;
            // 
            // ChatLuong
            // 
            this.ChatLuong.DataPropertyName = "ChatLuong";
            this.ChatLuong.HeaderText = "Chất lượng";
            this.ChatLuong.MinimumWidth = 6;
            this.ChatLuong.Name = "ChatLuong";
            this.ChatLuong.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // BoSung
            // 
            this.BoSung.DataPropertyName = "BoSung";
            this.BoSung.HeaderText = "Bổ sung";
            this.BoSung.MinimumWidth = 6;
            this.BoSung.Name = "BoSung";
            this.BoSung.Width = 125;
            // 
            // HuySach
            // 
            this.HuySach.DataPropertyName = "HuySach";
            this.HuySach.HeaderText = "Huỷ sách";
            this.HuySach.MinimumWidth = 6;
            this.HuySach.Name = "HuySach";
            this.HuySach.Width = 125;
            // 
            // txttensach
            // 
            this.txttensach.Location = new System.Drawing.Point(115, 110);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(236, 22);
            this.txttensach.TabIndex = 26;
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(115, 65);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(236, 22);
            this.txtmasach.TabIndex = 25;
            // 
            // laber2
            // 
            this.laber2.AutoSize = true;
            this.laber2.Location = new System.Drawing.Point(12, 110);
            this.laber2.Name = "laber2";
            this.laber2.Size = new System.Drawing.Size(63, 16);
            this.laber2.TabIndex = 24;
            this.laber2.Text = "Tên sách";
            // 
            // laber1
            // 
            this.laber1.AutoSize = true;
            this.laber1.Location = new System.Drawing.Point(12, 65);
            this.laber1.Name = "laber1";
            this.laber1.Size = new System.Drawing.Size(60, 16);
            this.laber1.TabIndex = 23;
            this.laber1.Text = "Mã Sách";
            // 
            // combChatLuong
            // 
            this.combChatLuong.FormattingEnabled = true;
            this.combChatLuong.Items.AddRange(new object[] {
            "mới",
            "cũ",
            "bình thường"});
            this.combChatLuong.Location = new System.Drawing.Point(115, 155);
            this.combChatLuong.Name = "combChatLuong";
            this.combChatLuong.Size = new System.Drawing.Size(236, 24);
            this.combChatLuong.TabIndex = 37;
            // 
            // txttimkiemsach
            // 
            this.txttimkiemsach.Location = new System.Drawing.Point(557, 155);
            this.txttimkiemsach.Name = "txttimkiemsach";
            this.txttimkiemsach.Size = new System.Drawing.Size(236, 22);
            this.txttimkiemsach.TabIndex = 35;
            this.txttimkiemsach.TextChanged += new System.EventHandler(this.txttimkiemsach_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tìm kiếm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(557, 14);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(236, 22);
            this.txtsl.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Chất lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mã báo cáo";
            // 
            // txtmaBaoCao
            // 
            this.txtmaBaoCao.Location = new System.Drawing.Point(115, 20);
            this.txtmaBaoCao.Name = "txtmaBaoCao";
            this.txtmaBaoCao.Size = new System.Drawing.Size(236, 22);
            this.txtmaBaoCao.TabIndex = 39;
            this.txtmaBaoCao.TextChanged += new System.EventHandler(this.txtBaoCao_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Bổ sung";
            // 
            // txtBoSung
            // 
            this.txtBoSung.Location = new System.Drawing.Point(557, 61);
            this.txtBoSung.Name = "txtBoSung";
            this.txtBoSung.Size = new System.Drawing.Size(236, 22);
            this.txtBoSung.TabIndex = 41;
            // 
            // txtHuySach
            // 
            this.txtHuySach.Location = new System.Drawing.Point(557, 108);
            this.txtHuySach.Name = "txtHuySach";
            this.txtHuySach.Size = new System.Drawing.Size(236, 22);
            this.txtHuySach.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Huỷ sách";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Wheat;
            this.btnthoat.Location = new System.Drawing.Point(745, 209);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(82, 38);
            this.btnthoat.TabIndex = 48;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.Wheat;
            this.btntimkiem.Location = new System.Drawing.Point(567, 209);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(82, 38);
            this.btntimkiem.TabIndex = 47;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Wheat;
            this.btnXoa.Location = new System.Drawing.Point(401, 209);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 38);
            this.btnXoa.TabIndex = 46;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Wheat;
            this.btnSua.Location = new System.Drawing.Point(179, 209);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 38);
            this.btnSua.TabIndex = 45;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Wheat;
            this.btnThem.Location = new System.Drawing.Point(9, 209);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 38);
            this.btnThem.TabIndex = 44;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(839, 546);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtHuySach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoSung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmaBaoCao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combChatLuong);
            this.Controls.Add(this.txttimkiemsach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttensach);
            this.Controls.Add(this.txtmasach);
            this.Controls.Add(this.laber2);
            this.Controls.Add(this.laber1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "BaoCao";
            this.Text = "BaoCao";
            this.Load += new System.EventHandler(this.BaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBaoCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChatLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoSung;
        private System.Windows.Forms.DataGridViewTextBoxColumn HuySach;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.Label laber2;
        private System.Windows.Forms.Label laber1;
        private System.Windows.Forms.ComboBox combChatLuong;
        private System.Windows.Forms.TextBox txttimkiemsach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaBaoCao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoSung;
        private System.Windows.Forms.TextBox txtHuySach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}