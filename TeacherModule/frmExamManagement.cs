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
    public partial class frmExamManagement : Form
    {
        string[] QuestionFolders = Directory.GetDirectories("xml file/NganHangCauHoi/");
        string[] ExamFiles = Directory.GetFiles("xml file/NganHangDeThi/DeThi/");

        List<String> lstTopic = new List<String>();
        List<List<Question>> lstTopicQuest = new List<List<Question>>();
        List<Exam> lstExam = new List<Exam>();
        Exam currentExam = new Exam();

        TrackBar[] lstTrackbar = new TrackBar[1];

        public frmExamManagement()
        {
            InitializeComponent();
        }

        private void frmExamManagement_Load(object sender, EventArgs e)
        {
            lstTrackbar = new TrackBar[QuestionFolders.Length];
            for (int i = 0; i < QuestionFolders.Length; i++)
            {
                FileInfo fi = new FileInfo(QuestionFolders[i]);;
                string[] filepath = Directory.GetFiles(fi.FullName);
                LoadQuestionFile(filepath[0]);
                lstTopic.Add(fi.Name);

                //Create label
                Label lb = new Label();
                lb.Size =  new Size(130, 20);
                lb.Text = fi.Name;
                lb.Location = new Point(12, 170 + 40 * i);

                //Create trackbar
                lstTrackbar[i] = new TrackBar();
                lstTrackbar[i].Location = new Point(150, 170 + 40 * i);
                lstTrackbar[i].Maximum = lstTopicQuest[i].Count;
                lstTrackbar[i].SmallChange = 1;
                lstTrackbar[i].Scroll += Trb_Scroll;

                Controls.Add(lb);
                Controls.Add(lstTrackbar[i]);
                
                ClientSize = new Size(400, 220 + 40 * i);
            }
            
            foreach(var file in ExamFiles)
                LoadExamFile(file);
 
        }

        private void Trb_Scroll(object sender, EventArgs e)
        {
            int num = 0;
            for (int i = 0; i < lstTopicQuest.Count; i++)
                num += lstTrackbar[i].Value;

            lbSoCauHoi.Text = num.ToString();
        }

        private bool checkValidExam()
        {
            //Ma de khong duoc de trong
            if (txtMaDeThi.Text == "")
                return false;

            //Ma de khong duoc trung
            foreach(ListViewItem item in lvwDsDeThi.Items)
                if (txtMaDeThi.Text == item.Text)
                    return false;

            //So cau hoi tu 2 tro len
            if (int.Parse(lbSoCauHoi.Text) < 2)
                return false;

            return true;
        }

        private void btnTaoDe_Click(object sender, EventArgs e)
        {
            if (!checkValidExam())
                MessageBox.Show("De thi khong hop le", "Notification");
            else
            {
                //Create exam
                currentExam.ExamID = txtMaDeThi.Text;
                for (int i = 0; i < lstTopicQuest.Count; i++)
                {
                    List<Question> tmpLstQuest = new List<Question>();
                    for (int j = 0; j < lstTrackbar[i].Value; j++)
                        tmpLstQuest.Add(lstTopicQuest[i][j]);
                    currentExam.LstQuestion.AddRange(new List<Question>(tmpLstQuest));
                }

                //Add new Exam to listview
                ListViewItem lvi = new ListViewItem();
                lvi.Text = currentExam.ExamID;
                lvi.SubItems.Add(currentExam.LstQuestion.Count.ToString());
                lvwDsDeThi.Items.Add(lvi);

                //Random and save file
                currentExam.Random();
                currentExam.SaveExamFile();
                currentExam.SaveKeyFile();

                lstExam.Add(new Exam(currentExam));
                currentExam.LstQuestion.Clear();
            }
        }

        private void btnXoaDe_Click(object sender, EventArgs e)
        {
            if (lvwDsDeThi.SelectedItems.Count == 0)

                MessageBox.Show("Chua chon de thi de xoa", "Notification");
            else
            {
                int index = lvwDsDeThi.SelectedItems[0].Index;
                File.Delete(ExamFiles[index]);
                lstExam.RemoveAt(index);
                lvwDsDeThi.Items.Remove(lvwDsDeThi.SelectedItems[0]);
            }
        }

        private void lvwDsDeThi_ItemActivate(object sender, EventArgs e)
        {
            currentExam.LstQuestion.Clear();
            int index = lvwDsDeThi.SelectedItems[0].Index;
            txtMaDeThi.Text = lstExam[index].ExamID;
            lbSoCauHoi.Text = lstExam[index].LstQuestion.Count.ToString();

            for (int i = 0; i < QuestionFolders.Length; i++)
            {
                lstTrackbar[i].Value = 0;
                foreach (var q in lstExam[index].LstQuestion)
                    if (q.Topic == lstTopic[i])
                        lstTrackbar[i].Value++;
            }    
        }

        private void LoadQuestionFile(string path)
        {
            using (var xml = XmlReader.Create(path))
            {
                List<Question> tmpLstQuest = new List<Question>();
                while (xml.ReadToFollowing("Question"))
                { 

                    Question tmpQuest = new Question();

                    //QuestID
                    xml.MoveToAttribute("QuestID");
                    tmpQuest.QuestID = xml.Value;

                    //Quest topic
                    xml.ReadToFollowing("Topic");
                    tmpQuest.Topic = xml.ReadElementContentAsString();

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
                        Option tmpOption = new Option();

                        //Option check true/false
                        xml.MoveToAttribute("isTrue");
                        if (xml.Value == "true")
                            tmpOption.isTrue = true;

                        //Option content
                        xml.ReadToFollowing("Content");
                        tmpOption.Content = xml.ReadElementContentAsString();

                        tmpQuest.LstOption.Add(tmpOption);
                    }

                    tmpLstQuest.Add(tmpQuest);
                }
                lstTopicQuest.Add(new List<Question>(tmpLstQuest));
            }
        }

        private void LoadExamFile(string path)
        {
            using (var xml = XmlReader.Create(path))
            {
                Exam tmpExam = new Exam();
                ListViewItem lvi = new ListViewItem();

                xml.ReadToFollowing("Exam");
                xml.MoveToAttribute("ExamID");
                tmpExam.ExamID = xml.Value;
                while (xml.ReadToFollowing("Question"))
                {

                    Question tmpQuest = new Question();

                    //QuestID
                    xml.MoveToAttribute("QuestID");
                    tmpQuest.QuestID = xml.Value;

                    //Quest topic
                    xml.ReadToFollowing("Topic");
                    tmpQuest.Topic = xml.ReadElementContentAsString();

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
                        Option tmpOption = new Option();
                        tmpOption.Content = xml.ReadElementContentAsString();

                        tmpQuest.LstOption.Add(tmpOption);
                    }

                    tmpExam.LstQuestion.Add(tmpQuest);
                }

                lvi.Text = tmpExam.ExamID;
                lvi.SubItems.Add(tmpExam.LstQuestion.Count.ToString());

                lstExam.Add(tmpExam);
                lvwDsDeThi.Items.Add(lvi);
            }
        }
    }
}
