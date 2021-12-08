
namespace TeacherModule
{
    partial class frmExamManagement
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
            this.btnTaoDe = new System.Windows.Forms.Button();
            this.lvwDsDeThi = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.btnXoaDe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDeThi = new System.Windows.Forms.TextBox();
            this.lbSoCauHoi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTaoDe
            // 
            this.btnTaoDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaoDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTaoDe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTaoDe.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTaoDe.Location = new System.Drawing.Point(297, 122);
            this.btnTaoDe.Name = "btnTaoDe";
            this.btnTaoDe.Size = new System.Drawing.Size(75, 26);
            this.btnTaoDe.TabIndex = 0;
            this.btnTaoDe.Text = "Tạo";
            this.btnTaoDe.UseVisualStyleBackColor = false;
            this.btnTaoDe.Click += new System.EventHandler(this.btnTaoDe_Click);
            // 
            // lvwDsDeThi
            // 
            this.lvwDsDeThi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDsDeThi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwDsDeThi.FullRowSelect = true;
            this.lvwDsDeThi.HideSelection = false;
            this.lvwDsDeThi.Location = new System.Drawing.Point(12, 27);
            this.lvwDsDeThi.Name = "lvwDsDeThi";
            this.lvwDsDeThi.Size = new System.Drawing.Size(360, 91);
            this.lvwDsDeThi.TabIndex = 1;
            this.lvwDsDeThi.UseCompatibleStateImageBehavior = false;
            this.lvwDsDeThi.View = System.Windows.Forms.View.Details;
            this.lvwDsDeThi.ItemActivate += new System.EventHandler(this.lvwDsDeThi_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã đề thi";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng câu hỏi";
            this.columnHeader2.Width = 170;
            // 
            // btnXoaDe
            // 
            this.btnXoaDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaDe.BackColor = System.Drawing.Color.Red;
            this.btnXoaDe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoaDe.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXoaDe.Location = new System.Drawing.Point(297, 154);
            this.btnXoaDe.Name = "btnXoaDe";
            this.btnXoaDe.Size = new System.Drawing.Size(75, 26);
            this.btnXoaDe.TabIndex = 0;
            this.btnXoaDe.Text = "Xoá";
            this.btnXoaDe.UseVisualStyleBackColor = false;
            this.btnXoaDe.Click += new System.EventHandler(this.btnXoaDe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách đề thi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã đề thi";
            // 
            // txtMaDeThi
            // 
            this.txtMaDeThi.Location = new System.Drawing.Point(75, 132);
            this.txtMaDeThi.Name = "txtMaDeThi";
            this.txtMaDeThi.Size = new System.Drawing.Size(83, 23);
            this.txtMaDeThi.TabIndex = 3;
            // 
            // lbSoCauHoi
            // 
            this.lbSoCauHoi.AutoSize = true;
            this.lbSoCauHoi.Location = new System.Drawing.Point(241, 135);
            this.lbSoCauHoi.Name = "lbSoCauHoi";
            this.lbSoCauHoi.Size = new System.Drawing.Size(13, 15);
            this.lbSoCauHoi.TabIndex = 4;
            this.lbSoCauHoi.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số câu hỏi:";
            // 
            // frmExamManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 241);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSoCauHoi);
            this.Controls.Add(this.txtMaDeThi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwDsDeThi);
            this.Controls.Add(this.btnXoaDe);
            this.Controls.Add(this.btnTaoDe);
            this.Name = "frmExamManagement";
            this.Text = "Quan ly de thi";
            this.Load += new System.EventHandler(this.frmExamManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaoDe;
        private System.Windows.Forms.ListView lvwDsDeThi;
        private System.Windows.Forms.Button btnXoaDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDeThi;
        private System.Windows.Forms.Label lbSoCauHoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}