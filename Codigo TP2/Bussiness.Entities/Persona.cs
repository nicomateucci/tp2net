using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Entities
{
    public class Persona: BussinessEntity
    {
        string _nombre;
        string _apellido;
        string _direccion;
        string _mail;
        string _telefono;
        string _fechaNac;
        string _legajo;
        bool _tipoPersona;

        public string nombre{set {value = _nombre;} get { return  _nombre;}}
        public string apellido {set {value = _apellido;} get { return  _apellido;}}
        public string direccion {set {value = _direccion;} get { return  _direccion;}}
        public string mail {set {value = _mail;} get { return  _mail;}}
        public string telefono {set {value = _telefono;} get { return  _telefono;}}
        public string fecheNac {set {value = _fechaNac;} get { return  _fechaNac;}}
        public string lagajo {set {value = _legajo;} get { return _legajo  ;}}
        public bool tipoPersona {set {value =_tipoPersona;} get {return _tipoPersona;}}
}
}