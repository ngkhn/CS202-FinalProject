using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherModule
{
    class Option
    {
        public String Content { get; set; }
        public Boolean isTrue { get; set; } = false;

        public Option()
        {
            Content = "";
        }

        public override string ToString()
        {
            return $"{isTrue} - {Content}";
        }

        public static Option Parse(string str)
        {
            Option newOption = new Option();

            string[] elems = str.Split(" - ");
            if (elems[0] == "true")
                newOption.isTrue = true;
            newOption.Content = elems[1];

            return newOption;
        }
    }
}