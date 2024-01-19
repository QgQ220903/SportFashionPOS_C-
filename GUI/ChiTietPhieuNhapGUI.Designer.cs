namespace GUI
{
    partial class ChiTietPhieuNhapGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietPhieuNhapGUI));
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            panel2 = new Panel();
            label2 = new Label();
            btnPDF = new Button();
            danhSachChiPhieuNhap = new DataGridView();
            MaChiTietPhieuNhap = new DataGridViewTextBoxColumn();
            MaPhieuNhap = new DataGridViewTextBoxColumn();
            MaSanPham = new DataGridViewTextBoxColumn();
            MauSac = new DataGridViewTextBoxColumn();
            MaKichCo = new DataGridViewTextBoxColumn();
            SoLuongNhap = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            TienNhap = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachChiPhieuNhap).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1600, 100);
            panel2.TabIndex = 70;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(632, 30);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(279, 37);
            label2.TabIndex = 0;
            label2.Text = "Chi Tiết Phiếu Nhập";
            // 
            // btnPDF
            // 
            btnPDF.Image = (Image)resources.GetObject("btnPDF.Image");
            btnPDF.Location = new Point(1521, 720);
            btnPDF.Margin = new Padding(4);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(66, 73);
            btnPDF.TabIndex = 72;
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Visible = false;
            btnPDF.Click += btnPDF_Click;
            // 
            // danhSachChiPhieuNhap
            // 
            danhSachChiPhieuNhap.AllowUserToAddRows = false;
            danhSachChiPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachChiPhieuNhap.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachChiPhieuNhap.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachChiPhieuNhap.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            danhSachChiPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            danhSachChiPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachChiPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { MaChiTietPhieuNhap, MaPhieuNhap, MaSanPham, MauSac, MaKichCo, SoLuongNhap, DonVi, TienNhap, ThanhTien });
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = SystemColors.Window;
            dataGridViewCellStyle22.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle22.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.False;
            danhSachChiPhieuNhap.DefaultCellStyle = dataGridViewCellStyle22;
            danhSachChiPhieuNhap.Location = new Point(0, 99);
            danhSachChiPhieuNhap.Margin = new Padding(2);
            danhSachChiPhieuNhap.Name = "danhSachChiPhieuNhap";
            danhSachChiPhieuNhap.RowHeadersWidth = 62;
            danhSachChiPhieuNhap.RowTemplate.Height = 33;
            danhSachChiPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachChiPhieuNhap.Size = new Size(1600, 615);
            danhSachChiPhieuNhap.TabIndex = 71;
            danhSachChiPhieuNhap.CellContentClick += danhSachChiPhieuNhap_CellContentClick;
            // 
            // MaChiTietPhieuNhap
            // 
            dataGridViewCellStyle13.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle13.SelectionForeColor = Color.White;
            MaChiTietPhieuNhap.DefaultCellStyle = dataGridViewCellStyle13;
            MaChiTietPhieuNhap.HeaderText = "Mã chi tiết";
            MaChiTietPhieuNhap.MinimumWidth = 8;
            MaChiTietPhieuNhap.Name = "MaChiTietPhieuNhap";
            // 
            // MaPhieuNhap
            // 
            MaPhieuNhap.DataPropertyName = "MaPhieuNhap";
            dataGridViewCellStyle14.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle14.SelectionForeColor = Color.White;
            MaPhieuNhap.DefaultCellStyle = dataGridViewCellStyle14;
            MaPhieuNhap.HeaderText = "Tên phiếu";
            MaPhieuNhap.MinimumWidth = 8;
            MaPhieuNhap.Name = "MaPhieuNhap";
            // 
            // MaSanPham
            // 
            MaSanPham.DataPropertyName = "MaSanPham";
            dataGridViewCellStyle15.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle15.SelectionForeColor = Color.White;
            MaSanPham.DefaultCellStyle = dataGridViewCellStyle15;
            MaSanPham.HeaderText = "Tên sản phẩm";
            MaSanPham.MinimumWidth = 8;
            MaSanPham.Name = "MaSanPham";
            // 
            // MauSac
            // 
            MauSac.DataPropertyName = "MaMauSac";
            dataGridViewCellStyle16.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle16.SelectionForeColor = Color.White;
            MauSac.DefaultCellStyle = dataGridViewCellStyle16;
            MauSac.HeaderText = "Màu sắc";
            MauSac.MinimumWidth = 8;
            MauSac.Name = "MauSac";
            // 
            // MaKichCo
            // 
            MaKichCo.DataPropertyName = "MaKichCo";
            dataGridViewCellStyle17.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle17.SelectionForeColor = Color.White;
            MaKichCo.DefaultCellStyle = dataGridViewCellStyle17;
            MaKichCo.HeaderText = "Kích cỡ";
            MaKichCo.MinimumWidth = 8;
            MaKichCo.Name = "MaKichCo";
            // 
            // SoLuongNhap
            // 
            SoLuongNhap.DataPropertyName = "SoLuongNhap";
            dataGridViewCellStyle18.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle18.SelectionForeColor = Color.White;
            SoLuongNhap.DefaultCellStyle = dataGridViewCellStyle18;
            SoLuongNhap.HeaderText = "Số lượng";
            SoLuongNhap.MinimumWidth = 8;
            SoLuongNhap.Name = "SoLuongNhap";
            // 
            // DonVi
            // 
            DonVi.DataPropertyName = "DonVi";
            dataGridViewCellStyle19.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle19.SelectionForeColor = Color.White;
            DonVi.DefaultCellStyle = dataGridViewCellStyle19;
            DonVi.HeaderText = "Đơn vị";
            DonVi.MinimumWidth = 8;
            DonVi.Name = "DonVi";
            // 
            // TienNhap
            // 
            TienNhap.DataPropertyName = "TienNhap";
            dataGridViewCellStyle20.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle20.SelectionForeColor = Color.White;
            TienNhap.DefaultCellStyle = dataGridViewCellStyle20;
            TienNhap.HeaderText = "Tiền nhập";
            TienNhap.MinimumWidth = 8;
            TienNhap.Name = "TienNhap";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle21.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle21.SelectionForeColor = Color.White;
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle21;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 8;
            ThanhTien.Name = "ThanhTien";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage_1;
            // 
            // ChiTietPhieuNhapGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(btnPDF);
            Controls.Add(panel2);
            Controls.Add(danhSachChiPhieuNhap);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ChiTietPhieuNhapGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChiTietPhieuNhapGUI";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachChiPhieuNhap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private DataGridView danhSachChiPhieuNhap;
        private DataGridViewTextBoxColumn MaChiTietPhieuNhap;
        private DataGridViewTextBoxColumn MaPhieuNhap;
        private DataGridViewTextBoxColumn MaSanPham;
        private DataGridViewTextBoxColumn MauSac;
        private DataGridViewTextBoxColumn MaKichCo;
        private DataGridViewTextBoxColumn SoLuongNhap;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn TienNhap;
        private DataGridViewTextBoxColumn ThanhTien;
        public Button btnPDF;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}