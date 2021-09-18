
namespace CK_QLNH
{
    partial class ChiaCaForm
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
            this.dataGridViewChiaCaNV = new System.Windows.Forms.DataGridView();
            this.buttonChiaCa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiaCaNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewChiaCaNV
            // 
            this.dataGridViewChiaCaNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChiaCaNV.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewChiaCaNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiaCaNV.Location = new System.Drawing.Point(12, 107);
            this.dataGridViewChiaCaNV.Name = "dataGridViewChiaCaNV";
            this.dataGridViewChiaCaNV.RowHeadersWidth = 51;
            this.dataGridViewChiaCaNV.RowTemplate.Height = 24;
            this.dataGridViewChiaCaNV.Size = new System.Drawing.Size(975, 250);
            this.dataGridViewChiaCaNV.TabIndex = 10;
            // 
            // buttonChiaCa
            // 
            this.buttonChiaCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.buttonChiaCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChiaCa.ForeColor = System.Drawing.Color.White;
            this.buttonChiaCa.Image = global::CK_QLNH.Properties.Resources.ok_icon;
            this.buttonChiaCa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChiaCa.Location = new System.Drawing.Point(148, 36);
            this.buttonChiaCa.Name = "buttonChiaCa";
            this.buttonChiaCa.Size = new System.Drawing.Size(154, 43);
            this.buttonChiaCa.TabIndex = 11;
            this.buttonChiaCa.Text = "Chia Ca";
            this.buttonChiaCa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChiaCa.UseVisualStyleBackColor = false;
            this.buttonChiaCa.Click += new System.EventHandler(this.buttonChiaCa_Click);
            // 
            // ChiaCaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 369);
            this.Controls.Add(this.buttonChiaCa);
            this.Controls.Add(this.dataGridViewChiaCaNV);
            this.Name = "ChiaCaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiaCaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiaCaNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChiaCa;
        private System.Windows.Forms.DataGridView dataGridViewChiaCaNV;
    }
}