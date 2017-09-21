using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Entities
{
    class ModuloUsuario
    {
        public int IdUsuario
        {
            set;get;
        }
        public int IdModulo
        {
            set;get;
        }
        public bool PermiteAlta
        {
            set;get;
        }public bool PermiteBaja
        {
            set;get;
        }public bool PermiteModificacion
        {
            set;get;
        }public bool PermiteConsulta
        {
            set;get;
        }
}
}
