using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;


namespace UI.Consola
{
    public class Usuarios
    {
        Business.Logic.UsuarioLogic _UsuarioNegocio = new Business.Logic.UsuarioLogic();

        public static void Menu()
        {
            Console.WriteLine("1- Listado General");
            Console.WriteLine("2- Consulta");
            Console.WriteLine("3- Agregar");
            Console.WriteLine("4- Modificar");
            Console.WriteLine("5- Eliminar");
            Console.WriteLine("6- Salir");
            //tengo q obtener el dato del usuario
        }
    }
}
