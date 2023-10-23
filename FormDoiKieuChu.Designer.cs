namespace Desktop_Homework3
{
    partial class FormDoiKieuChu
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
            this.txtHovaTen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbchuthuong = new System.Windows.Forms.RadioButton();
            this.rdbchuhoa = new System.Windows.Forms.RadioButton();
            this.btnXoa = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnKq = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ và tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHovaTen
            // 
            this.txtHovaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHovaTen.Location = new System.Drawing.Point(238, 73);
            this.txtHovaTen.Name = "txtHovaTen";
            this.txtHovaTen.Size = new System.Drawing.Size(192, 22);
            this.txtHovaTen.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbchuhoa);
            this.groupBox1.Controls.Add(this.rdbchuthuong);
            this.groupBox1.Location = new System.Drawing.Point(144, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 82);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn kiểu chữ";
            // 
            // rdbchuthuong
            // 
            this.rdbchuthuong.AutoSize = true;
            this.rdbchuthuong.Location = new System.Drawing.Point(23, 28);
            this.rdbchuthuong.Name = "rdbchuthuong";
            this.rdbchuthuong.Size = new System.Drawing.Size(79, 17);
            this.rdbchuthuong.TabIndex = 0;
            this.rdbchuthuong.TabStop = true;
            this.rdbchuthuong.Text = "chữ thường";
            this.rdbchuthuong.UseVisualStyleBackColor = true;
            this.rdbchuthuong.CheckedChanged += new System.EventHandler(this.rdbchuthuong_CheckedChanged);
            // 
            // rdbchuhoa
            // 
            this.rdbchuhoa.AutoSize = true;
            this.rdbchuhoa.Location = new System.Drawing.Point(23, 51);
            this.rdbchuhoa.Name = "rdbchuhoa";
            this.rdbchuhoa.Size = new System.Drawing.Size(74, 17);
            this.rdbchuhoa.TabIndex = 1;
            this.rdbchuhoa.TabStop = true;
            this.rdbchuhoa.Text = "CHỮ HOA";
            this.rdbchuhoa.UseVisualStyleBackColor = true;
            this.rdbchuhoa.CheckedChanged += new System.EventHandler(this.rdbchuhoa_CheckedChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(356, 116);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 82);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(239, 220);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(192, 30);
            this.listBox1.TabIndex = 6;
            // 
            // btnKq
            // 
            this.btnKq.Location = new System.Drawing.Point(125, 220);
            this.btnKq.Name = "btnKq";
            this.btnKq.Size = new System.Drawing.Size(102, 30);
            this.btnKq.TabIndex = 7;
            this.btnKq.Text = "Kết quả";
            this.btnKq.UseVisualStyleBackColor = true;
            this.btnKq.Click += new System.EventHandler(this.btnKq_Click);
            // 
            // FormDoiKieuChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 328);
            this.Controls.Add(this.btnKq);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtHovaTen);
            this.Controls.Add(this.label1);
            this.Name = "FormDoiKieuChu";
            this.Text = "FormDoiKieuChu";
            this.Load += new System.EventHandler(this.FormDoiKieuChu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHovaTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbchuhoa;
        private System.Windows.Forms.RadioButton rdbchuthuong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnKq;
    }
}