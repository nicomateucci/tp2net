using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Entities
{
    public class Curso: BussinessEntity
    {
        int _anoCalendario;
        int _cupo;

        public int anoCalendario {set {value = _anoCalendario;} get {return _anoCalendario;}}
        public int cupo {set {value = _cupo;} get { return _cupo;}}
}
}