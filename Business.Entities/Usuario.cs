using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Usuario : BusinessEntity
    {
        private int _Id;
        private string _NombreUsuario;
        private string _Clave;
        private string _Nombre;
        private string _Apellido;
        private string _Email;
        private bool _Habilitado;

    /*    public Usuario(int id, string nombreu, string clave, string nom, string ape, string email)
        {
            _Id = id;
            _NombreUsuario = nombreu;
            _Clave = clave;
            _Nombre = nom;
            _Apellido = ape;
            _Email = email;
        }

        public Usuario(string nombreu, string clave, string nom, string ape, string email)
        {
            _NombreUsuario = nombreu;
            _Clave = clave;
            _Nombre = nom;
            _Apellido = ape;
            _Email = email;
        }

        public Usuario()
        {

        }
    */
        private int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string NombreUsuario
        {
            get { return _NombreUsuario; }
            set { _NombreUsuario = value; }
        }
        public string Clave
        {
            get { return _Clave; }
            set { _Clave = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public bool Habilitado
        {
            get { return _Habilitado; }
            set { _Habilitado = value; }
        }
    }
}
