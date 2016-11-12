using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class TipoPersona : BusinessEntity
    {
        int _IdTipo;
        string _Descripcion;

        // 1 for Alumno - 2 for Docente

        int IdTipo
        {
            set { _IdTipo = value; }
            get { return _IdTipo; }
        }

        string Descripcion
        {
            set { _Descripcion = value; }
            get { return _Descripcion; }
        }
    }
}
