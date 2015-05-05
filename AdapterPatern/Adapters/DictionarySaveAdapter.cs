using AdapterPatern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatern.Adapters
{
    class DictionarySaveAdapter : SaveAdapter
    {

        private Dictionary<String, Student> StudentDictionary;

        public void setElement(Student s)
        {
            StudentDictionary.Add(s.name, s);
        }

        public Student getElement(String name)
        {
            if (StudentDictionary.ContainsKey(name))
            {
                return StudentDictionary[name];
            }
            else { return null; }
        }
    }
}
