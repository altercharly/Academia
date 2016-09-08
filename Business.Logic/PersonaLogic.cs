using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Business.Logic 
{
    public class PersonaLogic : BusinessLogic
    {
        Data.Database.PersonaAdapter _PersonaData = new Data.Database.PersonaAdapter();

        public PersonaLogic()
        {
            this.PersonaData = null;
        }

        public Data.Database.PersonaAdapter PersonaData
        {
            get { return _PersonaData; }
            set { _PersonaData = value; }
        }

        public List<Personas> GetAll()
        {
            return PersonaData.GetAll();
        }

        public Personas GetOne(int Id)
        {
            return PersonaData.GetOne(Id);
        }

        public void Delete(int Id)
        {
            PersonaData.Delete(Id);
        }

        public void Save(Business.Entities.Personas Persona)
        {
            PersonaData.Save(Persona);
        }
    }
}
