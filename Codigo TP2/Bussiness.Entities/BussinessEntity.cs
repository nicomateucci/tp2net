using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Entities
{
    public class BussinessEntity
    {
        public int ID
        {
            set;get;
        }
        public States State
        {
            set;get;
        } 

        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }
    }
}
