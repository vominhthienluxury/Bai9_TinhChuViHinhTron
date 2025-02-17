namespace Bai9_TinhChuViHinhTron
{
    partial class Form1
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
            this.buttonTinh = new System.Windows.Forms.Button();
            this.ketqua = new System.Windows.Forms.TextBox();
            this.sothu2 = new System.Windows.Forms.TextBox();
            this.sothu1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dientich = new System.Windows.Forms.RadioButton();
            this.chuvi = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTinh
            // 
            this.buttonTinh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTinh.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonTinh.Location = new System.Drawing.Point(44, 142);
            this.buttonTinh.Name = "buttonTinh";
            this.buttonTinh.Size = new System.Drawing.Size(75, 23);
            this.buttonTinh.TabIndex = 0;
            this.buttonTinh.Text = "Tính";
            this.buttonTinh.UseVisualStyleBackColor = false;
            this.buttonTinh.Click += new System.EventHandler(this.buttonTinh_Click);
            // 
            // ketqua
            // 
            this.ketqua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketqua.ForeColor = System.Drawing.SystemColors.Menu;
            this.ketqua.Location = new System.Drawing.Point(109, 185);
            this.ketqua.Multiline = true;
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(100, 50);
            this.ketqua.TabIndex = 1;
            // 
            // sothu2
            // 
            this.sothu2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sothu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sothu2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.sothu2.Location = new System.Drawing.Point(109, 146);
            this.sothu2.Name = "sothu2";
            this.sothu2.Size = new System.Drawing.Size(0, 20);
            this.sothu2.TabIndex = 2;
            // 
            // sothu1
            // 
            this.sothu1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sothu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sothu1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.sothu1.Location = new System.Drawing.Point(109, 129);
            this.sothu1.Name = "sothu1";
            this.sothu1.Size = new System.Drawing.Size(100, 20);
            this.sothu1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.chuvi);
            this.groupBox1.Controls.Add(this.dientich);
            this.groupBox1.Controls.Add(this.buttonTinh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(225, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 171);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép tính";
            // 
            // dientich
            // 
            this.dientich.AutoSize = true;
            this.dientich.Location = new System.Drawing.Point(7, 45);
            this.dientich.Name = "dientich";
            this.dientich.Size = new System.Drawing.Size(78, 17);
            this.dientich.TabIndex = 0;
            this.dientich.TabStop = true;
            this.dientich.Text = "Diện tích";
            this.dientich.UseVisualStyleBackColor = true;
            // 
            // chuvi
            // 
            this.chuvi.AutoSize = true;
            this.chuvi.Location = new System.Drawing.Point(7, 101);
            this.chuvi.Name = "chuvi";
            this.chuvi.Size = new System.Drawing.Size(61, 17);
            this.chuvi.TabIndex = 1;
            this.chuvi.TabStop = true;
            this.chuvi.Text = "Chu vi";
            this.chuvi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(30, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số thứ hai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(30, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kết quả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 319);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sothu1);
            this.Controls.Add(this.sothu2);
            this.Controls.Add(this.ketqua);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTinh;
        private System.Windows.Forms.TextBox ketqua;
        private System.Windows.Forms.TextBox sothu2;
        private System.Windows.Forms.TextBox sothu1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton chuvi;
        private System.Windows.Forms.RadioButton dientich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

