using System;
using System.Collections.Generic;
using System.Text;
using Bussiness.Entities;
using System.Data;
using System.Data.SqlClient; 

namespace Data.Database
{
    public class ComisionAdapter: Adapter
    {
        public List<Comision> GetAll()
        {
            return new List<Comision>();
        }
        public Comision GetOne(int Id)
        {
            return new Comision;
        }
        public void Delete(int Id)
        {

        }
        public void Save(Comision unaComision)
        {
            
        }
    }
}