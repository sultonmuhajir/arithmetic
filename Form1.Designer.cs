
namespace aritmatika
{
    partial class aritmatika
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
            this.judul = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.hasil = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // judul
            // 
            this.judul.AutoSize = true;
            this.judul.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.judul.Location = new System.Drawing.Point(118, 15);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(158, 38);
            this.judul.TabIndex = 0;
            this.judul.Text = "Aritmatika";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(27, 70);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(337, 31);
            this.num1.TabIndex = 1;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(27, 123);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(337, 31);
            this.num2.TabIndex = 2;
            // 
            // hasil
            // 
            this.hasil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hasil.Location = new System.Drawing.Point(27, 179);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(337, 129);
            this.hasil.TabIndex = 3;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sum.Location = new System.Drawing.Point(26, 335);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 60);
            this.sum.TabIndex = 4;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sub.Location = new System.Drawing.Point(26, 401);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(100, 60);
            this.sub.TabIndex = 5;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // mul
            // 
            this.mul.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mul.Location = new System.Drawing.Point(132, 335);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(100, 60);
            this.mul.TabIndex = 6;
            this.mul.Text = "x";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.div.Location = new System.Drawing.Point(132, 401);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(100, 60);
            this.div.TabIndex = 7;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(238, 335);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(126, 126);
            this.clear.TabIndex = 8;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // aritmatika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 494);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.judul);
            this.Name = "aritmatika";
            this.Text = "Aritmatika";
            this.Load += new System.EventHandler(this.aritmatika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label judul;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label hasil;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button clear;
    }
}

