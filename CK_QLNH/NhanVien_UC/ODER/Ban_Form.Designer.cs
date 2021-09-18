
namespace CK_QLNH
{
    partial class Ban_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewBan = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ButtonLocBan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(224, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 51);
            this.label1.TabIndex = 137;
            this.label1.Text = "TÌNH TRẠNG BÀN";
            // 
            // dataGridViewBan
            // 
            this.dataGridViewBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBan.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBan.Location = new System.Drawing.Point(32, 186);
            this.dataGridViewBan.Name = "dataGridViewBan";
            this.dataGridViewBan.RowHeadersWidth = 51;
            this.dataGridViewBan.RowTemplate.Height = 24;
            this.dataGridViewBan.Size = new System.Drawing.Size(817, 335);
            this.dataGridViewBan.TabIndex = 136;
            this.dataGridViewBan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBan_CellDoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bàn Trống",
            "Bàn Đã Đặt",
            "Bàn Gia Đình"});
            this.comboBox1.Location = new System.Drawing.Point(256, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 30);
            this.comboBox1.TabIndex = 138;
            this.comboBox1.Text = "Bàn Trống";
            // 
            // ButtonLocBan
            // 
            this.ButtonLocBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ButtonLocBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLocBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonLocBan.ForeColor = System.Drawing.Color.White;
            this.ButtonLocBan.Image = global::CK_QLNH.Properties.Resources.Save_icon;
            this.ButtonLocBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonLocBan.Location = new System.Drawing.Point(32, 128);
            this.ButtonLocBan.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonLocBan.Name = "ButtonLocBan";
            this.ButtonLocBan.Size = new System.Drawing.Size(186, 41);
            this.ButtonLocBan.TabIndex = 139;
            this.ButtonLocBan.Text = "Lọc Bàn Ăn";
            this.ButtonLocBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonLocBan.UseVisualStyleBackColor = false;
            this.ButtonLocBan.Click += new System.EventHandler(this.ButtonLocBan_Click);
            // 
            // Ban_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CK_QLNH.Properties.Resources.s_l500;
            this.ClientSize = new System.Drawing.Size(861, 540);
            this.Controls.Add(this.ButtonLocBan);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewBan);
            this.Name = "Ban_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ban_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ban_Form_FormClosed);
            this.Load += new System.EventHandler(this.Ban_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewBan;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ButtonLocBan;
    }
}