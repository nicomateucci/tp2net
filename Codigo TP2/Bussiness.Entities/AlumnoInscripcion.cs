using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Entities
{
    public class AlumnoInscripcion: BussinessEntity
    {
        int _idCurso;
        int _idDocente;
        int _nota;
        string _condicion;

        public int nota { set {value = _nota;} get {return _nota;}}
        public int idCurso {set { value = _idCurso;} get { return _idCurso;}}
        public int idDocente { set { value = _idDocente;} get { return _idDocente;}}
        public string condicion { set { value = _condicion;} get { return _condicion;}}
    }
}