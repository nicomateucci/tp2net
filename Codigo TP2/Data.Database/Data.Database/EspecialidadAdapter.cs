using System;
using System.Collections.Generic;
using System.Text;
using Bussiness.Entities;
using System.Data;
using System.Data.SqlClient; 

namespace Data.Database
{
    public class EspecialidadAdapter: Adapter
    {
        public List<Especialidad> GetAll()
        {
            return new List<Especialidad>();
        }
        public Especialidad GetOne(int Id)
        {
            return new Especialidad();
        }
        public void Delete(int Id)
        {

        }
        public void Save(Especialidad unaEspecialidad)
        {
            
        }
    }
}