namespace Desktop_Homework3
{
    partial class FormObject
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtHovaten = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnHolot = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnDem = new System.Windows.Forms.Button();
            this.btnHoadautu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Họ và Tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kết Quả";
            // 
            // txtHovaten
            // 
            this.txtHovaten.Location = new System.Drawing.Point(146, 127);
            this.txtHovaten.Name = "txtHovaten";
            this.txtHovaten.Size = new System.Drawing.Size(473, 22);
            this.txtHovaten.TabIndex = 2;
            this.txtHovaten.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(146, 187);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(473, 36);
            this.listBox1.TabIndex = 3;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(208, 229);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 92);
            this.btnIn.TabIndex = 4;
            this.btnIn.Text = "In lời giới thiệu";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnHolot
            // 
            this.btnHolot.Location = new System.Drawing.Point(289, 229);
            this.btnHolot.Name = "btnHolot";
            this.btnHolot.Size = new System.Drawing.Size(75, 43);
            this.btnHolot.TabIndex = 5;
            this.btnHolot.Text = "Họ Lót";
            this.btnHolot.UseVisualStyleBackColor = true;
            this.btnHolot.Click += new System.EventHandler(this.btnHolot_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(289, 278);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(75, 43);
            this.btnTen.TabIndex = 6;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnDem
            // 
            this.btnDem.Location = new System.Drawing.Point(370, 229);
            this.btnDem.Name = "btnDem";
            this.btnDem.Size = new System.Drawing.Size(124, 43);
            this.btnDem.TabIndex = 7;
            this.btnDem.Text = "Đếm Từ";
            this.btnDem.UseVisualStyleBackColor = true;
            this.btnDem.Click += new System.EventHandler(this.btnDem_Click);
            // 
            // btnHoadautu
            // 
            this.btnHoadautu.Location = new System.Drawing.Point(370, 278);
            this.btnHoadautu.Name = "btnHoadautu";
            this.btnHoadautu.Size = new System.Drawing.Size(124, 43);
            this.btnHoadautu.TabIndex = 8;
            this.btnHoadautu.Text = "Hoa Đầu Từ";
            this.btnHoadautu.UseVisualStyleBackColor = true;
            this.btnHoadautu.Click += new System.EventHandler(this.btnHoadautu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(500, 229);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(66, 43);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDung
            // 
            this.btnDung.Location = new System.Drawing.Point(500, 278);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(66, 43);
            this.btnDung.TabIndex = 10;
            this.btnDung.Text = "Dừng";
            this.btnDung.UseVisualStyleBackColor = true;
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            // 
            // FormObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHoadautu);
            this.Controls.Add(this.btnDem);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHolot);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtHovaten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormObject";
            this.Text = "FormObject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHovaten;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnHolot;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnDem;
        private System.Windows.Forms.Button btnHoadautu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDung;
    }
}