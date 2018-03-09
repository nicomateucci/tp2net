using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Entities
{
    public class Plan: BussinessEntity
    {
    string _descPlan;

    public string descPlan { set {value = _descPlan;} get { return _descPlan;}}
    }
}