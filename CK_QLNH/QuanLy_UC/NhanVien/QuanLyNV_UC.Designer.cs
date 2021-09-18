
namespace CK_QLNH
{
    partial class QuanLyNV_UC
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
            this.textBoxSearchname = new System.Windows.Forms.TextBox();
            this.dataGridViewDanhSachNV = new System.Windows.Forms.DataGridView();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.buttonload = new System.Windows.Forms.Button();
            this.buttonthemnv = new System.Windows.Forms.Button();
            this.buttonChiaCa = new System.Windows.Forms.Button();
            this.buttonResestLuong = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachNV)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearchname
            // 
            this.textBoxSearchname.BackColor = System.Drawing.Color.White;
            this.textBoxSearchname.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchname.ForeColor = System.Drawing.Color.Black;
            this.textBoxSearchname.Location = new System.Drawing.Point(250, 51);
            this.textBoxSearchname.Multiline = true;
            this.textBoxSearchname.Name = "textBoxSearchname";
            this.textBoxSearchname.Size = new System.Drawing.Size(205, 36);
            this.textBoxSearchname.TabIndex = 16;
            this.textBoxSearchname.Enter += new System.EventHandler(this.textBoxSearchname_Enter);
            this.textBoxSearchname.Leave += new System.EventHandler(this.textBoxSearchname_Leave);
            // 
            // dataGridViewDanhSachNV
            // 
            this.dataGridViewDanhSachNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanhSachNV.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDanhSachNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachNV.Location = new System.Drawing.Point(39, 175);
            this.dataGridViewDanhSachNV.Name = "dataGridViewDanhSachNV";
            this.dataGridViewDanhSachNV.RowHeadersWidth = 51;
            this.dataGridViewDanhSachNV.RowTemplate.Height = 24;
            this.dataGridViewDanhSachNV.Size = new System.Drawing.Size(1270, 398);
            this.dataGridViewDanhSachNV.TabIndex = 13;
            this.dataGridViewDanhSachNV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachNV_CellDoubleClick);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Theo Tên",
            "Giới Tính Nam",
            "Giới Tính Nữ",
            "Nhân Viên Mới"});
            this.comboBoxSort.Location = new System.Drawing.Point(259, 118);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSort.TabIndex = 25;
            // 
            // buttonload
            // 
            this.buttonload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.buttonload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonload.ForeColor = System.Drawing.Color.White;
            this.buttonload.Image = global::CK_QLNH.Properties.Resources.Save_icon;
            this.buttonload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonload.Location = new System.Drawing.Point(70, 109);
            this.buttonload.Name = "buttonload";
            this.buttonload.Size = new System.Drawing.Size(161, 35);
            this.buttonload.TabIndex = 24;
            this.buttonload.Text = "Sắp Xếp ";
            this.buttonload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonload.UseVisualStyleBackColor = false;
            this.buttonload.Click += new System.EventHandler(this.buttonload_Click);
            // 
            // buttonthemnv
            // 
            this.buttonthemnv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.buttonthemnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonthemnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonthemnv.ForeColor = System.Drawing.Color.White;
            this.buttonthemnv.Image = global::CK_QLNH.Properties.Resources.Save_icon;
            this.buttonthemnv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonthemnv.Location = new System.Drawing.Point(662, 51);
            this.buttonthemnv.Name = "buttonthemnv";
            this.buttonthemnv.Size = new System.Drawing.Size(226, 36);
            this.buttonthemnv.TabIndex = 23;
            this.buttonthemnv.Text = "Thêm Nhân Viên";
            this.buttonthemnv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonthemnv.UseVisualStyleBackColor = false;
            this.buttonthemnv.Click += new System.EventHandler(this.buttonthemnv_Click);
            // 
            // buttonChiaCa
            // 
            this.buttonChiaCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.buttonChiaCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChiaCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonChiaCa.ForeColor = System.Drawing.Color.White;
            this.buttonChiaCa.Image = global::CK_QLNH.Properties.Resources.Save_icon;
            this.buttonChiaCa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChiaCa.Location = new System.Drawing.Point(894, 51);
            this.buttonChiaCa.Name = "buttonChiaCa";
            this.buttonChiaCa.Size = new System.Drawing.Size(166, 36);
            this.buttonChiaCa.TabIndex = 22;
            this.buttonChiaCa.Text = "Chia Ca";
            this.buttonChiaCa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChiaCa.UseVisualStyleBackColor = false;
            this.buttonChiaCa.Click += new System.EventHandler(this.buttonChiaCa_Click);
            // 
            // buttonResestLuong
            // 
            this.buttonResestLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.buttonResestLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResestLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonResestLuong.ForeColor = System.Drawing.Color.White;
            this.buttonResestLuong.Image = global::CK_QLNH.Properties.Resources.Button_Refresh_icon;
            this.buttonResestLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonResestLuong.Location = new System.Drawing.Point(1066, 51);
            this.buttonResestLuong.Name = "buttonResestLuong";
            this.buttonResestLuong.Size = new System.Drawing.Size(213, 36);
            this.buttonResestLuong.TabIndex = 20;
            this.buttonResestLuong.Text = "Resest Time";
            this.buttonResestLuong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonResestLuong.UseVisualStyleBackColor = false;
            this.buttonResestLuong.Click += new System.EventHandler(this.buttonResestLuong_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Image = global::CK_QLNH.Properties.Resources.Search_icon__1_;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(70, 51);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(161, 36);
            this.buttonSearch.TabIndex = 17;
            this.buttonSearch.Text = "Tìm Kiếm";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Image = global::CK_QLNH.Properties.Resources.Windows_Close_Program_icon;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(474, 51);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(166, 36);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // QuanLyNV_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.buttonload);
            this.Controls.Add(this.buttonthemnv);
            this.Controls.Add(this.buttonChiaCa);
            this.Controls.Add(this.buttonResestLuong);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchname);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewDanhSachNV);
            this.Name = "QuanLyNV_UC";
            this.Size = new System.Drawing.Size(1353, 660);
            this.Load += new System.EventHandler(this.QuanLyNV_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchname;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewDanhSachNV;
        private System.Windows.Forms.Button buttonResestLuong;
        private System.Windows.Forms.Button buttonChiaCa;
        private System.Windows.Forms.Button buttonthemnv;
        private System.Windows.Forms.Button buttonload;
        private System.Windows.Forms.ComboBox comboBoxSort;
    }
}
