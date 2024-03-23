namespace UI
{
    partial class frmhoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhoadon));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbBill_ThanhToan = new System.Windows.Forms.Label();
            this.lbBill_Discount = new System.Windows.Forms.Label();
            this.lbBill_TongTien = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbBill_SDTKH = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbBill_DiaChiKH = new System.Windows.Forms.Label();
            this.btnBill_ThanhToan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.btnBill_Thoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.lbBill_TenKH = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(311, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox1.Location = new System.Drawing.Point(13, 67);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 2);
            this.textBox1.TabIndex = 5;
            // 
            // lbBill_ThanhToan
            // 
            this.lbBill_ThanhToan.AutoSize = true;
            this.lbBill_ThanhToan.Location = new System.Drawing.Point(106, 71);
            this.lbBill_ThanhToan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBill_ThanhToan.Name = "lbBill_ThanhToan";
            this.lbBill_ThanhToan.Size = new System.Drawing.Size(46, 13);
            this.lbBill_ThanhToan.TabIndex = 5;
            this.lbBill_ThanhToan.Text = "000.000";
            // 
            // lbBill_Discount
            // 
            this.lbBill_Discount.AutoSize = true;
            this.lbBill_Discount.Location = new System.Drawing.Point(108, 41);
            this.lbBill_Discount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBill_Discount.Name = "lbBill_Discount";
            this.lbBill_Discount.Size = new System.Drawing.Size(27, 13);
            this.lbBill_Discount.TabIndex = 4;
            this.lbBill_Discount.Text = "00%";
            // 
            // lbBill_TongTien
            // 
            this.lbBill_TongTien.AutoSize = true;
            this.lbBill_TongTien.Location = new System.Drawing.Point(108, 9);
            this.lbBill_TongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBill_TongTien.Name = "lbBill_TongTien";
            this.lbBill_TongTien.Size = new System.Drawing.Size(46, 13);
            this.lbBill_TongTien.TabIndex = 3;
            this.lbBill_TongTien.Text = "000.000";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(10, 71);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "Thanh toán:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 41);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "Giảm giá (%):";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 9);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Tổng tiền:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox2.Location = new System.Drawing.Point(67, 580);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(376, 2);
            this.textBox2.TabIndex = 43;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label28.Location = new System.Drawing.Point(84, 539);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(352, 36);
            this.label28.TabIndex = 41;
            this.label28.Text = "          Cảm ơn quý khách đã mua hàng !!!\r\nHẹn gặp lại khách hàng một ngày sớm n" +
    "hất !!!";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.lbBill_ThanhToan);
            this.panel5.Controls.Add(this.lbBill_Discount);
            this.panel5.Controls.Add(this.lbBill_TongTien);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Location = new System.Drawing.Point(167, 431);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(173, 96);
            this.panel5.TabIndex = 40;
            // 
            // lbBill_SDTKH
            // 
            this.lbBill_SDTKH.AutoSize = true;
            this.lbBill_SDTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBill_SDTKH.Location = new System.Drawing.Point(118, 72);
            this.lbBill_SDTKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBill_SDTKH.Name = "lbBill_SDTKH";
            this.lbBill_SDTKH.Size = new System.Drawing.Size(88, 18);
            this.lbBill_SDTKH.TabIndex = 13;
            this.lbBill_SDTKH.Text = "0352415624";
            this.lbBill_SDTKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(8, 72);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 18);
            this.label20.TabIndex = 12;
            this.label20.Text = "SĐT:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBill_DiaChiKH
            // 
            this.lbBill_DiaChiKH.AutoSize = true;
            this.lbBill_DiaChiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBill_DiaChiKH.Location = new System.Drawing.Point(116, 53);
            this.lbBill_DiaChiKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBill_DiaChiKH.Name = "lbBill_DiaChiKH";
            this.lbBill_DiaChiKH.Size = new System.Drawing.Size(82, 18);
            this.lbBill_DiaChiKH.TabIndex = 11;
            this.lbBill_DiaChiKH.Text = "Bình Thạnh";
            this.lbBill_DiaChiKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBill_ThanhToan
            // 
            this.btnBill_ThanhToan.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBill_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill_ThanhToan.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill_ThanhToan.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnBill_ThanhToan.Location = new System.Drawing.Point(12, 604);
            this.btnBill_ThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.btnBill_ThanhToan.Name = "btnBill_ThanhToan";
            this.btnBill_ThanhToan.Size = new System.Drawing.Size(177, 37);
            this.btnBill_ThanhToan.TabIndex = 44;
            this.btnBill_ThanhToan.Text = "Xác nhận thanh toán";
            this.btnBill_ThanhToan.UseVisualStyleBackColor = true;
            this.btnBill_ThanhToan.Click += new System.EventHandler(this.btnBill_ThanhToan_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvBill);
            this.panel4.Location = new System.Drawing.Point(11, 253);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(526, 173);
            this.panel4.TabIndex = 39;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.BackgroundColor = System.Drawing.Color.White;
            this.dtgvBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvBill.Location = new System.Drawing.Point(0, 0);
            this.dtgvBill.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 51;
            this.dtgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBill.Size = new System.Drawing.Size(526, 173);
            this.dtgvBill.TabIndex = 5;
            // 
            // btnBill_Thoat
            // 
            this.btnBill_Thoat.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBill_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill_Thoat.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill_Thoat.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnBill_Thoat.Location = new System.Drawing.Point(401, 604);
            this.btnBill_Thoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnBill_Thoat.Name = "btnBill_Thoat";
            this.btnBill_Thoat.Size = new System.Drawing.Size(76, 37);
            this.btnBill_Thoat.TabIndex = 45;
            this.btnBill_Thoat.Text = "Thoát";
            this.btnBill_Thoat.UseVisualStyleBackColor = true;
            this.btnBill_Thoat.Click += new System.EventHandler(this.btnBill_Thoat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 119);
            this.panel1.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa chỉ:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "0342452748";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(64, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "shopquanaokdt@gmail.com";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Website: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "75 Ưng Văn Kiêm, Phường 25, Quận Bình Thạnh, TP>HCM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SHOP QUAN AO KDT ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbBill_SDTKH);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.lbBill_DiaChiKH);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.lbBill_TenKH);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(11, 135);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 107);
            this.panel3.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 53);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 18);
            this.label18.TabIndex = 10;
            this.label18.Text = "Địa chỉ: ";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBill_TenKH
            // 
            this.lbBill_TenKH.AutoSize = true;
            this.lbBill_TenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBill_TenKH.Location = new System.Drawing.Point(116, 35);
            this.lbBill_TenKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBill_TenKH.Name = "lbBill_TenKH";
            this.lbBill_TenKH.Size = new System.Drawing.Size(108, 18);
            this.lbBill_TenKH.TabIndex = 9;
            this.lbBill_TenKH.Text = "Nguyễn Văn Tú";
            this.lbBill_TenKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 35);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 18);
            this.label16.TabIndex = 8;
            this.label16.Text = "Tên khách hàng:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label15.Location = new System.Drawing.Point(8, 14);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(198, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "THÔNG TIN KHÁCH HÀNG";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 700);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnBill_ThanhToan);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnBill_Thoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "frmhoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbBill_ThanhToan;
        private System.Windows.Forms.Label lbBill_Discount;
        private System.Windows.Forms.Label lbBill_TongTien;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbBill_SDTKH;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbBill_DiaChiKH;
        private System.Windows.Forms.Button btnBill_ThanhToan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Button btnBill_Thoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbBill_TenKH;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}