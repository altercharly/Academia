using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Business.Logic
{
    public class MateriaLogic
    {
        Data.Database.MateriaAdapter _PersonaData = new Data.Database.MateriaAdapter();

        public MateriaLogic()
        {
            this.MateriaData = null;
        }

        public Data.Database.MateriaAdapter MateriaData
        {
            get { return MateriaData; }
            set { MateriaData = value; }
        }

        public List<Materia> GetAll()
        {
            return MateriaData.GetAll();
        }

        public Materia GetOne(int Id)
        {
            return MateriaData.GetOne(Id);
        }

        public void Delete(int Id)
        {
            MateriaData.Delete(Id);
        }

        public void Save(Business.Entities.Materia Materia)
        {
            MateriaData.Save(Materia);
        }
    }
}

