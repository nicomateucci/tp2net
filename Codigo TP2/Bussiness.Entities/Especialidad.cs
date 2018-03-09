using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Entities
{
    public class Especialidad: BussinessEntity
    {
        string _descEspecialidad;

        public string descEspecialidad {set {value = _descEspecialidad;} get {return _descEspecialidad;}}
    }
}
