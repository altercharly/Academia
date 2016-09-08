using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {

        Data.Database.UsuarioAdapter _UsuarioData = new Data.Database.UsuarioAdapter();

        public UsuarioLogic()
        {
           this.UsuarioData = null;
        }
          
        public Data.Database.UsuarioAdapter UsuarioData
        {
            get { return _UsuarioData; }
            set { _UsuarioData = value; }
        }

        public List<Usuario> GetAll ()
        {
            return UsuarioData.GetAll();
        }
        
        public Usuario GetOne (int  Id )
        {
            return UsuarioData.GetOne(Id);
        }

        public void Delete(int Id)
        {
            UsuarioData.Delete(Id);
        }

        public void Save(Business.Entities.Usuario Usuario)
        {
            UsuarioData.Save(Usuario);
        }

    }
}
