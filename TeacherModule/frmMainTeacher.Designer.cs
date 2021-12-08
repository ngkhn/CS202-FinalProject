
namespace TeacherModule
{
    partial class frmMainTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainTeacher));
            this.btnQLyCauHoi = new System.Windows.Forms.Button();
            this.btnQLyDeThi = new System.Windows.Forms.Button();
            this.btnQLyChamBai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQLyCauHoi
            // 
            this.btnQLyCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQLyCauHoi.Font = new System.Drawing.Font("Sitka Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQLyCauHoi.Location = new System.Drawing.Point(164, 121);
            this.btnQLyCauHoi.Name = "btnQLyCauHoi";
            this.btnQLyCauHoi.Size = new System.Drawing.Size(268, 51);
            this.btnQLyCauHoi.TabIndex = 0;
            this.btnQLyCauHoi.Text = "Quản lý câu hỏi";
            this.btnQLyCauHoi.UseVisualStyleBackColor = true;
            this.btnQLyCauHoi.Click += new System.EventHandler(this.btnQLyCauHoi_Click);
            // 
            // btnQLyDeThi
            // 
            this.btnQLyDeThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQLyDeThi.Font = new System.Drawing.Font("Sitka Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQLyDeThi.Location = new System.Drawing.Point(164, 188);
            this.btnQLyDeThi.Name = "btnQLyDeThi";
            this.btnQLyDeThi.Size = new System.Drawing.Size(268, 51);
            this.btnQLyDeThi.TabIndex = 0;
            this.btnQLyDeThi.Text = "Quản lý đề thi";
            this.btnQLyDeThi.UseVisualStyleBackColor = true;
            this.btnQLyDeThi.Click += new System.EventHandler(this.btnQLyDeThi_Click);
            // 
            // btnQLyChamBai
            // 
            this.btnQLyChamBai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQLyChamBai.Font = new System.Drawing.Font("Sitka Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQLyChamBai.Location = new System.Drawing.Point(164, 255);
            this.btnQLyChamBai.Name = "btnQLyChamBai";
            this.btnQLyChamBai.Size = new System.Drawing.Size(268, 51);
            this.btnQLyChamBai.TabIndex = 0;
            this.btnQLyChamBai.Text = "Quản lý kết quả thi";
            this.btnQLyChamBai.UseVisualStyleBackColor = true;
            this.btnQLyChamBai.Click += new System.EventHandler(this.btnQLyChamBai_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Minion Pro Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "SOẠN ĐỀ THI TRẮC NGHIỆM";
            // 
            // frmMainTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(597, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQLyChamBai);
            this.Controls.Add(this.btnQLyDeThi);
            this.Controls.Add(this.btnQLyCauHoi);
            this.Name = "frmMainTeacher";
            this.Text = "Soan de";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQLyCauHoi;
        private System.Windows.Forms.Button btnQLyDeThi;
        private System.Windows.Forms.Button btnQLyChamBai;
        private System.Windows.Forms.Label label1;
    }
}

