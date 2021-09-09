using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class frmDetalleContactos : Form
    {
        private capaNegocio _capaNegocio;
        private Contact _contacto;


        public frmDetalleContactos()
        {
            InitializeComponent();
            _capaNegocio = new capaNegocio();
        }

        
        #region EVENTOS
        private void frmDetalleContactos_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardoContact();
            this.Close();
            ((frmContactos)this.Owner).ContactosLista();

        }
        #endregion

        #region METODOS PRIVADOS
        private void LimpiarForm()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtDirec.Text = string.Empty;
        }
        private void GuardoContact()
        {
            Contact contacto = new Contact();
            contacto.Nombre = txtNombre.Text;
            contacto.Apellido = txtApellido.Text;
            contacto.Telefono = txtTel.Text;
            contacto.Direccion = txtDirec.Text;

            contacto.id = _contacto != null ? _contacto.id : 0;

            _capaNegocio.GuardoContact(contacto);
            MessageBox.Show("Usuario registrado exitosamente", "GUARDADO", MessageBoxButtons.OK);

        }
        #endregion

        #region METODOS PUBLICOS
        public void LoadContact(Contact contacto)
        {
            _contacto = contacto;
            if (contacto != null)
            {
                LimpiarForm();

                txtNombre.Text = contacto.Nombre;
                txtApellido.Text = contacto.Apellido;
                txtTel.Text = contacto.Telefono;
                txtDirec.Text = contacto.Direccion;
            }
        }
        #endregion
    }
}
