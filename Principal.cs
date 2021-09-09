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
    public partial class frmContactos : Form
    {
        private capaNegocio _capaNegocio;
        public frmContactos()
        {
            InitializeComponent();
            _capaNegocio = new capaNegocio();
        }


        #region EVENTOS
        private void frmContactos_Load(object sender, EventArgs e)
        {

            this.CenterToScreen();
            ContactosLista();
            dtgV.ReadOnly = true;
            

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirDetalleContactos();
        }


        private void dtgV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = (DataGridViewLinkCell)dtgV.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Editar")
            {
                frmDetalleContactos detalle_contacto = new frmDetalleContactos();
                detalle_contacto.LoadContact(new Contact
                {
                    id = int.Parse(dtgV.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    Nombre = dtgV.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Apellido = dtgV.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Telefono = dtgV.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Direccion = dtgV.Rows[e.RowIndex].Cells[4].Value.ToString(),
                });
                detalle_contacto.ShowDialog(this);
            }
            else if (true)
            {
                borro(int.Parse(dtgV.Rows[e.RowIndex].Cells[0].Value.ToString()));
                ContactosLista();
                
            }
        }
        #endregion


        #region METODOS PRIVADOS
        private void AbrirDetalleContactos()
        {
            frmDetalleContactos detalleContactos = new frmDetalleContactos();
            detalleContactos.ShowDialog(this);
        }


        private void borro(int id)
        {
            _capaNegocio.BorrarContacts(id);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ContactosLista(txtBuscar.Text);
            txtBuscar.Text = string.Empty;
        }
        #endregion

        #region METODOS PUBLICOS
        public void ContactosLista(string buscarTexto = null)
        {

            List<Contact> contactos = _capaNegocio.ObtenerContactos(buscarTexto);
            dtgV.DataSource = contactos;

        }
        #endregion
    }

}
