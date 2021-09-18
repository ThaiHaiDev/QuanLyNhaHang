
namespace CK_QLNH
{
    partial class ThemNVForm
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
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.ButtonUploadImage = new System.Windows.Forms.Button();
            this.PictureBoxNV = new System.Windows.Forms.PictureBox();
            this.DateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxNV)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFName
            // 
            this.textBoxFName.BackColor = System.Drawing.Color.White;
            this.textBoxFName.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFName.ForeColor = System.Drawing.Color.Silver;
            this.textBoxFName.Location = new System.Drawing.Point(71, 117);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(230, 30);
            this.textBoxFName.TabIndex = 156;
            this.textBoxFName.Enter += new System.EventHandler(this.textBoxFName_Enter);
            this.textBoxFName.Leave += new System.EventHandler(this.textBoxFName_Leave);
            // 
            // textBoxLName
            // 
            this.textBoxLName.BackColor = System.Drawing.Color.White;
            this.textBoxLName.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLName.ForeColor = System.Drawing.Color.Black;
            this.textBoxLName.Location = new System.Drawing.Point(71, 207);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(230, 30);
            this.textBoxLName.TabIndex = 157;
            this.textBoxLName.Enter += new System.EventHandler(this.textBoxLName_Enter);
            this.textBoxLName.Leave += new System.EventHandler(this.textBoxLName_Leave);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.Color.White;
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.ForeColor = System.Drawing.Color.Black;
            this.textBoxUserName.Location = new System.Drawing.Point(71, 287);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(230, 30);
            this.textBoxUserName.TabIndex = 153;
            this.textBoxUserName.Enter += new System.EventHandler(this.textBoxUserName_Enter);
            this.textBoxUserName.Leave += new System.EventHandler(this.textBoxUserName_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.Location = new System.Drawing.Point(355, 117);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(218, 30);
            this.textBoxPassword.TabIndex = 154;
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.ForeColor = System.Drawing.Color.White;
            this.buttonCreate.Image = global::CK_QLNH.Properties.Resources.Add_Folder_icon;
            this.buttonCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreate.Location = new System.Drawing.Point(212, 34);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(230, 35);
            this.buttonCreate.TabIndex = 155;
            this.buttonCreate.Text = "Thêm Nhân Viên";
            this.buttonCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // ButtonUploadImage
            // 
            this.ButtonUploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.ButtonUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUploadImage.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUploadImage.ForeColor = System.Drawing.Color.White;
            this.ButtonUploadImage.Image = global::CK_QLNH.Properties.Resources.Upload_Folder_icon;
            this.ButtonUploadImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonUploadImage.Location = new System.Drawing.Point(355, 375);
            this.ButtonUploadImage.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonUploadImage.Name = "ButtonUploadImage";
            this.ButtonUploadImage.Size = new System.Drawing.Size(218, 36);
            this.ButtonUploadImage.TabIndex = 160;
            this.ButtonUploadImage.Text = "Upload Image";
            this.ButtonUploadImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonUploadImage.UseVisualStyleBackColor = false;
            this.ButtonUploadImage.Click += new System.EventHandler(this.ButtonUploadImage_Click);
            // 
            // PictureBoxNV
            // 
            this.PictureBoxNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PictureBoxNV.Location = new System.Drawing.Point(355, 183);
            this.PictureBoxNV.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxNV.Name = "PictureBoxNV";
            this.PictureBoxNV.Size = new System.Drawing.Size(218, 174);
            this.PictureBoxNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxNV.TabIndex = 159;
            this.PictureBoxNV.TabStop = false;
            // 
            // DateTimePickerBirth
            // 
            this.DateTimePickerBirth.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerBirth.Location = new System.Drawing.Point(71, 382);
            this.DateTimePickerBirth.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePickerBirth.Name = "DateTimePickerBirth";
            this.DateTimePickerBirth.Size = new System.Drawing.Size(219, 29);
            this.DateTimePickerBirth.TabIndex = 158;
            // 
            // ThemNVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 504);
            this.Controls.Add(this.ButtonUploadImage);
            this.Controls.Add(this.PictureBoxNV);
            this.Controls.Add(this.DateTimePickerBirth);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.textBoxPassword);
            this.Name = "ThemNVForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemNVForm";
            this.Load += new System.EventHandler(this.ThemNVForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        public System.Windows.Forms.Button ButtonUploadImage;
        public System.Windows.Forms.PictureBox PictureBoxNV;
        public System.Windows.Forms.DateTimePicker DateTimePickerBirth;
    }
}