
namespace TeacherModule
{
    partial class frmResultManagement
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
            this.lvwDsThiSinh = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxDeThi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lvwDsThiSinh
            // 
            this.lvwDsThiSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDsThiSinh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.lvwDsThiSinh.FullRowSelect = true;
            this.lvwDsThiSinh.HideSelection = false;
            this.lvwDsThiSinh.Location = new System.Drawing.Point(12, 41);
            this.lvwDsThiSinh.Name = "lvwDsThiSinh";
            this.lvwDsThiSinh.Size = new System.Drawing.Size(374, 213);
            this.lvwDsThiSinh.TabIndex = 0;
            this.lvwDsThiSinh.UseCompatibleStateImageBehavior = false;
            this.lvwDsThiSinh.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã thí sinh";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Điểm";
            this.columnHeader4.Width = 50;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(311, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxDeThi
            // 
            this.cbxDeThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDeThi.FormattingEnabled = true;
            this.cbxDeThi.Location = new System.Drawing.Point(13, 12);
            this.cbxDeThi.Name = "cbxDeThi";
            this.cbxDeThi.Size = new System.Drawing.Size(121, 23);
            this.cbxDeThi.TabIndex = 2;
            this.cbxDeThi.SelectedIndexChanged += new System.EventHandler(this.cbxDeThi_SelectedIndexChanged);
            // 
            // frmResultManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 266);
            this.Controls.Add(this.cbxDeThi);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lvwDsThiSinh);
            this.Name = "frmResultManagement";
            this.Text = "Quan ly ket qua";
            this.Load += new System.EventHandler(this.frmResultManagement_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwDsThiSinh;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbxDeThi;
    }
}