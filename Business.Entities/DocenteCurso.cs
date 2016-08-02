using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    class DocenteCurso : BusinessEntity
    {
        //private TipoCargos _Cargo;
        private int _IDCurso;
        private int _IDDocente;

        //public TipoCargos Cargo
        //{
        //    get { return _Cargo; }
        //   set { _Cargp = value; }
        //}
        public int IDCurso
        {
            get { return _IDCurso; }
            set { _IDCurso = value; }
        }
        public int IDDocente
        {
            get { return _IDDocente; }
            set { _IDDocente = value; }
        }
    }
}
