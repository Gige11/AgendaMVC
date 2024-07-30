using System;
using System.Windows.Forms;
using CapaNegocios;
using CapaEntidades;

namespace Vista
{
    public partial class ContactosEditar : Form
    {
        public string Operacion { get; set; }
        public int ContactoId { get; set; }
        E_Contactos oContacto = new E_Contactos();
        N_Contactos nContactos = new N_Contactos();

        public ContactosEditar()
        {
            InitializeComponent();
        }

        private void ContactosEditar_Load(object sender, EventArgs e)
        {
            if (Operacion == "E")
            {
                oContacto = nContactos.GetById(ContactoId);
                if (oContacto != null)
                {
                    txtId.Text = oContacto.Id.ToString();
                    txtNombre.Text = oContacto.Nombre;
                    txtDireccion.Text = oContacto.Direccion;
                    txtCelular.Text = oContacto.Celular;
                    txtEmail.Text = oContacto.Email;
                    txtNotas.Text = oContacto.Notas;
                }
            }
        }


        private void btnGrabar_Click_1(object sender, EventArgs e)
        {
            try
            {
                oContacto.Nombre = txtNombre.Text;
                oContacto.Direccion = txtDireccion.Text;
                oContacto.Celular = txtCelular.Text;
                oContacto.Email = txtEmail.Text;
                oContacto.Notas = txtNotas.Text;

                if (Operacion == "A")
                {
                    nContactos.Insert(oContacto);
                    Close();
                }
                else if (Operacion == "E")
                {
                    nContactos.Update(oContacto);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
