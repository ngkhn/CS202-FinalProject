
namespace TeacherModule
{
    partial class frmQuestionManagement
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
            this.lbxDsCauTraLoi = new System.Windows.Forms.ListBox();
            this.lvwDsCauHoi = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.gbDsCauHoi = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxChuDe = new System.Windows.Forms.ComboBox();
            this.gbNut = new System.Windows.Forms.GroupBox();
            this.btnXong = new System.Windows.Forms.Button();
            this.btnXoaCauHoi = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSuaCauHoi = new System.Windows.Forms.Button();
            this.btnThemCauHoi = new System.Windows.Forms.Button();
            this.gbSettingCauHoi = new System.Windows.Forms.GroupBox();
            this.txtMaCauHoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTrueFalse = new System.Windows.Forms.ComboBox();
            this.btnXoaCauTraLoi = new System.Windows.Forms.Button();
            this.txtNoiDungCauTraLoi = new System.Windows.Forms.TextBox();
            this.btnSuaCauTraLoi = new System.Windows.Forms.Button();
            this.txtNoiDungCauHoi = new System.Windows.Forms.TextBox();
            this.btnThemCauTraLoi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDsCauHoi.SuspendLayout();
            this.gbNut.SuspendLayout();
            this.gbSettingCauHoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxDsCauTraLoi
            // 
            this.lbxDsCauTraLoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxDsCauTraLoi.FormattingEnabled = true;
            this.lbxDsCauTraLoi.ItemHeight = 15;
            this.lbxDsCauTraLoi.Location = new System.Drawing.Point(6, 219);
            this.lbxDsCauTraLoi.Name = "lbxDsCauTraLoi";
            this.lbxDsCauTraLoi.Size = new System.Drawing.Size(544, 109);
            this.lbxDsCauTraLoi.TabIndex = 0;
            this.lbxDsCauTraLoi.SelectedIndexChanged += new System.EventHandler(this.lbxDsCauTraLoi_SelectedIndexChanged);
            // 
            // lvwDsCauHoi
            // 
            this.lvwDsCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDsCauHoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwDsCauHoi.FullRowSelect = true;
            this.lvwDsCauHoi.HideSelection = false;
            this.lvwDsCauHoi.Location = new System.Drawing.Point(18, 400);
            this.lvwDsCauHoi.Name = "lvwDsCauHoi";
            this.lvwDsCauHoi.Size = new System.Drawing.Size(750, 163);
            this.lvwDsCauHoi.TabIndex = 1;
            this.lvwDsCauHoi.UseCompatibleStateImageBehavior = false;
            this.lvwDsCauHoi.View = System.Windows.Forms.View.Details;
            this.lvwDsCauHoi.ItemActivate += new System.EventHandler(this.lvwDsCauHoi_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã câu hỏi";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nội dung câu hỏi";
            this.columnHeader2.Width = 520;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Chủ đề";
            this.columnHeader3.Width = 120;
            // 
            // gbDsCauHoi
            // 
            this.gbDsCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDsCauHoi.Controls.Add(this.btnSave);
            this.gbDsCauHoi.Controls.Add(this.btnLoad);
            this.gbDsCauHoi.Controls.Add(this.label1);
            this.gbDsCauHoi.Controls.Add(this.cbxChuDe);
            this.gbDsCauHoi.Location = new System.Drawing.Point(12, 359);
            this.gbDsCauHoi.Name = "gbDsCauHoi";
            this.gbDsCauHoi.Size = new System.Drawing.Size(762, 210);
            this.gbDsCauHoi.TabIndex = 2;
            this.gbDsCauHoi.TabStop = false;
            this.gbDsCauHoi.Text = "Danh sách câu hỏi";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(681, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(600, 15);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Reload";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chủ đề";
            // 
            // cbxChuDe
            // 
            this.cbxChuDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxChuDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChuDe.FormattingEnabled = true;
            this.cbxChuDe.Items.AddRange(new object[] {
            "All"});
            this.cbxChuDe.Location = new System.Drawing.Point(57, 16);
            this.cbxChuDe.Name = "cbxChuDe";
            this.cbxChuDe.Size = new System.Drawing.Size(147, 23);
            this.cbxChuDe.TabIndex = 0;
            this.cbxChuDe.SelectedIndexChanged += new System.EventHandler(this.cbxChuDe_SelectedIndexChanged);
            // 
            // gbNut
            // 
            this.gbNut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNut.Controls.Add(this.btnXong);
            this.gbNut.Controls.Add(this.btnXoaCauHoi);
            this.gbNut.Controls.Add(this.btnHuy);
            this.gbNut.Controls.Add(this.btnSuaCauHoi);
            this.gbNut.Controls.Add(this.btnThemCauHoi);
            this.gbNut.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbNut.Location = new System.Drawing.Point(574, 12);
            this.gbNut.Name = "gbNut";
            this.gbNut.Size = new System.Drawing.Size(200, 348);
            this.gbNut.TabIndex = 2;
            this.gbNut.TabStop = false;
            // 
            // btnXong
            // 
            this.btnXong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXong.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXong.Location = new System.Drawing.Point(103, 318);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(75, 23);
            this.btnXong.TabIndex = 3;
            this.btnXong.Text = "Xong";
            this.btnXong.UseVisualStyleBackColor = true;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // btnXoaCauHoi
            // 
            this.btnXoaCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaCauHoi.BackColor = System.Drawing.Color.Red;
            this.btnXoaCauHoi.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoaCauHoi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXoaCauHoi.Location = new System.Drawing.Point(24, 113);
            this.btnXoaCauHoi.Name = "btnXoaCauHoi";
            this.btnXoaCauHoi.Size = new System.Drawing.Size(152, 34);
            this.btnXoaCauHoi.TabIndex = 2;
            this.btnXoaCauHoi.Text = "Xoá câu hỏi";
            this.btnXoaCauHoi.UseVisualStyleBackColor = false;
            this.btnXoaCauHoi.Click += new System.EventHandler(this.btnXoaCauHoi_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.Location = new System.Drawing.Point(22, 318);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSuaCauHoi
            // 
            this.btnSuaCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaCauHoi.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSuaCauHoi.Location = new System.Drawing.Point(24, 75);
            this.btnSuaCauHoi.Name = "btnSuaCauHoi";
            this.btnSuaCauHoi.Size = new System.Drawing.Size(152, 34);
            this.btnSuaCauHoi.TabIndex = 1;
            this.btnSuaCauHoi.Text = "Chỉnh sửa câu hỏi";
            this.btnSuaCauHoi.UseVisualStyleBackColor = true;
            this.btnSuaCauHoi.Click += new System.EventHandler(this.btnSuaCauHoi_Click);
            // 
            // btnThemCauHoi
            // 
            this.btnThemCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemCauHoi.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThemCauHoi.Location = new System.Drawing.Point(24, 37);
            this.btnThemCauHoi.Name = "btnThemCauHoi";
            this.btnThemCauHoi.Size = new System.Drawing.Size(152, 34);
            this.btnThemCauHoi.TabIndex = 0;
            this.btnThemCauHoi.Text = "Thêm câu hỏi mới";
            this.btnThemCauHoi.UseVisualStyleBackColor = true;
            this.btnThemCauHoi.Click += new System.EventHandler(this.btnThemCauHoi_Click);
            // 
            // gbSettingCauHoi
            // 
            this.gbSettingCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSettingCauHoi.Controls.Add(this.txtMaCauHoi);
            this.gbSettingCauHoi.Controls.Add(this.label5);
            this.gbSettingCauHoi.Controls.Add(this.cbxTrueFalse);
            this.gbSettingCauHoi.Controls.Add(this.btnXoaCauTraLoi);
            this.gbSettingCauHoi.Controls.Add(this.txtNoiDungCauTraLoi);
            this.gbSettingCauHoi.Controls.Add(this.btnSuaCauTraLoi);
            this.gbSettingCauHoi.Controls.Add(this.txtNoiDungCauHoi);
            this.gbSettingCauHoi.Controls.Add(this.btnThemCauTraLoi);
            this.gbSettingCauHoi.Controls.Add(this.label4);
            this.gbSettingCauHoi.Controls.Add(this.label3);
            this.gbSettingCauHoi.Controls.Add(this.label2);
            this.gbSettingCauHoi.Controls.Add(this.lbxDsCauTraLoi);
            this.gbSettingCauHoi.Location = new System.Drawing.Point(12, 12);
            this.gbSettingCauHoi.Name = "gbSettingCauHoi";
            this.gbSettingCauHoi.Size = new System.Drawing.Size(556, 346);
            this.gbSettingCauHoi.TabIndex = 2;
            this.gbSettingCauHoi.TabStop = false;
            this.gbSettingCauHoi.Text = "Tuỳ chỉnh câu hỏi";
            // 
            // txtMaCauHoi
            // 
            this.txtMaCauHoi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMaCauHoi.Location = new System.Drawing.Point(450, 83);
            this.txtMaCauHoi.Name = "txtMaCauHoi";
            this.txtMaCauHoi.Size = new System.Drawing.Size(100, 23);
            this.txtMaCauHoi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã câu hỏi";
            // 
            // cbxTrueFalse
            // 
            this.cbxTrueFalse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbxTrueFalse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTrueFalse.FormattingEnabled = true;
            this.cbxTrueFalse.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbxTrueFalse.Location = new System.Drawing.Point(410, 125);
            this.cbxTrueFalse.Name = "cbxTrueFalse";
            this.cbxTrueFalse.Size = new System.Drawing.Size(65, 23);
            this.cbxTrueFalse.TabIndex = 3;
            // 
            // btnXoaCauTraLoi
            // 
            this.btnXoaCauTraLoi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXoaCauTraLoi.BackColor = System.Drawing.Color.Red;
            this.btnXoaCauTraLoi.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoaCauTraLoi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXoaCauTraLoi.Location = new System.Drawing.Point(481, 157);
            this.btnXoaCauTraLoi.Name = "btnXoaCauTraLoi";
            this.btnXoaCauTraLoi.Size = new System.Drawing.Size(65, 22);
            this.btnXoaCauTraLoi.TabIndex = 2;
            this.btnXoaCauTraLoi.Text = "Xoá";
            this.btnXoaCauTraLoi.UseVisualStyleBackColor = false;
            this.btnXoaCauTraLoi.Click += new System.EventHandler(this.btnXoaCauTraLoi_Click);
            // 
            // txtNoiDungCauTraLoi
            // 
            this.txtNoiDungCauTraLoi.Location = new System.Drawing.Point(6, 114);
            this.txtNoiDungCauTraLoi.Multiline = true;
            this.txtNoiDungCauTraLoi.Name = "txtNoiDungCauTraLoi";
            this.txtNoiDungCauTraLoi.Size = new System.Drawing.Size(392, 77);
            this.txtNoiDungCauTraLoi.TabIndex = 2;
            // 
            // btnSuaCauTraLoi
            // 
            this.btnSuaCauTraLoi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSuaCauTraLoi.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSuaCauTraLoi.Location = new System.Drawing.Point(410, 157);
            this.btnSuaCauTraLoi.Name = "btnSuaCauTraLoi";
            this.btnSuaCauTraLoi.Size = new System.Drawing.Size(65, 22);
            this.btnSuaCauTraLoi.TabIndex = 1;
            this.btnSuaCauTraLoi.Text = "Sửa";
            this.btnSuaCauTraLoi.UseVisualStyleBackColor = true;
            this.btnSuaCauTraLoi.Click += new System.EventHandler(this.btnSuaCauTraLoi_Click);
            // 
            // txtNoiDungCauHoi
            // 
            this.txtNoiDungCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoiDungCauHoi.Location = new System.Drawing.Point(6, 37);
            this.txtNoiDungCauHoi.Multiline = true;
            this.txtNoiDungCauHoi.Name = "txtNoiDungCauHoi";
            this.txtNoiDungCauHoi.Size = new System.Drawing.Size(544, 42);
            this.txtNoiDungCauHoi.TabIndex = 2;
            // 
            // btnThemCauTraLoi
            // 
            this.btnThemCauTraLoi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThemCauTraLoi.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThemCauTraLoi.Location = new System.Drawing.Point(481, 125);
            this.btnThemCauTraLoi.Name = "btnThemCauTraLoi";
            this.btnThemCauTraLoi.Size = new System.Drawing.Size(65, 22);
            this.btnThemCauTraLoi.TabIndex = 0;
            this.btnThemCauTraLoi.Text = "Thêm";
            this.btnThemCauTraLoi.UseVisualStyleBackColor = true;
            this.btnThemCauTraLoi.Click += new System.EventHandler(this.btnThemCauTraLoi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Danh sách câu trả lời";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nội dung câu trả lời";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nội dung câu hỏi";
            // 
            // frmQuestionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 581);
            this.Controls.Add(this.gbNut);
            this.Controls.Add(this.lvwDsCauHoi);
            this.Controls.Add(this.gbDsCauHoi);
            this.Controls.Add(this.gbSettingCauHoi);
            this.Name = "frmQuestionManagement";
            this.Text = "Quan ly cau hoi";
            this.Load += new System.EventHandler(this.frmQuestionManagement_Load);
            this.gbDsCauHoi.ResumeLayout(false);
            this.gbDsCauHoi.PerformLayout();
            this.gbNut.ResumeLayout(false);
            this.gbSettingCauHoi.ResumeLayout(false);
            this.gbSettingCauHoi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxDsCauTraLoi;
        private System.Windows.Forms.ListView lvwDsCauHoi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox gbDsCauHoi;
        private System.Windows.Forms.GroupBox gbNut;
        private System.Windows.Forms.GroupBox gbSettingCauHoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxChuDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnXoaCauHoi;
        private System.Windows.Forms.Button btnSuaCauHoi;
        private System.Windows.Forms.Button btnThemCauHoi;
        private System.Windows.Forms.Button btnXoaCauTraLoi;
        private System.Windows.Forms.TextBox txtNoiDungCauTraLoi;
        private System.Windows.Forms.Button btnSuaCauTraLoi;
        private System.Windows.Forms.TextBox txtNoiDungCauHoi;
        private System.Windows.Forms.Button btnThemCauTraLoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXong;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cbxTrueFalse;
        private System.Windows.Forms.TextBox txtMaCauHoi;
        private System.Windows.Forms.Label label5;
    }
}