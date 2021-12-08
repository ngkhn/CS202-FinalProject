using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherModule
{
    class Student
    {
        public String StuID { get; set; }
        public String Name { get; set; }
        public float Grade { get; set; }

        public string ToFile()
        {
            return $"{StuID}|{Name}|{Grade}";
        }
    }
}
