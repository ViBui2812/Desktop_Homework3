namespace Desktop_Homework3
{
    partial class Form_USCLN
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
            this.txtSothu1 = new System.Windows.Forms.TextBox();
            this.txtSothu2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtUSC = new System.Windows.Forms.RadioButton();
            this.rbtUSCLN = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnKQ = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSothu1
            // 
            this.txtSothu1.Location = new System.Drawing.Point(210, 104);
            this.txtSothu1.Name = "txtSothu1";
            this.txtSothu1.Size = new System.Drawing.Size(116, 20);
            this.txtSothu1.TabIndex = 0;
            // 
            // txtSothu2
            // 
            this.txtSothu2.Location = new System.Drawing.Point(210, 131);
            this.txtSothu2.Name = "txtSothu2";
            this.txtSothu2.Size = new System.Drawing.Size(116, 20);
            this.txtSothu2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số Thứ 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số Thứ 2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtUSC);
            this.groupBox1.Controls.Add(this.rbtUSCLN);
            this.groupBox1.Location = new System.Drawing.Point(343, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 73);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // rbtUSC
            // 
            this.rbtUSC.AutoSize = true;
            this.rbtUSC.Location = new System.Drawing.Point(20, 42);
            this.rbtUSC.Name = "rbtUSC";
            this.rbtUSC.Size = new System.Drawing.Size(47, 17);
            this.rbtUSC.TabIndex = 1;
            this.rbtUSC.TabStop = true;
            this.rbtUSC.Text = "USC";
            this.rbtUSC.UseVisualStyleBackColor = true;
            this.rbtUSC.CheckedChanged += new System.EventHandler(this.rbtUSC_CheckedChanged);
            // 
            // rbtUSCLN
            // 
            this.rbtUSCLN.AutoSize = true;
            this.rbtUSCLN.Location = new System.Drawing.Point(20, 19);
            this.rbtUSCLN.Name = "rbtUSCLN";
            this.rbtUSCLN.Size = new System.Drawing.Size(61, 17);
            this.rbtUSCLN.TabIndex = 0;
            this.rbtUSCLN.TabStop = true;
            this.rbtUSCLN.Text = "USCLN";
            this.rbtUSCLN.UseVisualStyleBackColor = true;
            this.rbtUSCLN.CheckedChanged += new System.EventHandler(this.rbtUSCLN_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(210, 186);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(116, 95);
            this.listBox1.TabIndex = 5;
            // 
            // btnKQ
            // 
            this.btnKQ.Location = new System.Drawing.Point(210, 157);
            this.btnKQ.Name = "btnKQ";
            this.btnKQ.Size = new System.Drawing.Size(75, 23);
            this.btnKQ.TabIndex = 6;
            this.btnKQ.Text = "Kết Quả";
            this.btnKQ.UseVisualStyleBackColor = true;
            this.btnKQ.Click += new System.EventHandler(this.btnKQ_Click);
            // 
            // Form_USCLN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 397);
            this.Controls.Add(this.btnKQ);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSothu2);
            this.Controls.Add(this.txtSothu1);
            this.Name = "Form_USCLN";
            this.Text = "USCLN & USC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSothu1;
        private System.Windows.Forms.TextBox txtSothu2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtUSC;
        private System.Windows.Forms.RadioButton rbtUSCLN;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnKQ;
    }
}

