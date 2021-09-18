
namespace CK_QLNH
{
    partial class QLOder_UC
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
            this.panelShowOder = new System.Windows.Forms.Panel();
            this.panelBOder = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonTinhTien = new System.Windows.Forms.Button();
            this.panelBOder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelShowOder
            // 
            this.panelShowOder.Location = new System.Drawing.Point(250, 3);
            this.panelShowOder.Name = "panelShowOder";
            this.panelShowOder.Size = new System.Drawing.Size(1603, 854);
            this.panelShowOder.TabIndex = 113;
            // 
            // panelBOder
            // 
            this.panelBOder.Controls.Add(this.button1);
            this.panelBOder.Controls.Add(this.buttonMenu);
            this.panelBOder.Controls.Add(this.buttonTinhTien);
            this.panelBOder.Location = new System.Drawing.Point(3, 3);
            this.panelBOder.Name = "panelBOder";
            this.panelBOder.Size = new System.Drawing.Size(241, 660);
            this.panelBOder.TabIndex = 113;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::CK_QLNH.Properties.Resources.minitable11;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(24, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 42);
            this.button1.TabIndex = 110;
            this.button1.Text = "ODER";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonban_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.buttonMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.Color.White;
            this.buttonMenu.Image = global::CK_QLNH.Properties.Resources.vectorchef150709093;
            this.buttonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenu.Location = new System.Drawing.Point(24, 150);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(192, 42);
            this.buttonMenu.TabIndex = 109;
            this.buttonMenu.Text = "MENU";
            this.buttonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonTinhTien
            // 
            this.buttonTinhTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.buttonTinhTien.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonTinhTien.FlatAppearance.BorderSize = 0;
            this.buttonTinhTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTinhTien.ForeColor = System.Drawing.Color.White;
            this.buttonTinhTien.Image = global::CK_QLNH.Properties.Resources.Money_2_icon;
            this.buttonTinhTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTinhTien.Location = new System.Drawing.Point(24, 304);
            this.buttonTinhTien.Name = "buttonTinhTien";
            this.buttonTinhTien.Size = new System.Drawing.Size(193, 42);
            this.buttonTinhTien.TabIndex = 111;
            this.buttonTinhTien.Text = "TÍNH TIỀN";
            this.buttonTinhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTinhTien.UseVisualStyleBackColor = false;
            this.buttonTinhTien.Click += new System.EventHandler(this.buttonTinhTien_Click);
            // 
            // QLOder_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBOder);
            this.Controls.Add(this.panelShowOder);
            this.Name = "QLOder_UC";
            this.Size = new System.Drawing.Size(1856, 901);
            this.panelBOder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonTinhTien;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Panel panelBOder;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel panelShowOder;
    }
}
