
namespace CK_QLNH
{
    partial class ThongTinNV_UC
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
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.DateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.TextBoxLName = new System.Windows.Forms.TextBox();
            this.TextBoxFName = new System.Windows.Forms.TextBox();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.groupBoxGioiTinh = new System.Windows.Forms.GroupBox();
            this.ButtonUploadImage = new System.Windows.Forms.Button();
            this.PictureBoxNV = new System.Windows.Forms.PictureBox();
            this.textBoxDoiMK = new System.Windows.Forms.TextBox();
            this.buttonDoiMK = new System.Windows.Forms.Button();
            this.textBoxCMND = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.groupBoxGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxNV)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.ButtonRemove.FlatAppearance.BorderSize = 0;
            this.ButtonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemove.ForeColor = System.Drawing.Color.White;
            this.ButtonRemove.Image = global::CK_QLNH.Properties.Resources.delete_file_icon;
            this.ButtonRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonRemove.Location = new System.Drawing.Point(1024, 296);
            this.ButtonRemove.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(250, 44);
            this.ButtonRemove.TabIndex = 67;
            this.ButtonRemove.Text = "Xóa Tài Khoản";
            this.ButtonRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonRemove.UseVisualStyleBackColor = false;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.ButtonEdit.FlatAppearance.BorderSize = 0;
            this.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEdit.ForeColor = System.Drawing.Color.White;
            this.ButtonEdit.Image = global::CK_QLNH.Properties.Resources.pencil_icon;
            this.ButtonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonEdit.Location = new System.Drawing.Point(1024, 197);
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(250, 46);
            this.ButtonEdit.TabIndex = 66;
            this.ButtonEdit.Text = "Cập Nhật Thông Tin";
            this.ButtonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonEdit.UseVisualStyleBackColor = false;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPhone.Location = new System.Drawing.Point(49, 387);
            this.TextBoxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(317, 29);
            this.TextBoxPhone.TabIndex = 63;
            this.TextBoxPhone.Enter += new System.EventHandler(this.TextBoxPhone_Enter);
            this.TextBoxPhone.Leave += new System.EventHandler(this.TextBoxPhone_Leave);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Female.Location = new System.Drawing.Point(121, 22);
            this.Female.Margin = new System.Windows.Forms.Padding(4);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(104, 29);
            this.Female.TabIndex = 62;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Male.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Male.Location = new System.Drawing.Point(7, 22);
            this.Male.Margin = new System.Windows.Forms.Padding(4);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(80, 29);
            this.Male.TabIndex = 61;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // DateTimePickerBirth
            // 
            this.DateTimePickerBirth.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerBirth.Location = new System.Drawing.Point(49, 197);
            this.DateTimePickerBirth.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePickerBirth.Name = "DateTimePickerBirth";
            this.DateTimePickerBirth.Size = new System.Drawing.Size(219, 29);
            this.DateTimePickerBirth.TabIndex = 60;
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAddress.Location = new System.Drawing.Point(617, 33);
            this.TextBoxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxAddress.Multiline = true;
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(360, 118);
            this.TextBoxAddress.TabIndex = 59;
            this.TextBoxAddress.Enter += new System.EventHandler(this.TextBoxAddress_Enter);
            this.TextBoxAddress.Leave += new System.EventHandler(this.TextBoxAddress_Leave);
            // 
            // TextBoxLName
            // 
            this.TextBoxLName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLName.Location = new System.Drawing.Point(49, 143);
            this.TextBoxLName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxLName.Name = "TextBoxLName";
            this.TextBoxLName.Size = new System.Drawing.Size(317, 29);
            this.TextBoxLName.TabIndex = 58;
            // 
            // TextBoxFName
            // 
            this.TextBoxFName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxFName.Location = new System.Drawing.Point(49, 88);
            this.TextBoxFName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxFName.Name = "TextBoxFName";
            this.TextBoxFName.Size = new System.Drawing.Size(317, 29);
            this.TextBoxFName.TabIndex = 57;
            // 
            // TextBoxID
            // 
            this.TextBoxID.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxID.Location = new System.Drawing.Point(51, 33);
            this.TextBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(250, 29);
            this.TextBoxID.TabIndex = 56;
            // 
            // groupBoxGioiTinh
            // 
            this.groupBoxGioiTinh.Controls.Add(this.Male);
            this.groupBoxGioiTinh.Controls.Add(this.Female);
            this.groupBoxGioiTinh.Location = new System.Drawing.Point(49, 246);
            this.groupBoxGioiTinh.Name = "groupBoxGioiTinh";
            this.groupBoxGioiTinh.Size = new System.Drawing.Size(250, 68);
            this.groupBoxGioiTinh.TabIndex = 69;
            this.groupBoxGioiTinh.TabStop = false;
            // 
            // ButtonUploadImage
            // 
            this.ButtonUploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonUploadImage.FlatAppearance.BorderSize = 0;
            this.ButtonUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUploadImage.ForeColor = System.Drawing.Color.Blue;
            this.ButtonUploadImage.Image = global::CK_QLNH.Properties.Resources.Upload_Folder_icon;
            this.ButtonUploadImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonUploadImage.Location = new System.Drawing.Point(667, 434);
            this.ButtonUploadImage.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonUploadImage.Name = "ButtonUploadImage";
            this.ButtonUploadImage.Size = new System.Drawing.Size(172, 32);
            this.ButtonUploadImage.TabIndex = 65;
            this.ButtonUploadImage.Text = "Upload Image";
            this.ButtonUploadImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonUploadImage.UseVisualStyleBackColor = false;
            this.ButtonUploadImage.Click += new System.EventHandler(this.ButtonUploadImage_Click);
            // 
            // PictureBoxNV
            // 
            this.PictureBoxNV.BackColor = System.Drawing.Color.Gainsboro;
            this.PictureBoxNV.Location = new System.Drawing.Point(617, 182);
            this.PictureBoxNV.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxNV.Name = "PictureBoxNV";
            this.PictureBoxNV.Size = new System.Drawing.Size(271, 234);
            this.PictureBoxNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxNV.TabIndex = 64;
            this.PictureBoxNV.TabStop = false;
            // 
            // textBoxDoiMK
            // 
            this.textBoxDoiMK.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDoiMK.Location = new System.Drawing.Point(1024, 122);
            this.textBoxDoiMK.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDoiMK.Name = "textBoxDoiMK";
            this.textBoxDoiMK.Size = new System.Drawing.Size(184, 29);
            this.textBoxDoiMK.TabIndex = 144;
            // 
            // buttonDoiMK
            // 
            this.buttonDoiMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.buttonDoiMK.FlatAppearance.BorderSize = 0;
            this.buttonDoiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDoiMK.ForeColor = System.Drawing.Color.White;
            this.buttonDoiMK.Image = global::CK_QLNH.Properties.Resources.pencil_icon;
            this.buttonDoiMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDoiMK.Location = new System.Drawing.Point(1024, 33);
            this.buttonDoiMK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDoiMK.Name = "buttonDoiMK";
            this.buttonDoiMK.Size = new System.Drawing.Size(250, 45);
            this.buttonDoiMK.TabIndex = 145;
            this.buttonDoiMK.Text = "Thay Đổi Mật Khẩu";
            this.buttonDoiMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDoiMK.UseVisualStyleBackColor = false;
            this.buttonDoiMK.Click += new System.EventHandler(this.buttonDoiMK_Click);
            // 
            // textBoxCMND
            // 
            this.textBoxCMND.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCMND.Location = new System.Drawing.Point(49, 336);
            this.textBoxCMND.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCMND.Name = "textBoxCMND";
            this.textBoxCMND.Size = new System.Drawing.Size(317, 29);
            this.textBoxCMND.TabIndex = 147;
            this.textBoxCMND.Enter += new System.EventHandler(this.textBoxCMND_Enter);
            this.textBoxCMND.Leave += new System.EventHandler(this.textBoxCMND_Leave);
            // 
            // textBoxMail
            // 
            this.textBoxMail.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMail.Location = new System.Drawing.Point(49, 437);
            this.textBoxMail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(498, 29);
            this.textBoxMail.TabIndex = 148;
            this.textBoxMail.Enter += new System.EventHandler(this.textBoxMail_Enter);
            this.textBoxMail.Leave += new System.EventHandler(this.textBoxMail_Leave);
            // 
            // ThongTinNV_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxCMND);
            this.Controls.Add(this.buttonDoiMK);
            this.Controls.Add(this.textBoxDoiMK);
            this.Controls.Add(this.groupBoxGioiTinh);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonUploadImage);
            this.Controls.Add(this.PictureBoxNV);
            this.Controls.Add(this.TextBoxPhone);
            this.Controls.Add(this.DateTimePickerBirth);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.TextBoxLName);
            this.Controls.Add(this.TextBoxFName);
            this.Controls.Add(this.TextBoxID);
            this.Name = "ThongTinNV_UC";
            this.Size = new System.Drawing.Size(1319, 509);
            this.Load += new System.EventHandler(this.ThongTinNV_UC_Load);
            this.groupBoxGioiTinh.ResumeLayout(false);
            this.groupBoxGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.Button ButtonEdit;
        public System.Windows.Forms.Button ButtonUploadImage;
        public System.Windows.Forms.PictureBox PictureBoxNV;
        public System.Windows.Forms.TextBox TextBoxPhone;
        public System.Windows.Forms.RadioButton Female;
        public System.Windows.Forms.RadioButton Male;
        public System.Windows.Forms.DateTimePicker DateTimePickerBirth;
        public System.Windows.Forms.TextBox TextBoxAddress;
        public System.Windows.Forms.TextBox TextBoxLName;
        public System.Windows.Forms.TextBox TextBoxFName;
        public System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.GroupBox groupBoxGioiTinh;
        public System.Windows.Forms.TextBox textBoxDoiMK;
        private System.Windows.Forms.Button buttonDoiMK;
        public System.Windows.Forms.TextBox textBoxCMND;
        public System.Windows.Forms.TextBox textBoxMail;
    }
}
