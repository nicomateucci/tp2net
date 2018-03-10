using System;
using System.Collections.Generic;
using System.Text;
using Bussiness.Entities;
using System.Data;
using System.Data.SqlClient; 

namespace Data.Database
{
    public class PlanAdapter: Adapter
    {
        public List<Plan> GetAll()
        {
            return new List<Plan>();
        }
        public Plan GetOne(int Id)
        {
            return new Plan;
        }
        public void Delete(int Id)
        {

        }
        public void Save(Plan unPlan)
        {
            
        }
    }
}