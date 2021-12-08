using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace StudentModule
{
    public partial class frmStartExam : Form
    {
        List<Question> LstQuestion = new List<Question>();
        RadioButton[] LstRbtn = new RadioButton[1];
        TextBox[] LstTxtBox = new TextBox[1];
        int second = 0;
        int currentIndex = 0;
        public frmStartExam()
        {
            InitializeComponent();
        }

        private void frmStartExam_Load(object sender, EventArgs e)
        {
            LoadExamFile(Path.FilePath);

            // Thong tin ca nhan
            lbID.Text = $"ID: {Student.StuID}";
            lbHoTen.Text = $"Họ và tên: {Student.Name}";
            lbExamID.Text = $"Mã đề thi: {Student.ExamID}";
            
            for (int i = 0; i < LstQuestion.Count; i++)
                Student.lstAnswer.Add("");

            // Set dong ho dem gio
            SetClock();
            uscClock.Start();
            uscClock.uscEClock_Exit += new uscClock.uscEClock_ExitHandle(uscClock_uscEClock_Exit);

            // Set cau hoi hien thi
            SetQuestion();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                gbQuestion.Controls.Clear();
                SetQuestion();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(currentIndex < LstQuestion.Count - 1)
            {
                currentIndex++;
                gbQuestion.Controls.Clear();
                SetQuestion();
            }    
        }

        private void btnNop_Click(object sender, EventArgs e)
        {
            uscClock.Stop();
            SaveAnswerFile();
            Student.lstAnswer.Clear();
            MessageBox.Show("Hoang thanh bai thi", "Notification", MessageBoxButtons.OK);
            this.Close();
        }

        private void LoadExamFile(string path)
        {
            using (var xml = XmlReader.Create(path))
            {
                xml.ReadToFollowing("Exam");
                xml.MoveToAttribute("ExamID");
                Student.ExamID = xml.Value;
                xml.ReadToFollowing("Time");
                second = xml.ReadElementContentAsInt();
                while (xml.ReadToFollowing("Question"))
                {

                    Question tmpQuest = new Question();
                    //Quest content
                    xml.ReadToFollowing("Content");
                    tmpQuest.Content = xml.ReadElementContentAsString();

                    //Quest options
                    xml.ReadToFollowing("LstOption");
                    xml.MoveToAttribute("count");
                    int count = int.Parse(xml.Value);
                    for (int i = 0; i < count; i++)
                    {
                        xml.ReadToFollowing("Option");
                        tmpQuest.LstOption.Add(xml.ReadElementContentAsString());
                    }
                    LstQuestion.Add(tmpQuest);
                }
            }
        }

        private void SaveAnswerFile()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Luu bai thi .xml|*.xml";

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                using (var xml = XmlWriter.Create(dlg.FileName, new XmlWriterSettings() { Indent = true }))
                {
                    xml.WriteStartElement("Student");

                    xml.WriteAttributeString("StuID", Student.StuID);

                    xml.WriteStartElement("Name");
                    xml.WriteValue(Student.Name);
                    xml.WriteEndElement();

                    xml.WriteStartElement("ExamID");
                    xml.WriteValue(Student.ExamID);
                    xml.WriteEndElement();

                    xml.WriteStartElement("LstAnswer");
                    foreach (var a in Student.lstAnswer)
                    {
                        xml.WriteStartElement("Answer");
                        xml.WriteValue(a);
                        xml.WriteEndElement();
                    }
                    xml.WriteEndElement();
                }
            }    
        }

        private void SetClock()
        {
            int minute = second / 60;
            uscClock._mm = minute;
            uscClock._ss = second - minute * 60;
        }

        void uscClock_uscEClock_Exit()
        {
            uscClock.Stop();
            MessageBox.Show("Het thoi gian lam bai", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            SaveAnswerFile();
            Student.lstAnswer.Clear();
        }

        private void SetQuestion()
        {
            //Quest content
            lbCauHoi.Text = $"Câu {currentIndex + 1}";
            txtQuestContent.Text = LstQuestion[currentIndex].Content;

            //Quest options
            LstRbtn = new RadioButton[LstQuestion[currentIndex].LstOption.Count];
            LstTxtBox = new TextBox[LstQuestion[currentIndex].LstOption.Count];
            for (int i = 0; i < LstRbtn.Length; i++)
            {
                // radio button
                LstRbtn[i] = new RadioButton();
                LstRbtn[i].Size = new Size(20, 20);
                LstRbtn[i].Location = new Point(12, 20 + 55 * i);
                LstRbtn[i].Text = "";
                LstRbtn[i].CheckedChanged += UscQuestion_CheckedChanged;

                // textbox
                LstTxtBox[i] = new TextBox();
                LstTxtBox[i].Enabled = false;
                LstTxtBox[i].Multiline = true;
                LstTxtBox[i].Size = new Size(380, 50);
                LstTxtBox[i].Location = new Point(35, 20 + 55 * i);
                LstTxtBox[i].Text = LstQuestion[currentIndex].LstOption[i];

                this.ClientSize = new Size(700, 320 + 55 * i);
                gbQuestion.ClientSize = new Size(475, 80 + 55 * i);
                gbQuestion.Controls.Add(LstRbtn[i]);
                gbQuestion.Controls.Add(LstTxtBox[i]);
            }
            if (Student.lstAnswer[currentIndex] != "")
            {
                String tmpAnswer = Student.lstAnswer[currentIndex];
                LstRbtn[int.Parse(tmpAnswer)].Checked = true;
            }
        }

        private void UscQuestion_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < LstRbtn.Length; i++)
                if (LstRbtn[i].Checked)
                    Student.lstAnswer[currentIndex] = i.ToString();
        }

        
    }
}
