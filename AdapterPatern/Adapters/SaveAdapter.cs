using AdapterPatern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatern.Adapters
{
    interface SaveAdapter
    {
        public void setElement(Student s);
        public Student getElement(String name);
    }
}
