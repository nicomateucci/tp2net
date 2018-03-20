using System;
using System.Collections.Generic;
using System.Text;
using Bussiness.Entities;
using System.Data;
using System.Data.SqlClient; 

namespace Data.Database
{
    public class CursoAdapter: Adapter
    {
        public List<Curso> GetAll()
        {
            return new List<Curso>();
        }
        public Curso GetOne(int Id)
        {
            return new Curso();
        }
        public void Delete(int Id)
        {

        }
        public void Save(Curso unCurso)
        {
            
        }
    }
}