using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Text.RegularExpressions; // utilizo para la validación del email

namespace PuntoDeVenta.Models
{
    class ValidarFormulario
    {
        public void soloLetras(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar)) // si lo que ese esta tecleadndo es una letra
                {
                    e.Handled = false; //con esto permitimos la tecla
                }
                else if (char.IsControl(e.KeyChar)) // poder usar la tecla se pueda borrar
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar)) // podemos usar el separador
                {
                    e.Handled = false;
                }
                else { e.Handled = true; } // si nos una tecla de las anteriores no se permite
            }
            catch (Exception ex)
            { }
        }
        public void soloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar)) // si lo que ese esta tecleadndo es un numero
                {
                    e.Handled = false; //con esto permitimos la tecla se escriba
                }
                else if (char.IsControl(e.KeyChar)) // poder usar la tecla se pueda borrar
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar)) // podemos usar el separador
                {
                    e.Handled = false;
                }
                else { e.Handled = true; } // si nos una tecla de las anteriores no se permite
            }
            catch (Exception ex)
            { }
        }

        public bool esEmail(string email)
        {
            bool correcto=false;

            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    correcto = true;
                }
                else
                {
                    correcto = false;
                }
            }
            else
            {
                correcto = false;
            }
            return correcto;


        }
    }
}
