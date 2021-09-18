
namespace CK_QLNH
{
    partial class Menu_UC
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
            this.dataGridViewThucDon = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewThucDon
            // 
            this.dataGridViewThucDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewThucDon.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThucDon.Location = new System.Drawing.Point(88, 125);
            this.dataGridViewThucDon.Name = "dataGridViewThucDon";
            this.dataGridViewThucDon.RowHeadersWidth = 51;
            this.dataGridViewThucDon.RowTemplate.Height = 24;
            this.dataGridViewThucDon.Size = new System.Drawing.Size(725, 325);
            this.dataGridViewThucDon.TabIndex = 117;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(251, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 51);
            this.label4.TabIndex = 132;
            this.label4.Text = "THƯC ĐƠN MÓN";
            // 
            // Menu_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewThucDon);
            this.Name = "Menu_UC";
            this.Size = new System.Drawing.Size(932, 488);
            this.Load += new System.EventHandler(this.Menu_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThucDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewThucDon;
        private System.Windows.Forms.Label label4;
    }
}
