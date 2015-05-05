using AdapterPatern.Adapters;
using AdapterPatern.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterPatern
{
    public partial class MainForm : Form
    {
        private SaveAdapter saveAdapter;
        private StudentForm studentMDIChild;
        private SearchForm searchMDIChild;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(SaveAdapter saveAdapter)
        {
            InitializeComponent();
            this.saveAdapter = saveAdapter;
        }

        private void nuevoEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (studentMDIChild == null)
            {
                studentMDIChild = new StudentForm(saveAdapter);
                studentMDIChild.MdiParent = this;
            }
            else if(studentMDIChild.IsDisposed)
            {
                studentMDIChild = new StudentForm(saveAdapter);
                studentMDIChild.MdiParent = this;
            }
            
            studentMDIChild.Text = "New Student";
            studentMDIChild.Show();
            
        }

        private void buscarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (searchMDIChild == null)
            {
                searchMDIChild = new SearchForm();
                searchMDIChild.MdiParent = this;
            }
            else if (searchMDIChild.IsDisposed)
            {
                searchMDIChild = new SearchForm();
                searchMDIChild.MdiParent = this;
            }

            searchMDIChild.Text = "Search Student By Name";
            searchMDIChild.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
