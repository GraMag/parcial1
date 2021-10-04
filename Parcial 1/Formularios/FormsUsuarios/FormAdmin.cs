using Biblioteca;
using Formularios.FormDeRegistros;
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
    public partial class FormAdmin : FormEmpleado
    {

        public FormAdmin(Petshop petshop, Usuario user)
            : base(petshop, user)
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            DataGridViewProp.DataSource = Petshop.Empleados;
            DataGridViewProp.Columns["Password"].Visible = false;
            DataGridViewProp.Enabled = true;
            SetearColumnas();
        }

        private void SetearColumnas()
        {
            DataGridViewProp.Columns["ID"].DisplayIndex = 0;
            DataGridViewProp.Columns["NOMBRE"].DisplayIndex = 1;
            DataGridViewProp.Columns["APELLIDO"].DisplayIndex = 2;
            DataGridViewProp.Columns["EMAIL"].DisplayIndex = 3;
            DataGridViewProp.Columns["CARGO"].DisplayIndex = 4;
            DataGridViewProp.Columns["Password"].Visible = false;
        }
    }
}
