using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public class capaNegocio
    {
        private capaAcceso _capaAcceso;

        public capaNegocio()
        {
            _capaAcceso = new capaAcceso();        }
        public Contact GuardoContact(Contact contacto)
        {
            if (contacto.id==0)
            {
                //_capaAcceso inserto contacto con una funcion que ejecute sql
                _capaAcceso.InsertContact(contacto);
            }
            else
            {
                // Si el contacto ya existe _capaAcceso le hacemos un update a ejecutar en sql
                _capaAcceso.UpdateContact(contacto);
            }

            return contacto;
        }

        public List<Contact> ObtenerContactos(string buscarTexto = null)
        {
           return _capaAcceso.ObtenerContacto(buscarTexto);
        }

        public void BorrarContacts(int id)
        {
            _capaAcceso.DeleteContact(id);
        }
    }
}
