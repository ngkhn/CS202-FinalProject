
namespace StudentModule
{
    partial class frmStartExam
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbExamID = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.uscClock = new StudentModule.uscClock();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbCauHoi = new System.Windows.Forms.Label();
            this.txtQuestContent = new System.Windows.Forms.TextBox();
            this.gbQuestion = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbExamID);
            this.groupBox1.Controls.Add(this.lbHoTen);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbExamID
            // 
            this.lbExamID.AutoSize = true;
            this.lbExamID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbExamID.Location = new System.Drawing.Point(12, 67);
            this.lbExamID.Name = "lbExamID";
            this.lbExamID.Size = new System.Drawing.Size(45, 15);
            this.lbExamID.TabIndex = 1;
            this.lbExamID.Text = "Mã đề:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHoTen.Location = new System.Drawing.Point(12, 45);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(64, 15);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Họ và tên:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbID.Location = new System.Drawing.Point(12, 23);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(26, 15);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID: ";
            // 
            // uscClock
            // 
            this.uscClock._mm = 0;
            this.uscClock._ss = 0;
            this.uscClock.Location = new System.Drawing.Point(342, 31);
            this.uscClock.Name = "uscClock";
            this.uscClock.Size = new System.Drawing.Size(234, 41);
            this.uscClock.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(474, 78);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(370, 78);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNop
            // 
            this.btnNop.Location = new System.Drawing.Point(582, 27);
            this.btnNop.Name = "btnNop";
            this.btnNop.Size = new System.Drawing.Size(75, 75);
            this.btnNop.TabIndex = 3;
            this.btnNop.Text = "Nộp";
            this.btnNop.UseVisualStyleBackColor = true;
            this.btnNop.Click += new System.EventHandler(this.btnNop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(336, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // lbCauHoi
            // 
            this.lbCauHoi.AutoSize = true;
            this.lbCauHoi.Location = new System.Drawing.Point(22, 126);
            this.lbCauHoi.Name = "lbCauHoi";
            this.lbCauHoi.Size = new System.Drawing.Size(28, 15);
            this.lbCauHoi.TabIndex = 5;
            this.lbCauHoi.Text = "Câu";
            // 
            // txtQuestContent
            // 
            this.txtQuestContent.Location = new System.Drawing.Point(22, 145);
            this.txtQuestContent.Multiline = true;
            this.txtQuestContent.Name = "txtQuestContent";
            this.txtQuestContent.Size = new System.Drawing.Size(450, 60);
            this.txtQuestContent.TabIndex = 6;
            // 
            // gbQuestion
            // 
            this.gbQuestion.Location = new System.Drawing.Point(12, 202);
            this.gbQuestion.Name = "gbQuestion";
            this.gbQuestion.Size = new System.Drawing.Size(474, 132);
            this.gbQuestion.TabIndex = 7;
            this.gbQuestion.TabStop = false;
            // 
            // frmStartExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(678, 346);
            this.Controls.Add(this.txtQuestContent);
            this.Controls.Add(this.btnNop);
            this.Controls.Add(this.lbCauHoi);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.uscClock);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbQuestion);
            this.Name = "frmStartExam";
            this.Text = "frmStartExam";
            this.Load += new System.EventHandler(this.frmStartExam_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbExamID;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbID;
        private uscClock uscClock;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbCauHoi;
        private System.Windows.Forms.TextBox txtQuestContent;
        private System.Windows.Forms.GroupBox gbQuestion;
    }
}