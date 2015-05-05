using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdapterPatern.Adapters;

namespace AdapterPatern.Forms
{
    public partial class SearchForm : Form
    {
        private SaveAdapter saveAdapter;

        public SearchForm(SaveAdapter s)
        {
            InitializeComponent();
            saveAdapter = s;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            if(tName.Text != null){
                string name = tName.Text;
                if (saveAdapter.getElement(name) != null)
                {
                    label1.Text = saveAdapter.getElement(name).ToString();
                }
                else
                {
                    label1.Text = "No student found with that name.";
                }
                    
            }else{
                label1.Text = "Please write a name.";
            }

        }


    }
}
