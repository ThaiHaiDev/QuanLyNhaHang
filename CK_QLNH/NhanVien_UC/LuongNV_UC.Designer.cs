
namespace CK_QLNH
{
    partial class LuongNV_UC
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
            this.dataGridViewDanhSachNV = new System.Windows.Forms.DataGridView();
            this.buttonSaveWord = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.labelLuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDanhSachNV
            // 
            this.dataGridViewDanhSachNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanhSachNV.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDanhSachNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachNV.Location = new System.Drawing.Point(114, 125);
            this.dataGridViewDanhSachNV.Name = "dataGridViewDanhSachNV";
            this.dataGridViewDanhSachNV.RowHeadersWidth = 51;
            this.dataGridViewDanhSachNV.RowTemplate.Height = 24;
            this.dataGridViewDanhSachNV.Size = new System.Drawing.Size(864, 210);
            this.dataGridViewDanhSachNV.TabIndex = 10;
            // 
            // buttonSaveWord
            // 
            this.buttonSaveWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.buttonSaveWord.FlatAppearance.BorderSize = 0;
            this.buttonSaveWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSaveWord.ForeColor = System.Drawing.Color.White;
            this.buttonSaveWord.Image = global::CK_QLNH.Properties.Resources.Save_icon;
            this.buttonSaveWord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveWord.Location = new System.Drawing.Point(124, 34);
            this.buttonSaveWord.Name = "buttonSaveWord";
            this.buttonSaveWord.Size = new System.Drawing.Size(177, 39);
            this.buttonSaveWord.TabIndex = 149;
            this.buttonSaveWord.Text = "Save Word";
            this.buttonSaveWord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSaveWord.UseVisualStyleBackColor = false;
            this.buttonSaveWord.Click += new System.EventHandler(this.buttonSaveWord_Click_1);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.buttonPrint.FlatAppearance.BorderSize = 0;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Image = global::CK_QLNH.Properties.Resources.print_icon;
            this.buttonPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrint.Location = new System.Drawing.Point(334, 34);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(147, 39);
            this.buttonPrint.TabIndex = 148;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click_1);
            // 
            // labelLuong
            // 
            this.labelLuong.AutoSize = true;
            this.labelLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLuong.Location = new System.Drawing.Point(331, 374);
            this.labelLuong.Name = "labelLuong";
            this.labelLuong.Size = new System.Drawing.Size(70, 25);
            this.labelLuong.TabIndex = 150;
            this.labelLuong.Text = "label1";
            // 
            // LuongNV_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelLuong);
            this.Controls.Add(this.buttonSaveWord);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dataGridViewDanhSachNV);
            this.Name = "LuongNV_UC";
            this.Size = new System.Drawing.Size(1059, 435);
            this.Load += new System.EventHandler(this.LuongNV_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDanhSachNV;
        private System.Windows.Forms.Button buttonSaveWord;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Label labelLuong;
    }
}
