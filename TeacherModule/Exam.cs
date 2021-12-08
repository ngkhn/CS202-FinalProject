using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TeacherModule
{
    class Exam
    {
        public String ExamID { get; set; }

        public List<Question> LstQuestion { get; set; }

        public Exam()
        {
            LstQuestion = new List<Question>();
        }

        public Exam(Exam e)
        {
            ExamID = e.ExamID;
            LstQuestion = new List<Question>(e.LstQuestion.Count);
            LstQuestion.AddRange(new List<Question>(e.LstQuestion));
        }    

        public void Random()
        {
            Random random = new Random();
            List<int> lstIndex = new List<int>();
            for (int i = 0; i < LstQuestion.Count; i++)
            {
                int index;
                do
                {
                    index = random.Next(0, LstQuestion.Count);
                } while (lstIndex.IndexOf(index) != -1);
                lstIndex.Add(index);
            }

            List<Question> tempQuestions = new List<Question>();
            foreach (Question question in LstQuestion)
            {
                tempQuestions.Add(question);
            }

            for (int i = 0; i < LstQuestion.Count; i++)
            {
                LstQuestion[i] = tempQuestions[lstIndex[i]];
                LstQuestion[i].Random();
            }
        }

        public void SaveExamFile()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Luu de thi (khong dap an) .xml|*.xml";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (var xml = XmlWriter.Create(dlg.FileName, new XmlWriterSettings() { Indent = true }))
                {
                    xml.WriteStartElement("Exam");

                    xml.WriteAttributeString("ExamID", this.ExamID);

                    xml.WriteStartElement("Time");
                    xml.WriteValue((LstQuestion.Count*15));
                    xml.WriteEndElement();

                    foreach (var q in LstQuestion)
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
                        foreach (var o in q.LstOption)
                        {
                            xml.WriteStartElement("Option");
                            xml.WriteValue(o.Content);
                            xml.WriteEndElement();
                        }
                        xml.WriteEndElement();

                        xml.WriteEndElement();
                    }
                    xml.WriteEndElement();
                }    
            }
        }

        public void SaveKeyFile()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Luu dap an de .xml|*.xml";


            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (var xml = XmlWriter.Create(dlg.FileName, new XmlWriterSettings() { Indent = true }))
                {
                    xml.WriteStartElement("Exam");
                    xml.WriteAttributeString("ExamID", this.ExamID);

                    xml.WriteStartElement("LstKey");
                    foreach (var q in LstQuestion)
                    {
                        for(int i = 0; i < q.LstOption.Count; i++)
                            if (q.LstOption[i].isTrue)
                            {
                                xml.WriteStartElement("Key");
                                xml.WriteValue(i.ToString());
                                xml.WriteEndElement();
                            }
                    }
                    xml.WriteEndElement();
                }
            }
        }
    }
}
