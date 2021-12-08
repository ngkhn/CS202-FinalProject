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
    public partial class frmQuestionManagement : Form
    {
        List<Question> lstQuest = new List<Question>();
        List<Option> lstOption = new List<Option>();
        bool isSave = true;
        bool isAdding = false;
        string currentTopic;
        string[] folders = Directory.GetDirectories("xml file/NganHangCauHoi/");

        public frmQuestionManagement()
        {
            InitializeComponent();
        }

        private void EnableTools()
        {
            btnHuy.Enabled = true;
            btnXong.Enabled = true;

            txtNoiDungCauHoi.Enabled = true;
            txtMaCauHoi.Enabled = true;
            txtNoiDungCauTraLoi.Enabled = true;
            lbxDsCauTraLoi.Enabled = true;
            cbxTrueFalse.Enabled = true;
            btnThemCauTraLoi.Enabled = true;
            btnSuaCauTraLoi.Enabled = true;
            btnXoaCauTraLoi.Enabled = true;
        }

        private void UnableTools()
        {
            btnHuy.Enabled = false;
            btnXong.Enabled = false;

            txtNoiDungCauHoi.Enabled = false;
            txtMaCauHoi.Enabled = false;
            txtNoiDungCauTraLoi.Enabled = false;
            lbxDsCauTraLoi.Enabled = false;
            cbxTrueFalse.Enabled = false;
            btnThemCauTraLoi.Enabled = false;
            btnSuaCauTraLoi.Enabled = false;
            btnXoaCauTraLoi.Enabled = false;
        }

        private void clearTextbox()
        {
            txtMaCauHoi.Clear();
            txtNoiDungCauHoi.Clear();
            txtNoiDungCauTraLoi.Clear();
            lbxDsCauTraLoi.Items.Clear();
            lstOption.Clear();
        }
        
        private bool checkQuestID(string id)
        {
            foreach (var q in lstQuest)
                if (id == q.QuestID)
                    return false;
            return true;
        }

        private bool checkLstOption()
        {
            if (lstOption.Count < 2)
                return false;
            int countTrue = 0;
            foreach (var o in lstOption)
            {
                if (o.isTrue)
                    countTrue++;
            }
            return countTrue == 1;
        }

        private void LoadFile(string path)
        {
            using(var xml = XmlReader.Create(path))
            {
                while(xml.ReadToFollowing("Question"))
                {
                    Question tmpQuest = new Question();
                    ListViewItem lvi = new ListViewItem();

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
                    for(int i = 0; i < count; i++)
                    {
                        xml.ReadToFollowing("Option");
                        Option tmpOption = new Option();

                        //Option check true/false
                        xml.MoveToAttribute("isTrue");
                        if(xml.Value == "true")
                            tmpOption.isTrue = true;

                        //Option content
                        xml.ReadToFollowing("Content");
                        tmpOption.Content = xml.ReadElementContentAsString();

                        tmpQuest.LstOption.Add(tmpOption);
                    }

                    lvi.Text = tmpQuest.QuestID;
                    lvi.SubItems.Add(tmpQuest.Content);
                    lvi.SubItems.Add(tmpQuest.Topic);

                    lstQuest.Add(tmpQuest);
                    lvwDsCauHoi.Items.Add(lvi);
                }    
            }    
        }

        private void SaveFile(string path)
        {
            using (var xml = XmlWriter.Create(path, new XmlWriterSettings() { Indent = true}))
            {
                xml.WriteStartElement("LstQuestion");
                foreach(var q in lstQuest)
                {
                    xml.WriteStartElement("Question");

                    //QuestID
                    xml.WriteAttributeString("QuestID", q.QuestID);

                    //Quest topic
                    xml.WriteStartElement("Topic");
                    xml.WriteValue(q.Topic);
                    xml.WriteEndElement();

                    //Quest content
                    xml.WriteStartElement("Content");
                    xml.WriteValue(q.Content);
                    xml.WriteEndElement();

                    //Quest options
                    xml.WriteStartElement("LstOption");
                    xml.WriteAttributeString("count", q.LstOption.Count.ToString());
                    foreach(var o in q.LstOption)
                    {
                        xml.WriteStartElement("Option");
                        if(o.isTrue)
                            xml.WriteAttributeString("isTrue", "true");
                        else
                            xml.WriteAttributeString("isTrue", "false");

                        xml.WriteStartElement("Content");
                        xml.WriteValue(o.Content);
                        xml.WriteEndElement();

                        xml.WriteEndElement();
                    }    
                    xml.WriteEndElement();

                    xml.WriteEndElement();
                }
                xml.WriteEndElement();
            }    
        }

        private void frmQuestionManagement_Load(object sender, EventArgs e)
        {
            UnableTools();
            cbxChuDe.SelectedItem = "All";
        }

        private void btnThemCauHoi_Click(object sender, EventArgs e)
        {
            if (cbxChuDe.SelectedIndex <= 0)
                MessageBox.Show("Chua chon chu de", "Notification");
            else
            {
                isAdding = true;
                btnSuaCauHoi.Enabled = false;
                btnXoaCauHoi.Enabled = false;

                cbxChuDe.Enabled = false;
                btnLoad.Enabled = false;
                btnSave.Enabled = false;
                lvwDsCauHoi.Enabled = false;
                EnableTools();
            }
        }

        private void btnSuaCauHoi_Click(object sender, EventArgs e)
        {
            if (cbxChuDe.SelectedIndex <= 0)
                MessageBox.Show("Chua chon chu de", "Notification");
            else
            {
                btnThemCauHoi.Enabled = false;
                btnXoaCauHoi.Enabled = false;

                cbxChuDe.Enabled = false;
                btnLoad.Enabled = false;
                btnSave.Enabled = false;
                lvwDsCauHoi.Enabled = false;
                EnableTools();
            }
        }

        private void btnXoaCauHoi_Click(object sender, EventArgs e)
        {
            if (cbxChuDe.SelectedIndex <= 0)
                MessageBox.Show("Chua chon chu de", "Notification");
            else if (lvwDsCauHoi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chua chon cau hoi de xoa", "Notification");
            }
            else
            {
                if (MessageBox.Show("Ban dang XOA cau hoi", "Notification", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    return;
                
                int index = lvwDsCauHoi.SelectedItems[0].Index;
                lstQuest.RemoveAt(index);
                lvwDsCauHoi.Items.Remove(lvwDsCauHoi.SelectedItems[0]);
                clearTextbox();
            }
        }

        private void btnThemCauTraLoi_Click(object sender, EventArgs e)
        {
            if (cbxTrueFalse.SelectedIndex == -1)
                cbxTrueFalse.SelectedItem = "False";
            Option tmpOption = new Option();
            tmpOption.Content = txtNoiDungCauTraLoi.Text;
            if (cbxTrueFalse.SelectedItem == "True")
                tmpOption.isTrue = true;

            lstOption.Add(tmpOption);
            lbxDsCauTraLoi.Items.Add(tmpOption.ToString());
        }

        private void btnSuaCauTraLoi_Click(object sender, EventArgs e)
        {
            int index = lbxDsCauTraLoi.SelectedIndex;
            if (index >= 0)
            {
                lstOption[index].Content = txtNoiDungCauTraLoi.Text;
                if (cbxTrueFalse.SelectedItem == "True")
                {
                    foreach (Option o in lstOption)
                        o.isTrue = false;
                    lstOption[index].isTrue = true;
                }

                for(int i = 0; i < lstOption.Count; i++)
                    lbxDsCauTraLoi.Items[i] = lstOption[i].ToString();
            }
            else
                MessageBox.Show("Chua chon phan tu can sua","Notification");
        }

        private void btnXoaCauTraLoi_Click(object sender, EventArgs e)
        {
            int index = lbxDsCauTraLoi.SelectedIndex;
            if (index >= 0)
            {
                lstOption.RemoveAt(index);
                lbxDsCauTraLoi.Items.RemoveAt(index);
            }
            else
                MessageBox.Show("Chua chon phan tu can xoa", "Notification");
        }

        private void lbxDsCauTraLoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbxDsCauTraLoi.SelectedIndex;
            if (index >= 0)
            {
                txtNoiDungCauTraLoi.Text = lstOption[index].Content;
                if (lstOption[index].isTrue)
                    cbxTrueFalse.SelectedItem = "True";
                else
                    cbxTrueFalse.SelectedItem = "False";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThemCauHoi.Enabled = true;
            btnSuaCauHoi.Enabled = true;
            btnXoaCauHoi.Enabled = true;
            UnableTools();
            clearTextbox();
            isAdding = false;
            cbxChuDe.Enabled = true;
            btnLoad.Enabled = true;
            btnSave.Enabled = true;
            lvwDsCauHoi.Enabled = true;
        }

        private void btnXong_Click(object sender, EventArgs e)
        {

            if (txtNoiDungCauHoi.Text == "")
                MessageBox.Show("Chua nhap noi dung cau hoi", "Notification");
            else if (!checkLstOption())
                MessageBox.Show("Chua chon dap an cho cau hoi hoac Chua du so luong cau tra loi", "Notification");
            else
            {
                if (isAdding)
                {
                    if (!checkQuestID(txtMaCauHoi.Text))
                    {
                        MessageBox.Show("Ma cau hoi da ton tai", "Notification");
                        return;
                    }
                    Question tmpQuest = new Question();
                    ListViewItem lvi = new ListViewItem();

                    tmpQuest.QuestID = txtMaCauHoi.Text;
                    tmpQuest.Content = txtNoiDungCauHoi.Text;
                    tmpQuest.Topic = cbxChuDe.Text;
                    for (int i = 0; i < lstOption.Count; i++)
                    {
                        Option tmpOption = lstOption[i];
                        tmpQuest.LstOption.Add(tmpOption);
                    }

                    lvi.Text = tmpQuest.QuestID;
                    lvi.SubItems.Add(tmpQuest.Content);
                    lvi.SubItems.Add(tmpQuest.Topic);

                    lstQuest.Add(tmpQuest);
                    lvwDsCauHoi.Items.Add(lvi);
                }
                else
                {
                    int index = lvwDsCauHoi.SelectedItems[0].Index;

                    lstQuest[index].QuestID = txtMaCauHoi.Text;
                    lstQuest[index].Content = txtNoiDungCauHoi.Text;
                    lstQuest[index].LstOption.Clear();
                    for (int i = 0; i < lstOption.Count; i++)
                    {
                        Option tmpOption = lstOption[i];
                        lstQuest[index].LstOption.Add(tmpOption);
                    }


                    lvwDsCauHoi.SelectedItems[0].SubItems.Clear();
                    lvwDsCauHoi.SelectedItems[0].Text = lstQuest[index].QuestID;
                    lvwDsCauHoi.SelectedItems[0].SubItems.Add(lstQuest[index].Content);
                    lvwDsCauHoi.SelectedItems[0].SubItems.Add(lstQuest[index].Topic);
                    lvwDsCauHoi.Enabled = true;
                }

                btnThemCauHoi.Enabled = true;
                btnSuaCauHoi.Enabled = true;
                btnXoaCauHoi.Enabled = true;
                UnableTools();
                isSave = false;
                cbxChuDe.Enabled = true;
                btnLoad.Enabled = true;
                btnSave.Enabled = true;
                lvwDsCauHoi.Enabled = true;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lvwDsCauHoi.Items.Clear();
            lstQuest.Clear();
            clearTextbox();

            if (cbxChuDe.SelectedItem == "All")
            {
                btnSave.Enabled = false;
                if (folders.Length == 0)
                    return;
                foreach (var folder in folders)
                {
                    FileInfo fi = new FileInfo(folder);
                    if (cbxChuDe.Items.Count - 1 < folders.Length)
                        cbxChuDe.Items.Add(fi.Name);
                    string[] filepath = Directory.GetFiles(fi.FullName);
                    LoadFile(filepath[0]);
                }
            }
            else
            {
                btnSave.Enabled = true;
                int index = cbxChuDe.SelectedIndex;
                currentTopic = folders[index - 1];
                string[] filepath = Directory.GetFiles(currentTopic);
                LoadFile(filepath[0]);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            isSave = true;
            string[] filepath = Directory.GetFiles(currentTopic);
            SaveFile(filepath[0]);
        }

        private void cbxChuDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvwDsCauHoi.Items.Clear();
            lstQuest.Clear();
            clearTextbox();

            if (cbxChuDe.SelectedItem == "All")
            {
                btnSave.Enabled = false;
                foreach (var folder in folders)
                {
                    FileInfo fi = new FileInfo(folder);
                    if (cbxChuDe.Items.Count - 1  < folders.Length)
                        cbxChuDe.Items.Add(fi.Name);
                    string[] filepath = Directory.GetFiles(fi.FullName);
                    LoadFile(filepath[0]);
                }
            }
            else
            {
                btnSave.Enabled = true;
                int index = cbxChuDe.SelectedIndex;
                currentTopic = folders[index - 1];
                string[] filepath = Directory.GetFiles(currentTopic);
                LoadFile(filepath[0]);
            }    

        }

        private void lvwDsCauHoi_ItemActivate(object sender, EventArgs e)
        {
            lstOption.Clear();
            lbxDsCauTraLoi.Items.Clear();

            int index = lvwDsCauHoi.SelectedItems[0].Index;
            txtNoiDungCauHoi.Text = lstQuest[index].Content;
            txtMaCauHoi.Text = lstQuest[index].QuestID;

            for (int i = 0; i < lstQuest[index].LstOption.Count; i++)
            {
                Option tmpOption = lstQuest[index].LstOption[i];
                lstOption.Add(tmpOption);
                lbxDsCauTraLoi.Items.Add(tmpOption.ToString());
            }
        }
    }
}
