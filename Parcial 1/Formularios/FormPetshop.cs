using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormPetshop : Form
    {
        public FormPetshop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin newMDIChild = new FormLogin();
            newMDIChild.MdiParent = this;
            button1.Hide();
            newMDIChild.Show();
        }
    }
}
