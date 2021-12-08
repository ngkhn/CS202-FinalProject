using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherModule
{
    public partial class frmMainTeacher : Form
    {
        public frmMainTeacher()
        {
            InitializeComponent();
        }

        private void btnQLyCauHoi_Click(object sender, EventArgs e)
        {
            frmQuestionManagement frmQMnage = new frmQuestionManagement();
            this.Visible = false;
            frmQMnage.ShowDialog();
            this.Show();
        }

        private void btnQLyDeThi_Click(object sender, EventArgs e)
        {
            frmExamManagement frmEMnage = new frmExamManagement();
            this.Visible = false;
            frmEMnage.ShowDialog();
            this.Show();
        }

        private void btnQLyChamBai_Click(object sender, EventArgs e)
        {
            frmResultManagement frmRMnage = new frmResultManagement();
            this.Visible = false;
            frmRMnage.ShowDialog();
            this.Show();
        }
    }
}
