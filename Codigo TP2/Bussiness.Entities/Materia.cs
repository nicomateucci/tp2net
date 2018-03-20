using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Entities
{
    public class Materia: BussinessEntity
    {
        string _descMateria;
        int _hsSem;
        int _hsTotales;

        public string descMateria { set {value = _descMateria;} get { return _descMateria;}}
        public int hsSem { set {value = _hsSem;} get {return _hsSem;}}
        public int hsTotales { set {value = _hsTotales;} get { return _hsTotales;}}
    }
}