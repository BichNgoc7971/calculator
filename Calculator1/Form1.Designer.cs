
namespace Calculator1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCong = new System.Windows.Forms.Button();
            this.txtTinhtoan = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(418, 289);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(75, 52);
            this.btCong.TabIndex = 0;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            // 
            // txtTinhtoan
            // 
            this.txtTinhtoan.AutoSize = true;
            this.txtTinhtoan.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTinhtoan.Location = new System.Drawing.Point(254, 58);
            this.txtTinhtoan.Name = "txtTinhtoan";
            this.txtTinhtoan.Size = new System.Drawing.Size(86, 25);
            this.txtTinhtoan.TabIndex = 1;
            this.txtTinhtoan.Text = "Tính toán";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(149, 150);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(346, 31);
            this.txtA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(65, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(65, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(65, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kết quả:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(147, 191);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(346, 31);
            this.txtB.TabIndex = 6;
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(148, 232);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(346, 31);
            this.txtKetqua.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 374);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtTinhtoan);
            this.Controls.Add(this.btCong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Label txtTinhtoan;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtKetqua;
    }
}

