namespace GUI
{
    partial class TrangChuGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChuGUI));
            sideBar = new FlowLayoutPanel();
            panelThongTin = new Panel();
            lbTenNhanVien = new Label();
            picAvatar = new PictureBox();
            panel1 = new Panel();
            closeBtn = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            containerPanel = new Panel();
            lbNhomQuyen = new Label();
            sideBar.SuspendLayout();
            panelThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.MediumSeaGreen;
            sideBar.Controls.Add(panelThongTin);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 0);
            sideBar.Margin = new Padding(2);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(300, 1000);
            sideBar.TabIndex = 0;
            sideBar.Paint += sideBar_Paint;
            // 
            // panelThongTin
            // 
            panelThongTin.BackColor = Color.MediumSeaGreen;
            panelThongTin.Controls.Add(lbNhomQuyen);
            panelThongTin.Controls.Add(lbTenNhanVien);
            panelThongTin.Controls.Add(picAvatar);
            panelThongTin.ForeColor = SystemColors.ButtonHighlight;
            panelThongTin.Location = new Point(1, 1);
            panelThongTin.Margin = new Padding(1);
            panelThongTin.Name = "panelThongTin";
            panelThongTin.Size = new Size(296, 99);
            panelThongTin.TabIndex = 4;
            // 
            // lbTenNhanVien
            // 
            lbTenNhanVien.AutoSize = true;
            lbTenNhanVien.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbTenNhanVien.ForeColor = SystemColors.ButtonHighlight;
            lbTenNhanVien.Location = new Point(88, 56);
            lbTenNhanVien.Margin = new Padding(2, 0, 2, 0);
            lbTenNhanVien.Name = "lbTenNhanVien";
            lbTenNhanVien.Size = new Size(98, 27);
            lbTenNhanVien.TabIndex = 0;
            lbTenNhanVien.Text = "Họ Và Tên";
            // 
            // picAvatar
            // 
            picAvatar.Image = Properties.Resources.Manager;
            picAvatar.Location = new Point(0, -1);
            picAvatar.Margin = new Padding(2);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(84, 100);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 2;
            picAvatar.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(closeBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(300, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 100);
            panel1.TabIndex = 1;
            // 
            // closeBtn
            // 
            closeBtn.Image = (Image)resources.GetObject("closeBtn.Image");
            closeBtn.Location = new Point(1527, 12);
            closeBtn.Margin = new Padding(2);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(62, 61);
            closeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            closeBtn.TabIndex = 3;
            closeBtn.TabStop = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumSeaGreen;
            label1.Location = new Point(109, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(534, 43);
            label1.TabIndex = 2;
            label1.Text = "Welcome To The SportFashionPOS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // containerPanel
            // 
            containerPanel.BackColor = SystemColors.ControlLight;
            containerPanel.Dock = DockStyle.Fill;
            containerPanel.Location = new Point(300, 100);
            containerPanel.Margin = new Padding(2);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(1600, 900);
            containerPanel.TabIndex = 2;
            containerPanel.Paint += containerPanel_Paint;
            // 
            // lbNhomQuyen
            // 
            lbNhomQuyen.AutoSize = true;
            lbNhomQuyen.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbNhomQuyen.ForeColor = SystemColors.ButtonHighlight;
            lbNhomQuyen.Location = new Point(88, 11);
            lbNhomQuyen.Margin = new Padding(2, 0, 2, 0);
            lbNhomQuyen.Name = "lbNhomQuyen";
            lbNhomQuyen.Size = new Size(126, 27);
            lbNhomQuyen.TabIndex = 3;
            lbNhomQuyen.Text = "Nhóm quyền";
            // 
            // TrangChuGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1900, 1000);
            Controls.Add(containerPanel);
            Controls.Add(panel1);
            Controls.Add(sideBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "TrangChuGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrangChuGUI";
            Load += TrangChuGUI_Load;
            sideBar.ResumeLayout(false);
            panelThongTin.ResumeLayout(false);
            panelThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)closeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sideBar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel containerPanel;
        private Label lbTenNhanVien;
        private PictureBox picAvatar;
        private Panel panelThongTin;
        private PictureBox closeBtn;
        private Label lbNhomQuyen;
    }
}