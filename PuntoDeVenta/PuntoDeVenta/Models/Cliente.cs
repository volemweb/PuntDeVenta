using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuntoDeVenta.Models
{
    public class Cliente
    {
        public int _Id;
        public string _Nombre;
        public string _Apellidos;
        public string _Direcion;
        public string _Telefono;
        public string _Email;


        public Cliente(String Nombre, string Apellidos, string Direccion, string Telefono, string Email)
        {
            _Nombre = Nombre;
            _Apellidos = Apellidos;
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
