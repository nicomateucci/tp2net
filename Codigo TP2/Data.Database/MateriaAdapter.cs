using System;
using System.Collections.Generic;
using System.Text;
using Bussiness.Entities;
using System.Data;
using System.Data.SqlClient; 

namespace Data.Database
{
    public class MateriaAdapter: Adapter
    {
        public List<Materia> GetAll()
        {
            return new List<Materia>();
        }
        public Materia GetOne(int Id)
        {
            return new Materia;
        }
        public void Delete(int Id)
        {

        }
        public void Save(Materia unaMateria)
        {
            
        }
    }
}