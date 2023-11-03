
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
            this.tbA = new System.Windows.Forms.TextBox();
            this.soB = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.Kq = new System.Windows.Forms.Label();
            this.tbKQ = new System.Windows.Forms.TextBox();
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
            // tbA
            // 
            this.tbA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbA.Location = new System.Drawing.Point(167, 71);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 29);
            this.tbA.TabIndex = 1;
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
            // tbB
            // 
            this.tbB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbB.Location = new System.Drawing.Point(167, 118);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 29);
            this.tbB.TabIndex = 1;
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
            // tbKQ
            // 
            this.tbKQ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbKQ.Location = new System.Drawing.Point(167, 170);
            this.tbKQ.Name = "tbKQ";
            this.tbKQ.Size = new System.Drawing.Size(100, 29);
            this.tbKQ.TabIndex = 1;
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
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btTru
            // 
            this.btTru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btTru.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.Controls.Add(this.tbKQ);
            this.Controls.Add(this.Kq);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.soB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.soA);
            this.Name = "Form1";
            this.Text = "Tính toán";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label soA;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label soB;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label Kq;
        private System.Windows.Forms.TextBox tbKQ;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btTru;
    }
}

