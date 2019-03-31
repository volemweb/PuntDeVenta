using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuntoDeVenta
{
    public class Cliente
    {
        public int _Id;
        public string _Nombre;
        public string _Apellido1;
        public string _Apellido2;
        public string _Direcion;
        public string _Telefono;
        public string _Email;

        public Cliente(String Nombre, string Apellido1, string Apellido2, string Direccion, string Telefono, string Email)
        {
            _Nombre = Nombre;
            _Apellido1 = Apellido1;
            _Apellido2 = Apellido2;
            _Direcion = Direccion;
            _Telefono = Telefono;
            _Email = Email;
        }

        public int Id
        {
            get { return _Id; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }


    }
}
