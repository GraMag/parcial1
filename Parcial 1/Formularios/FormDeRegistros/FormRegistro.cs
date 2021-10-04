using Biblioteca;
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
    public partial class FormRegistro : Form
    {
        Petshop petshop;
        public FormRegistro()
        {
            InitializeComponent();
        }

        public FormRegistro(Petshop petshop)
            : this()
        {
            this.petshop = petshop;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Confirmar datos", "Nuevo Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                Cliente cliente = new Cliente(txtBoxNombre.Text, txtBoxApellido.Text, txtBoxMail.Text, txtBoxDNI.Text, dateTimePicker1.Value);
                FormVentas formVentas = new FormVentas(petshop, cliente);

                formVentas.Show();
                this.Close();
            }           
        }
    }
}
