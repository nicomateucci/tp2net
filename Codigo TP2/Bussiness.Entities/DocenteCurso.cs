using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Entities
{
    public class DocenteCurso: BussinessEntity
    {
        int _idCurso;
        int _idDocente;
        string _cargo;

        public string cargo { set {value = _cargo;} get {return _cargo;}}
        public int idCurso {set { value = _idCurso;} get { return _idCurso;}}
        public int idDocente { set { value = _idDocente;} get { return _idDocente;}}
}
}