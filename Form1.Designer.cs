namespace csharp_barng_cuuwr_chuowng
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
            this.btnketqua = new System.Windows.Forms.Button();
            this.txtso = new System.Windows.Forms.TextBox();
            this.lsbketqua = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnketqua
            // 
            this.btnketqua.Location = new System.Drawing.Point(229, 369);
            this.btnketqua.Name = "btnketqua";
            this.btnketqua.Size = new System.Drawing.Size(110, 50);
            this.btnketqua.TabIndex = 0;
            this.btnketqua.Text = "xem";
            this.btnketqua.UseVisualStyleBackColor = true;
            this.btnketqua.Click += new System.EventHandler(this.btnketqua_Click);
            // 
            // txtso
            // 
            this.txtso.Location = new System.Drawing.Point(34, 191);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(179, 20);
            this.txtso.TabIndex = 1;
            // 
            // lsbketqua
            // 
            this.lsbketqua.FormattingEnabled = true;
            this.lsbketqua.Location = new System.Drawing.Point(34, 233);
            this.lsbketqua.Name = "lsbketqua";
            this.lsbketqua.Size = new System.Drawing.Size(179, 186);
            this.lsbketqua.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "BẢNG CỬU CHƯƠNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "bạn muốn xem bảng cửu chương mấy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbketqua);
            this.Controls.Add(this.txtso);
            this.Controls.Add(this.btnketqua);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnketqua;
        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.ListBox lsbketqua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

