
namespace CK_QLNH
{
    partial class TinhTien_Form
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
            this.labelTongTien = new System.Windows.Forms.Label();
            this.dataGridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.radioButtonFrint = new System.Windows.Forms.RadioButton();
            this.buttonThem = new System.Windows.Forms.Button();
            this.comboBoxIdBan = new System.Windows.Forms.ComboBox();
            this.labelTienBan = new System.Windows.Forms.Label();
            this.buttonXemHoaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTongTien
            // 
            this.labelTongTien.BackColor = System.Drawing.Color.Transparent;
            this.labelTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.labelTongTien.Location = new System.Drawing.Point(497, 385);
            this.labelTongTien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(349, 40);
            this.labelTongTien.TabIndex = 146;
            this.labelTongTien.Text = "Tổng Tiền Thanh Toán Là:";
            this.labelTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewHoaDon
            // 
            this.dataGridViewHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoaDon.Location = new System.Drawing.Point(60, 103);
            this.dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            this.dataGridViewHoaDon.RowHeadersWidth = 51;
            this.dataGridViewHoaDon.RowTemplate.Height = 24;
            this.dataGridViewHoaDon.Size = new System.Drawing.Size(786, 234);
            this.dataGridViewHoaDon.TabIndex = 145;
            // 
            // radioButtonFrint
            // 
            this.radioButtonFrint.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonFrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.radioButtonFrint.Image = global::CK_QLNH.Properties.Resources.Printer_icon;
            this.radioButtonFrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButtonFrint.Location = new System.Drawing.Point(58, 392);
            this.radioButtonFrint.Name = "radioButtonFrint";
            this.radioButtonFrint.Size = new System.Drawing.Size(180, 43);
            this.radioButtonFrint.TabIndex = 147;
            this.radioButtonFrint.TabStop = true;
            this.radioButtonFrint.Text = "In Hóa Đơn";
            this.radioButtonFrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonFrint.UseVisualStyleBackColor = false;
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.buttonThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.ForeColor = System.Drawing.Color.White;
            this.buttonThem.Location = new System.Drawing.Point(60, 345);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(168, 40);
            this.buttonThem.TabIndex = 144;
            this.buttonThem.Text = "Thanh Toán";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // comboBoxIdBan
            // 
            this.comboBoxIdBan.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIdBan.FormattingEnabled = true;
            this.comboBoxIdBan.Location = new System.Drawing.Point(233, 60);
            this.comboBoxIdBan.Name = "comboBoxIdBan";
            this.comboBoxIdBan.Size = new System.Drawing.Size(149, 25);
            this.comboBoxIdBan.TabIndex = 148;
            // 
            // labelTienBan
            // 
            this.labelTienBan.BackColor = System.Drawing.Color.Transparent;
            this.labelTienBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTienBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.labelTienBan.Location = new System.Drawing.Point(497, 345);
            this.labelTienBan.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTienBan.Name = "labelTienBan";
            this.labelTienBan.Size = new System.Drawing.Size(349, 40);
            this.labelTienBan.TabIndex = 149;
            this.labelTienBan.Text = "Giá Tiền Bàn Là:";
            this.labelTienBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonXemHoaDon
            // 
            this.buttonXemHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.buttonXemHoaDon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonXemHoaDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonXemHoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonXemHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXemHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXemHoaDon.ForeColor = System.Drawing.Color.White;
            this.buttonXemHoaDon.Location = new System.Drawing.Point(60, 51);
            this.buttonXemHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXemHoaDon.Name = "buttonXemHoaDon";
            this.buttonXemHoaDon.Size = new System.Drawing.Size(166, 34);
            this.buttonXemHoaDon.TabIndex = 150;
            this.buttonXemHoaDon.Text = "Xem Hóa Đơn";
            this.buttonXemHoaDon.UseVisualStyleBackColor = false;
            this.buttonXemHoaDon.Click += new System.EventHandler(this.buttonXemHoaDon_Click);
            // 
            // TinhTien_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 492);
            this.Controls.Add(this.buttonXemHoaDon);
            this.Controls.Add(this.labelTienBan);
            this.Controls.Add(this.comboBoxIdBan);
            this.Controls.Add(this.radioButtonFrint);
            this.Controls.Add(this.labelTongTien);
            this.Controls.Add(this.dataGridViewHoaDon);
            this.Controls.Add(this.buttonThem);
            this.Name = "TinhTien_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TinhTien_Form";
            this.Load += new System.EventHandler(this.TinhTien_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonFrint;
        private System.Windows.Forms.Label labelTongTien;
        private System.Windows.Forms.DataGridView dataGridViewHoaDon;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.ComboBox comboBoxIdBan;
        private System.Windows.Forms.Label labelTienBan;
        private System.Windows.Forms.Button buttonXemHoaDon;
    }
}