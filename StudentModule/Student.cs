using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentModule
{
    internal static class Student
    {
        public static String StuID { get; set; }
        public static String Name { get; set; }
        public static String ExamID { get; set; }
        public static List<String> lstAnswer = new List<String>();
    }
}
