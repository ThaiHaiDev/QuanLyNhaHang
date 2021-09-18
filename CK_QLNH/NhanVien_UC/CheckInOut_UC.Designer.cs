
namespace CK_QLNH
{
    partial class CheckInOut_UC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonSang = new System.Windows.Forms.RadioButton();
            this.radioButtonToi = new System.Windows.Forms.RadioButton();
            this.radioButtonTrua = new System.Windows.Forms.RadioButton();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.radioButtonSang);
            this.panel1.Controls.Add(this.radioButtonToi);
            this.panel1.Controls.Add(this.radioButtonTrua);
            this.panel1.Location = new System.Drawing.Point(15, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 103);
            this.panel1.TabIndex = 24;
            // 
            // radioButtonSang
            // 
            this.radioButtonSang.BackColor = System.Drawing.Color.White;
            this.radioButtonSang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioButtonSang.Image = global::CK_QLNH.Properties.Resources.Sang;
            this.radioButtonSang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButtonSang.Location = new System.Drawing.Point(39, 23);
            this.radioButtonSang.Name = "radioButtonSang";
            this.radioButtonSang.Size = new System.Drawing.Size(258, 56);
            this.radioButtonSang.TabIndex = 13;
            this.radioButtonSang.TabStop = true;
            this.radioButtonSang.Text = "  Ca Sáng 7h - 11h";
            this.radioButtonSang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonSang.UseVisualStyleBackColor = false;
            // 
            // radioButtonToi
            // 
            this.radioButtonToi.BackColor = System.Drawing.Color.White;
            this.radioButtonToi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonToi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioButtonToi.Image = global::CK_QLNH.Properties.Resources.Toi;
            this.radioButtonToi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButtonToi.Location = new System.Drawing.Point(651, 23);
            this.radioButtonToi.Name = "radioButtonToi";
            this.radioButtonToi.Size = new System.Drawing.Size(272, 56);
            this.radioButtonToi.TabIndex = 15;
            this.radioButtonToi.TabStop = true;
            this.radioButtonToi.Text = "Ca Tối 18h - 22h";
            this.radioButtonToi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonToi.UseVisualStyleBackColor = false;
            // 
            // radioButtonTrua
            // 
            this.radioButtonTrua.BackColor = System.Drawing.Color.White;
            this.radioButtonTrua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTrua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioButtonTrua.Image = global::CK_QLNH.Properties.Resources.Trua;
            this.radioButtonTrua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButtonTrua.Location = new System.Drawing.Point(351, 23);
            this.radioButtonTrua.Name = "radioButtonTrua";
            this.radioButtonTrua.Size = new System.Drawing.Size(279, 56);
            this.radioButtonTrua.TabIndex = 14;
            this.radioButtonTrua.TabStop = true;
            this.radioButtonTrua.Text = "Ca Trưa 11h - 14h";
            this.radioButtonTrua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonTrua.UseVisualStyleBackColor = false;
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.White;
            this.buttonStop.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonStop.FlatAppearance.BorderSize = 3;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonStop.Image = global::CK_QLNH.Properties.Resources.Stop_red_icon;
            this.buttonStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStop.Location = new System.Drawing.Point(672, 119);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(273, 53);
            this.buttonStop.TabIndex = 25;
            this.buttonStop.Text = "Kết Thúc Làm Việc";
            this.buttonStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.White;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonStart.FlatAppearance.BorderSize = 3;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonStart.Image = global::CK_QLNH.Properties.Resources.Start_icon;
            this.buttonStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStart.Location = new System.Drawing.Point(365, 119);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(273, 53);
            this.buttonStart.TabIndex = 23;
            this.buttonStart.Text = "Bắt Đầu Làm Việc";
            this.buttonStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(158, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 129);
            this.panel2.TabIndex = 26;
            // 
            // CheckInOut_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Name = "CheckInOut_UC";
            this.Size = new System.Drawing.Size(1322, 447);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonSang;
        private System.Windows.Forms.RadioButton radioButtonToi;
        private System.Windows.Forms.RadioButton radioButtonTrua;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Panel panel2;
    }
}
