using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentModule
{
    public partial class frmMainStudent : Form
    {
        OpenFileDialog dlg = new OpenFileDialog();
            
        public frmMainStudent()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            dlg.Filter = "Chon de thi .xml|*.xml";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(dlg.FileName);

                txtFileName.Text = fi.Name;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
                MessageBox.Show("Chua nhap mssv.", "Notification");
            else if (txtHoTen.Text == "")
                MessageBox.Show("Chua ho va ten.", "Notification");
            else
            {
                frmStartExam frm = new frmStartExam();
                this.Visible = false;

                Student.StuID = txtID.Text;
                Student.Name = txtHoTen.Text;
                Path.FilePath = dlg.FileName;

                frm.ShowDialog();
                this.Show();
            }
        }
    }
}
