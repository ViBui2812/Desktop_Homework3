namespace Desktop_Homework3
{
    partial class FormXulyChuoi
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
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnConcat = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnCOMPARE2 = new System.Windows.Forms.Button();
            this.btnIndexof = new System.Windows.Forms.Button();
            this.btnsubstring = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH XỬ LÝ CHUỖI";
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(194, 113);
            this.txtS1.Multiline = true;
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(394, 23);
            this.txtS1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập vào chuỗi thứ nhất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập vào chuỗi thứ hai:";
            // 
            // txtS2
            // 
            this.txtS2.Location = new System.Drawing.Point(194, 158);
            this.txtS2.Multiline = true;
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(394, 23);
            this.txtS2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kết quả:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(158, 211);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(430, 108);
            this.listBox1.TabIndex = 6;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(158, 326);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(103, 23);
            this.btnCompare.TabIndex = 7;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnConcat
            // 
            this.btnConcat.Location = new System.Drawing.Point(267, 326);
            this.btnConcat.Name = "btnConcat";
            this.btnConcat.Size = new System.Drawing.Size(103, 23);
            this.btnConcat.TabIndex = 9;
            this.btnConcat.Text = "Concat";
            this.btnConcat.UseVisualStyleBackColor = true;
            this.btnConcat.Click += new System.EventHandler(this.btnConcat_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(376, 326);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(103, 23);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(485, 326);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(103, 23);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnCOMPARE2
            // 
            this.btnCOMPARE2.Location = new System.Drawing.Point(158, 355);
            this.btnCOMPARE2.Name = "btnCOMPARE2";
            this.btnCOMPARE2.Size = new System.Drawing.Size(103, 23);
            this.btnCOMPARE2.TabIndex = 12;
            this.btnCOMPARE2.Text = "COMPARE";
            this.btnCOMPARE2.UseVisualStyleBackColor = true;
            this.btnCOMPARE2.Click += new System.EventHandler(this.btnCOMPARE2_Click);
            // 
            // btnIndexof
            // 
            this.btnIndexof.Location = new System.Drawing.Point(267, 355);
            this.btnIndexof.Name = "btnIndexof";
            this.btnIndexof.Size = new System.Drawing.Size(103, 23);
            this.btnIndexof.TabIndex = 13;
            this.btnIndexof.Text = "IndexOf";
            this.btnIndexof.UseVisualStyleBackColor = true;
            this.btnIndexof.Click += new System.EventHandler(this.btnIndexof_Click);
            // 
            // btnsubstring
            // 
            this.btnsubstring.Location = new System.Drawing.Point(376, 355);
            this.btnsubstring.Name = "btnsubstring";
            this.btnsubstring.Size = new System.Drawing.Size(103, 23);
            this.btnsubstring.TabIndex = 14;
            this.btnsubstring.Text = "Substring";
            this.btnsubstring.UseVisualStyleBackColor = true;
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(485, 355);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(103, 23);
            this.btnstop.TabIndex = 15;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            // 
            // FormXulyChuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnsubstring);
            this.Controls.Add(this.btnIndexof);
            this.Controls.Add(this.btnCOMPARE2);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnConcat);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtS2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtS1);
            this.Controls.Add(this.label1);
            this.Name = "FormXulyChuoi";
            this.Text = "FormXulyChuoi";
            this.Load += new System.EventHandler(this.FormXulyChuoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnConcat;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnCOMPARE2;
        private System.Windows.Forms.Button btnIndexof;
        private System.Windows.Forms.Button btnsubstring;
        private System.Windows.Forms.Button btnstop;
    }
}