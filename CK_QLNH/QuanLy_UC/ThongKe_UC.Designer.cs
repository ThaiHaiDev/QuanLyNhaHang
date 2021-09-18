
namespace CK_QLNH
{
    partial class ThongKe_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe_UC));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewDTMon = new System.Windows.Forms.DataGridView();
            this.buttonDoanhThu = new System.Windows.Forms.Button();
            this.buttonMonTop = new System.Windows.Forms.Button();
            this.ThongKe = new System.Windows.Forms.GroupBox();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.radioButtonNam = new System.Windows.Forms.RadioButton();
            this.radioButton1Thang = new System.Windows.Forms.RadioButton();
            this.radioButton1Ngay = new System.Windows.Forms.RadioButton();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonDTBan = new System.Windows.Forms.RadioButton();
            this.radioButtonDTMon = new System.Windows.Forms.RadioButton();
            this.BieuDoCot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelDoanhThu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDTMon)).BeginInit();
            this.ThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BieuDoCot)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDTMon
            // 
            this.dataGridViewDTMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDTMon.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDTMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDTMon.Location = new System.Drawing.Point(88, 284);
            this.dataGridViewDTMon.Name = "dataGridViewDTMon";
            this.dataGridViewDTMon.RowHeadersWidth = 51;
            this.dataGridViewDTMon.RowTemplate.Height = 24;
            this.dataGridViewDTMon.Size = new System.Drawing.Size(599, 290);
            this.dataGridViewDTMon.TabIndex = 65;
            // 
            // buttonDoanhThu
            // 
            this.buttonDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.buttonDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDoanhThu.ForeColor = System.Drawing.Color.White;
            this.buttonDoanhThu.Image = ((System.Drawing.Image)(resources.GetObject("buttonDoanhThu.Image")));
            this.buttonDoanhThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDoanhThu.Location = new System.Drawing.Point(292, 22);
            this.buttonDoanhThu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDoanhThu.Name = "buttonDoanhThu";
            this.buttonDoanhThu.Size = new System.Drawing.Size(184, 48);
            this.buttonDoanhThu.TabIndex = 71;
            this.buttonDoanhThu.Text = "Thống Kê";
            this.buttonDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDoanhThu.UseVisualStyleBackColor = false;
            this.buttonDoanhThu.Click += new System.EventHandler(this.buttonDoanhThu_Click);
            // 
            // buttonMonTop
            // 
            this.buttonMonTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.buttonMonTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMonTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMonTop.ForeColor = System.Drawing.Color.White;
            this.buttonMonTop.Image = ((System.Drawing.Image)(resources.GetObject("buttonMonTop.Image")));
            this.buttonMonTop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMonTop.Location = new System.Drawing.Point(547, 22);
            this.buttonMonTop.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMonTop.Name = "buttonMonTop";
            this.buttonMonTop.Size = new System.Drawing.Size(161, 48);
            this.buttonMonTop.TabIndex = 68;
            this.buttonMonTop.Text = "Món Top";
            this.buttonMonTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMonTop.UseVisualStyleBackColor = false;
            this.buttonMonTop.Click += new System.EventHandler(this.buttonMonTop_Click);
            // 
            // ThongKe
            // 
            this.ThongKe.Controls.Add(this.numericUpDownYear);
            this.ThongKe.Controls.Add(this.comboBoxMonth);
            this.ThongKe.Controls.Add(this.radioButtonNam);
            this.ThongKe.Controls.Add(this.radioButton1Thang);
            this.ThongKe.Controls.Add(this.radioButton1Ngay);
            this.ThongKe.Location = new System.Drawing.Point(6, 167);
            this.ThongKe.Name = "ThongKe";
            this.ThongKe.Size = new System.Drawing.Size(735, 54);
            this.ThongKe.TabIndex = 76;
            this.ThongKe.TabStop = false;
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownYear.Location = new System.Drawing.Point(606, 18);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(88, 22);
            this.numericUpDownYear.TabIndex = 82;
            this.numericUpDownYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxMonth.Location = new System.Drawing.Point(318, 16);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(87, 24);
            this.comboBoxMonth.TabIndex = 80;
            this.comboBoxMonth.Text = "1";
            // 
            // radioButtonNam
            // 
            this.radioButtonNam.AutoSize = true;
            this.radioButtonNam.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNam.Location = new System.Drawing.Point(530, 16);
            this.radioButtonNam.Name = "radioButtonNam";
            this.radioButtonNam.Size = new System.Drawing.Size(70, 27);
            this.radioButtonNam.TabIndex = 78;
            this.radioButtonNam.TabStop = true;
            this.radioButtonNam.Text = "Năm";
            this.radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // radioButton1Thang
            // 
            this.radioButton1Thang.AutoSize = true;
            this.radioButton1Thang.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1Thang.Location = new System.Drawing.Point(231, 13);
            this.radioButton1Thang.Name = "radioButton1Thang";
            this.radioButton1Thang.Size = new System.Drawing.Size(81, 27);
            this.radioButton1Thang.TabIndex = 79;
            this.radioButton1Thang.TabStop = true;
            this.radioButton1Thang.Text = "Tháng";
            this.radioButton1Thang.UseVisualStyleBackColor = true;
            // 
            // radioButton1Ngay
            // 
            this.radioButton1Ngay.AutoSize = true;
            this.radioButton1Ngay.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1Ngay.Location = new System.Drawing.Point(15, 16);
            this.radioButton1Ngay.Name = "radioButton1Ngay";
            this.radioButton1Ngay.Size = new System.Drawing.Size(89, 27);
            this.radioButton1Ngay.TabIndex = 77;
            this.radioButton1Ngay.TabStop = true;
            this.radioButton1Ngay.Text = "1 Ngày";
            this.radioButton1Ngay.UseVisualStyleBackColor = true;
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Image = global::CK_QLNH.Properties.Resources.print_icon;
            this.buttonPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrint.Location = new System.Drawing.Point(777, 43);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(153, 48);
            this.buttonPrint.TabIndex = 77;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonPrint);
            this.groupBox1.Controls.Add(this.ThongKe);
            this.groupBox1.Location = new System.Drawing.Point(91, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1014, 240);
            this.groupBox1.TabIndex = 157;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonDTBan);
            this.groupBox2.Controls.Add(this.buttonMonTop);
            this.groupBox2.Controls.Add(this.buttonDoanhThu);
            this.groupBox2.Controls.Add(this.radioButtonDTMon);
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(735, 85);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            // 
            // radioButtonDTBan
            // 
            this.radioButtonDTBan.AutoSize = true;
            this.radioButtonDTBan.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDTBan.Location = new System.Drawing.Point(155, 35);
            this.radioButtonDTBan.Name = "radioButtonDTBan";
            this.radioButtonDTBan.Size = new System.Drawing.Size(88, 27);
            this.radioButtonDTBan.TabIndex = 80;
            this.radioButtonDTBan.TabStop = true;
            this.radioButtonDTBan.Text = "Bàn Ăn";
            this.radioButtonDTBan.UseVisualStyleBackColor = true;
            // 
            // radioButtonDTMon
            // 
            this.radioButtonDTMon.AutoSize = true;
            this.radioButtonDTMon.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDTMon.Location = new System.Drawing.Point(15, 35);
            this.radioButtonDTMon.Name = "radioButtonDTMon";
            this.radioButtonDTMon.Size = new System.Drawing.Size(101, 27);
            this.radioButtonDTMon.TabIndex = 79;
            this.radioButtonDTMon.TabStop = true;
            this.radioButtonDTMon.Text = "Hóa Đơn";
            this.radioButtonDTMon.UseVisualStyleBackColor = true;
            // 
            // BieuDoCot
            // 
            chartArea1.Name = "ChartArea1";
            this.BieuDoCot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BieuDoCot.Legends.Add(legend1);
            this.BieuDoCot.Location = new System.Drawing.Point(693, 284);
            this.BieuDoCot.Name = "BieuDoCot";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "MonAn";
            this.BieuDoCot.Series.Add(series1);
            this.BieuDoCot.Size = new System.Drawing.Size(412, 290);
            this.BieuDoCot.TabIndex = 0;
            this.BieuDoCot.Text = "chart1";
            // 
            // labelDoanhThu
            // 
            this.labelDoanhThu.AutoSize = true;
            this.labelDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoanhThu.Location = new System.Drawing.Point(88, 590);
            this.labelDoanhThu.Name = "labelDoanhThu";
            this.labelDoanhThu.Size = new System.Drawing.Size(70, 25);
            this.labelDoanhThu.TabIndex = 158;
            this.labelDoanhThu.Text = "TỔNG";
            // 
            // ThongKe_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelDoanhThu);
            this.Controls.Add(this.BieuDoCot);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewDTMon);
            this.Name = "ThongKe_UC";
            this.Size = new System.Drawing.Size(1304, 686);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDTMon)).EndInit();
            this.ThongKe.ResumeLayout(false);
            this.ThongKe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BieuDoCot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDoanhThu;
        private System.Windows.Forms.Button buttonMonTop;
        private System.Windows.Forms.DataGridView dataGridViewDTMon;
        private System.Windows.Forms.GroupBox ThongKe;
        private System.Windows.Forms.RadioButton radioButtonNam;
        private System.Windows.Forms.RadioButton radioButton1Thang;
        private System.Windows.Forms.RadioButton radioButton1Ngay;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonDTBan;
        private System.Windows.Forms.RadioButton radioButtonDTMon;
        private System.Windows.Forms.DataVisualization.Charting.Chart BieuDoCot;
        private System.Windows.Forms.Label labelDoanhThu;
    }
}
