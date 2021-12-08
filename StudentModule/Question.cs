using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentModule
{
    class Question
    {
        public String Content { get; set; }
        public List<String> LstOption { get; set; }
        public Question()
        {
            LstOption = new List<String>();
        }
    }
}
