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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm studentMDIChild = new StudentForm();
            studentMDIChild.Text = "New Student";
            studentMDIChild.MdiParent = this;
            studentMDIChild.Show();
        }
    }
}
