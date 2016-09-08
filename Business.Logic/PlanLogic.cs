using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Business.Logic
{
    public class PlanLogic : BusinessLogic
    {
        Data.Database.PlanAdapter _PlanData = new Data.Database.PlanAdapter();

        public PlanLogic()
        {
            this.PlanData = null;
        }

        public Data.Database.PlanAdapter PlanData
        {
            get { return _PlanData; }
            set { _PlanData = value; }
        }

        public List<Plan> GetAll()
        {
            return PlanData.GetAll();
        }

        public Plan GetOne(int Id)
        {
            return PlanData.GetOne(Id);
        }

        public void Delete(int Id)
        {
            PlanData.Delete(Id);
        }

        public void Save(Business.Entities.Plan Plan)
        {
            PlanData.Save(Plan);
        }

    }
}
