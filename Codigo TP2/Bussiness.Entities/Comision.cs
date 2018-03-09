using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Entities
{
    public class Comision: BussinessEntity
    {
        string _descComision;
        int _anoEspecialidad;

        public string descComision { set {value = _descComision;} get {return _descComision;}}
        public int anoEspecialidad { set {value = _anoEspecialidad;} get { return _anoEspecialidad;}} 
}
}