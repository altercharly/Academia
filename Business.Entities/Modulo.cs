using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Modulo : BusinessEntity
    {
        private string _Descripcion;
        private int _IdModulo;

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public int IdModulo
        {
            get { return _IdModulo; }            
        }
    }
}
