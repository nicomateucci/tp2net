using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness.Entities;
using Data.Database;
//Comentario agregado para ver como aparece en GitHub
using System.Data;
using System.Data.SqlClient;


namespace Bussiness.Logic
{
    public class UsuarioLogic : BussinessLogic
    {
        public Data.Database.UsuarioAdapter UsuarioData
        {
            set; get;
        }
        public UsuarioLogic()
        {
            UsuarioData = new Data.Database.UsuarioAdapter();
        }

        public Bussiness.Entities.Usuario GetOne(int id)
        {
            return UsuarioData.GetOne(id);
        }
        public int Login(string usuario, string pass)
        {
            return UsuarioData.Login(usuario, pass);
        }
        public List<Usuario> GetAll()
        {
            return UsuarioData.GetAll();
        } 
        public void Delete(int Id)
        {
            UsuarioData.Delete(Id);
        }
        public void Save(Bussiness.Entities.Usuario usuario)
        {
            UsuarioData.Save(usuario);
        }
    }
    
}
