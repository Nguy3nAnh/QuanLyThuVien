namespace QuanLyThuVien
{
    partial class frmMain
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
            this.btnThemDauSach = new System.Windows.Forms.Button();
            this.btnSuaDauSach = new System.Windows.Forms.Button();
            this.btnXoaDauSach = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThemDocGia = new System.Windows.Forms.Button();
            this.btnSuaDocGia = new System.Windows.Forms.Button();
            this.btnXoaDocGia = new System.Windows.Forms.Button();
            this.btnTimDocGia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThemDauSach
            // 
            this.btnThemDauSach.Location = new System.Drawing.Point(76, 28);
            this.btnThemDauSach.Name = "btnThemDauSach";
            this.btnThemDauSach.Size = new System.Drawing.Size(153, 23);
            this.btnThemDauSach.TabIndex = 0;
            this.btnThemDauSach.Text = "Thêm đầu sách";
            this.btnThemDauSach.UseVisualStyleBackColor = true;
            // 
            // btnSuaDauSach
            // 
            this.btnSuaDauSach.Location = new System.Drawing.Point(76, 57);
            this.btnSuaDauSach.Name = "btnSuaDauSach";
            this.btnSuaDauSach.Size = new System.Drawing.Size(153, 23);
            this.btnSuaDauSach.TabIndex = 1;
            this.btnSuaDauSach.Text = "Sửa thông tin đầu sách";
            this.btnSuaDauSach.UseVisualStyleBackColor = true;
            // 
            // btnXoaDauSach
            // 
            this.btnXoaDauSach.Location = new System.Drawing.Point(76, 86);
            this.btnXoaDauSach.Name = "btnXoaDauSach";
            this.btnXoaDauSach.Size = new System.Drawing.Size(153, 23);
            this.btnXoaDauSach.TabIndex = 2;
            this.btnXoaDauSach.Text = "Xóa thông tin đầu sách";
            this.btnXoaDauSach.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tìm kiếm đầu sách";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnThemDocGia
            // 
            this.btnThemDocGia.Location = new System.Drawing.Point(269, 28);
            this.btnThemDocGia.Name = "btnThemDocGia";
            this.btnThemDocGia.Size = new System.Drawing.Size(153, 23);
            this.btnThemDocGia.TabIndex = 0;
            this.btnThemDocGia.Text = "Thêm độc giả";
            this.btnThemDocGia.UseVisualStyleBackColor = true;
            // 
            // btnSuaDocGia
            // 
            this.btnSuaDocGia.Location = new System.Drawing.Point(269, 57);
            this.btnSuaDocGia.Name = "btnSuaDocGia";
            this.btnSuaDocGia.Size = new System.Drawing.Size(153, 23);
            this.btnSuaDocGia.TabIndex = 1;
            this.btnSuaDocGia.Text = "Sửa thông tin độc giả";
            this.btnSuaDocGia.UseVisualStyleBackColor = true;
            // 
            // btnXoaDocGia
            // 
            this.btnXoaDocGia.Location = new System.Drawing.Point(269, 86);
            this.btnXoaDocGia.Name = "btnXoaDocGia";
            this.btnXoaDocGia.Size = new System.Drawing.Size(153, 23);
            this.btnXoaDocGia.TabIndex = 2;
            this.btnXoaDocGia.Text = "Xóa thông tin độc giả";
            this.btnXoaDocGia.UseVisualStyleBackColor = true;
            // 
            // btnTimDocGia
            // 
            this.btnTimDocGia.Location = new System.Drawing.Point(269, 115);
            this.btnTimDocGia.Name = "btnTimDocGia";
            this.btnTimDocGia.Size = new System.Drawing.Size(153, 23);
            this.btnTimDocGia.TabIndex = 3;
            this.btnTimDocGia.Text = "Tìm kiếm độc giả";
            this.btnTimDocGia.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 490);
            this.Controls.Add(this.btnTimDocGia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXoaDocGia);
            this.Controls.Add(this.btnXoaDauSach);
            this.Controls.Add(this.btnSuaDocGia);
            this.Controls.Add(this.btnSuaDauSach);
            this.Controls.Add(this.btnThemDocGia);
            this.Controls.Add(this.btnThemDauSach);
            this.Name = "frmMain";
            this.Text = "Quản lý thư viện";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThemDauSach;
        private System.Windows.Forms.Button btnSuaDauSach;
        private System.Windows.Forms.Button btnXoaDauSach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThemDocGia;
        private System.Windows.Forms.Button btnSuaDocGia;
        private System.Windows.Forms.Button btnXoaDocGia;
        private System.Windows.Forms.Button btnTimDocGia;
    }
}

