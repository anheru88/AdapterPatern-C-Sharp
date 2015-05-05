using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatern.Models
{
    public class Student
    {
        public String name { get; set; }
        public String code { get; set; }
        public int age { get; set; }
        public String gender { get; set; }
        public String address { get; set; }

        public override string ToString()
        {
            return "\nName: "+name+
                "\nCode: "+code+
                "\nAge: "+age+
                "\nGender: "+gender+
                "\nAddress: "+address;
        }
    }
}
