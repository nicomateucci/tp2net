using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness.Entities;
using Data.Database;
using System.Data;
using System.Data.SqlClient;


namespace Bussiness.Logic
{
    public class EspecialidadLogic : BussinessLogic
    {
        public EspecialidadAdapter EspecialidadData {set; get;}

        public EspecialidadLogic()
        {
            EspecialidadData = new EspecialidadAdapter();
        }
        public List<Especialidad> GetAll()
        {
            return EspecialidadData.GetAll();
        }
        public Especialidad GetOne(int Id)
        {
            return EspecialidadData.GetOne(Id);
        }
        public void  Delete(int Id)
        {
            EspecialidadData.Delete(Id);
        }
        public void Save(Especialidad unaEspecialidad)
        {
            EspecialidadData.Save(unaEspecialidad);
        }

    }
    
}