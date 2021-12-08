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
using System.Xml;

namespace TeacherModule
{
    public partial class frmResultManagement : Form
    {
        string[] KeyFiles = Directory.GetFiles("xml file/NganHangDeThi/DapAn/");
        string[] AnswerFolders = Directory.GetDirectories("xml file/DapAnThiSinh/");
        List<Student> LstStudent = new List<Student>();
        List<String> currentKeys = new List<String>();
        List<String> currentAnswers = new List<String>();

        public frmResultManagement()
        {
            InitializeComponent();
        }

        private void frmResultManagement_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            foreach (var folder in AnswerFolders)
            {
                FileInfo fi = new FileInfo(folder);
                cbxDeThi.Items.Add(fi.Name);
            }    
        }

        private void cbxDeThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LstStudent.Clear();
            lvwDsThiSinh.Items.Clear();
            int index = cbxDeThi.SelectedIndex;
            if (index < 0)
                btnSave.Enabled = false;
            else
            {
                btnSave.Enabled = true;
                ReadKeyFile(KeyFiles[index]);
                string[] AnswerFiles = Directory.GetFiles(AnswerFolders[index]);
                foreach (var file in AnswerFiles)
                    ReadAnswerFile(file);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Luu tap tin ket qua .txt|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);

                writer.WriteLine(cbxDeThi.Text);
                writer.WriteLine(LstStudent.Count.ToString());
                for (int i = 0; i < LstStudent.Count; i++)
                    writer.WriteLine(LstStudent[i].ToFile());

                writer.Close();
            }
        }

        private void ReadKeyFile(string path)
        {
            currentKeys.Clear();
            using (var xml = XmlReader.Create(path))
            {
                while (xml.ReadToFollowing("Key"))
                {
                    currentKeys.Add(xml.ReadElementContentAsString());
                }    
            }    
        }

        private void ReadAnswerFile(string path)
        {
            using (var xml = XmlReader.Create(path))
            {
                Student stu = new Student();
                ListViewItem lvi = new ListViewItem();

                xml.ReadToFollowing("Student");

                // student id
                xml.MoveToAttribute("StuID");
                stu.StuID = xml.Value;

                // student name
                xml.ReadToFollowing("Name");
                stu.Name = xml.ReadElementContentAsString();

                currentAnswers.Clear();
                while (xml.ReadToFollowing("Answer"))
                {
                    currentAnswers.Add(xml.ReadElementContentAsString());
                }
                int count = 0;
                for (int i = 0; i < currentKeys.Count; i++)
                    if (currentAnswers[i] == currentKeys[i])
                        count++;
                stu.Grade = 10 * ((float)count / currentKeys.Count);

                lvi.Text = stu.StuID;
                lvi.SubItems.Add(stu.Name);
                lvi.SubItems.Add(stu.Grade.ToString());

                LstStudent.Add(stu);
                lvwDsThiSinh.Items.Add(lvi);
            }    
        }

        
    }
}
