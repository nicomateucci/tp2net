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
    public class PlanLogic : BussinessLogic
    {
        public PlanAdapter PlanData {set; get;}

        public PlanLogic()
        {
            PlanData = new PlanAdapter();
        }
        public List<Plan> GetAll()
        {
            return PlanData.GetAll();
        }
        public Plan GetOne(int Id)
        {
            return PlanData.GetOne(Id);
        }
        public void  Delete(int Id)
        {
            PlanData.Delete(Id);
        }
        public void Save(Plan unPlan)
        {
            PlanData.Save(unPlan);
        }

    }
    
}