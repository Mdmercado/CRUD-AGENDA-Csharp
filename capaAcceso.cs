using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class capaAcceso
    {
        private SqlConnection conex = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MiCrud;Data Source=DESKTOP-B7KIEPK\\SQLEXPRESS");
        

        public void InsertContact(Contact contacto)
        {
            try
            {
                conex.Open();
                string consulta = @"
                insert into Contactos (FirstName,LastName,Phone,Address) 
                values (@FirstName,@LastName,@Phone,@Address) ";
                //Establezco los parametros nombrados con @
                SqlParameter paraNombre = new SqlParameter();
                paraNombre.ParameterName = "@FirstName";
                paraNombre.Value = contacto.Nombre;
                paraNombre.DbType = System.Data.DbType.String;

                SqlParameter paraApellido = new SqlParameter("@LastName",contacto.Apellido);
                SqlParameter paraTelefono = new SqlParameter("@Phone", contacto.Telefono);
                SqlParameter paraDirecc = new SqlParameter("@Address", contacto.Direccion);

                SqlCommand comando = new SqlCommand(consulta,conex);
                comando.Parameters.Add(paraNombre);
                comando.Parameters.Add(paraApellido);
                comando.Parameters.Add(paraTelefono);
                comando.Parameters.Add(paraDirecc);

                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conex.Close();
                 
            }
        }



        public void UpdateContact(Contact contacto)
        {
            try
            {
                conex.Open();
                string consulta = @"update contactos 
                                  set Firstname = @Firstname,
                                   LastName = @LastName,
                                   Phone = @Phone,
                                   Address = @Address

                                   where Id =@Id ";
                //Establezco los parametros nombrados con @
                SqlParameter paraNombre = new SqlParameter();
                paraNombre.ParameterName = "@FirstName";
                paraNombre.Value = contacto.Nombre;
                paraNombre.DbType = System.Data.DbType.String;
                SqlParameter paraApellido = new SqlParameter("@LastName", contacto.Apellido);
                SqlParameter paraTelefono = new SqlParameter("@Phone", contacto.Telefono);
                SqlParameter paraDirecc = new SqlParameter("@Address", contacto.Direccion);
                SqlParameter paraId = new SqlParameter("@Id", contacto.id);
                SqlCommand comando = new SqlCommand(consulta, conex);
                //Agrego Parametros
                comando.Parameters.Add(paraId);
                comando.Parameters.Add(paraNombre);
                comando.Parameters.Add(paraApellido);
                comando.Parameters.Add(paraTelefono);
                comando.Parameters.Add(paraDirecc);

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conex.Close();
            }
        }


        public void DeleteContact(int id) //Cargo solo ID no necesito objeto
        {
            try
            {
                conex.Open();
                string consulta = @"delete from Contactos where Id = @Id";
                SqlCommand comando = new SqlCommand(consulta, conex);
                comando.Parameters.Add(new SqlParameter("@Id", id));
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conex.Close();
            }
        }

        public List<Contact> ObtenerContacto(string buscar = null)
        {
            List<Contact> contactos = new List<Contact>();

            try
            {
                conex.Open();
                string consulta = @"select Id, FirstName, LastName, Phone, Address
                                    from Contactos";

                SqlCommand comando = new SqlCommand();

                if (!string.IsNullOrEmpty(buscar))
                {
                    consulta += @" where firstName LIKE @buscar OR LastName LIKE @buscar OR Phone LIKE @buscar OR Address LIKE @buscar ";
                    comando.Parameters.Add(new SqlParameter("@buscar", $"%{buscar}%"));
                }

                comando.CommandText = consulta;
                comando.Connection = conex;
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    contactos.Add(new Contact
                    {
                        id = int.Parse(lector["Id"].ToString()),
                        Nombre = lector["FirstName"].ToString(),
                        Apellido = lector["LastName"].ToString(),
                        Telefono = lector["Phone"].ToString(),
                        Direccion = lector["Address"].ToString()
                    });
                   
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conex.Close();
            }
            return contactos;
        }

        

    }
}
