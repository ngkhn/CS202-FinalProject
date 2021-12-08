using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherModule
{
    class Question
    {
        public String  QuestID { get; set; }
        public String Topic { get; set; }
        public String Content { get; set; }
        public List<Option> LstOption { get; set; }

        public Question()
        {
            LstOption = new List<Option>();
        }

        public void Random()
        {
            Random random = new Random();
            List<int> lstIndex = new List<int>();
            for (int i = 0; i < LstOption.Count; i++)
            {
                int index;
                do
                {
                    index = random.Next(0, LstOption.Count);
                } while (lstIndex.IndexOf(index) != -1);
                lstIndex.Add(index);
            }

            List<Option> tempOptions = new List<Option>();
            foreach (Option option in LstOption)
            {
                tempOptions.Add(option);
            }

            for (int i = 0; i < LstOption.Count; i++)
            {
                LstOption[i] = tempOptions[lstIndex[i]];
            }
        }
    }
}
