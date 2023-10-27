
namespace Calculator
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
            this.soA = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.soB = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Kq = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // soA
            // 
            this.soA.AutoSize = true;
            this.soA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.soA.Location = new System.Drawing.Point(99, 74);
            this.soA.Name = "soA";
            this.soA.Size = new System.Drawing.Size(44, 21);
            this.soA.TabIndex = 0;
            this.soA.Text = "So a ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(167, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 1;
            // 
            // soB
            // 
            this.soB.AutoSize = true;
            this.soB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.soB.Location = new System.Drawing.Point(99, 121);
            this.soB.Name = "soB";
            this.soB.Size = new System.Drawing.Size(41, 21);
            this.soB.TabIndex = 0;
            this.soB.Text = "So b";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(167, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 1;
            // 
            // Kq
            // 
            this.Kq.AutoSize = true;
            this.Kq.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Kq.Location = new System.Drawing.Point(99, 173);
            this.Kq.Name = "Kq";
            this.Kq.Size = new System.Drawing.Size(62, 21);
            this.Kq.TabIndex = 0;
            this.Kq.Text = "Ket qua";
            this.Kq.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(167, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 29);
            this.textBox3.TabIndex = 1;
            // 
            // btCong
            // 
            this.btCong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCong.Location = new System.Drawing.Point(228, 236);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(92, 35);
            this.btCong.TabIndex = 2;
            this.btCong.Text = "Cong";
            this.btCong.UseVisualStyleBackColor = true;
            // 
            // btTru
            // 
            this.btTru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTru.Location = new System.Drawing.Point(86, 236);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(92, 35);
            this.btTru.TabIndex = 2;
            this.btTru.Text = "Tru";
            this.btTru.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 349);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Kq);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.soB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.soA);
            this.Name = "Form1";
            this.Text = "Tính toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label soA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label soB;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Kq;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btTru;
    }
}

