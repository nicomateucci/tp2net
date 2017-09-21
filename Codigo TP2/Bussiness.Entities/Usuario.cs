using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Entities
{
    public class Usuario: BussinessEntity
    {
        public string NombreUsuario
        {
            set;get;
        }
        public string Clave
        {
            set;get;
        }
        public string Nombre
        {
            set;get;
        }
        public string Apellido
        {
            set;get;
        }
        public string Email
        {
            set;get;
        }
        public bool Habilitado
        {
            set;get;
        }
}
}
