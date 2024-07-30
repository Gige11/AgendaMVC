using System;

using System.Windows.Forms;
using CapaNegocios;

namespace Vista
{

    public partial class ContactosBuscar : Form
    {
        N_Contactos nContactos = new N_Contactos();

        public ContactosBuscar()
        {
            InitializeComponent();
        }

        private void ContactosBuscar_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            dgvContactos.DataSource = nContactos.GetAll();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            ContactosEditar frm = new ContactosEditar();
            frm.Operacion = "A";
            frm.ShowDialog();
            Actualizar();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            ContactosEditar frm = new ContactosEditar();
            frm.Operacion = "E";
            frm.ContactoId = Convert.ToInt32(dgvContactos.CurrentRow.Cells["Id"].Value);
            frm.ShowDialog();
            Actualizar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            N_Contactos nContactos = new N_Contactos();

            int id = Convert.ToInt32(dgvContactos.CurrentRow.Cells["Id"].Value);
            
            nContactos.Delete(id);
            MessageBox.Show("Se ha borrado el contacto correctamente");
            Actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
