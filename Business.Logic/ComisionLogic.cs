using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class ComisionLogic : BusinessLogic
    {
        private ComisionAdapter _ComisionData;

        public ComisionLogic()
        {
            ComisionData = new ComisionAdapter();
        }

        public ComisionAdapter ComisionData
        {
            get { return _ComisionData; }
            set { _ComisionData = value; }
        }

        public List<Comision> GetAll(int idPlan)
        {
            return ComisionData.GetAll(idPlan);
        }

        public Comision GetOne(int ID)
        {
            return ComisionData.GetOne(ID);
        }

        public void Delete(int ID)
        {
            ComisionData.Delete(ID);
        }

        public void Save(Comision com)
        {
            ComisionData.Save(com);
        }
    }
}
