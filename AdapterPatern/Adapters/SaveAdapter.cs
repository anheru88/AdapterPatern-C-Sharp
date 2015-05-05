using AdapterPatern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatern.Adapters
{
    public interface SaveAdapter
    {
       void setElement(Student s);
       Student getElement(String name);
    }
}
