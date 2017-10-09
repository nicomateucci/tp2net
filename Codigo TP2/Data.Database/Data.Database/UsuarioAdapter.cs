using System;
using System.Collections.Generic;
using System.Text;
using Bussiness.Entities;
using System.Data;
using System.Data.SqlClient; 

namespace Data.Database
{
    public class UsuarioAdapter: Adapter
    {
        

        public static List<Usuario> Usuarios;

        public List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            this.OpenConnection();
            SqlCommand cmdUusarios = new SqlCommand("select * from usuarios", sqlConn);
            SqlDataReader drUsuarios = cmdUusarios.ExecuteReader();
            while (drUsuarios.Read())
            {
                Usuario usr = new Usuario();
                usr.ID = (int)drUsuarios["id_usuario"];
                usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                usr.Clave= (string)drUsuarios["clave"];
                usr.Habilitado = (bool)drUsuarios["habilitado"];
                usr.Nombre = (string)drUsuarios["nombre"];
                usr.Apellido = (string)drUsuarios["apellido"];
                usr.Email = (string)drUsuarios["email"];

                usuarios.Add(usr);
            }
            drUsuarios.Close();
            this.CloseConnection();

            return usuarios;
        }

        public Bussiness.Entities.Usuario GetOne(int id)
        {
            this.OpenConnection();
            SqlCommand coman = new SqlCommand("select * from usuarios where id_usuario='" + id + "'", sqlConn);
            SqlDataReader dtRead = coman.ExecuteReader();
            if (dtRead.HasRows)
            {
                DataTable dtTab = new DataTable();
                dtTab.Load(dtRead);
                Usuario elUsuario = MapeoRelacionObjeto(dtTab);
                return elUsuario;
            }
            else return null;
        }
        public Bussiness.Entities.Usuario MapeoRelacionObjeto(DataTable dtTab)
        {
            Usuario elUser = new Usuario();
            elUser.ID = int.Parse(dtTab.Rows[0][0].ToString());
            elUser.Nombre = dtTab.Rows[0]["nombre"].ToString();
            elUser.Apellido = dtTab.Rows[0]["apellido"].ToString();
            elUser.Email = dtTab.Rows[0]["email"].ToString();
            elUser.NombreUsuario = dtTab.Rows[0]["nombre_usuario"].ToString();
            elUser.Habilitado = bool.Parse(dtTab.Rows[0]["habilitado"].ToString());
            return elUser;
        }
        public int Login(String user , String pass)
        {
            this.OpenConnection();
            SqlCommand command = new SqlCommand("select * from usuarios where nombre_usuario ='" + user +  "' and clave =@pass", sqlConn);
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            command.ExecuteNonQuery();
            SqlDataReader dtReader = command.ExecuteReader();
            if (dtReader.HasRows)
            {
                DataTable dtTable = new DataTable();
                dtTable.Load(dtReader);
                return int.Parse(dtTable.Rows[0][0].ToString());
            }
            else{ return 0;}  
            
        }

        public void Delete(int ID)
        {
            Usuarios.Remove(this.GetOne(ID));
        }

        public void Save(Usuario usuario)
        {
            if (usuario.State == BussinessEntity.States.New)
            {
                int NextID = 0;
                foreach (Usuario usr in Usuarios)
                {
                    if (usr.ID > NextID)
                    {
                        NextID = usr.ID;
                    }
                }
                usuario.ID = NextID + 1;
                Usuarios.Add(usuario);
            }
            else if (usuario.State == BussinessEntity.States.Deleted)
            {
               
                 this.Delete(usuario.ID);
            }
            else if (usuario.State == BussinessEntity.States.Modified)
            {
                Usuarios[Usuarios.FindIndex(delegate (Usuario u) { return u.ID == usuario.ID; })] = usuario;
            }
            usuario.State = BussinessEntity.States.Unmodified;            
        }
    }
}
