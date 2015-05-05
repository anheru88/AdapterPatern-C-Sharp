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
        private static SaveAdapter saveAdapter;
        private StudentForm studentMDIChild;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(SaveAdapter Adapter)
        {
            InitializeComponent();
            saveAdapter = Adapter;
        }

        private void nuevoEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (studentMDIChild == null)
            {
                studentMDIChild = new StudentForm(saveAdapter);
                studentMDIChild.MdiParent = this;
            }
            
            studentMDIChild.Text = "New Student";
            studentMDIChild.Show();
        }

        private void buscarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchMDIChild = new SearchForm(saveAdapter);
            searchMDIChild.Text = "Search Student By Name";
            searchMDIChild.MdiParent = this;
            searchMDIChild.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
