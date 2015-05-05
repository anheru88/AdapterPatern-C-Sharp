using AdapterPatern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatern.Adapters
{
    class ListSaveAdapter : SaveAdapter
    {
        private List<Student> StudentList;

        public ListSaveAdapter(){
            StudentList = new List<Student>();
        }

        public void setElement(Student s)
        {
            StudentList.Add(s);
        }

        public Student getElement(String name)
        {
            foreach (Student t in StudentList)
            {
                if (t.name.Equals(name))
                {
                    return t;
                }
            }

            return null;

        }
    }
}
