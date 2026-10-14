using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BibliotecaClases
{
    public class EntryContrasenia : Entry
    {
        // CONSTANTES

        // MIEMBROS
        private string _contrasenia;

        // CONSTRUCTORES
        public EntryContrasenia(string contrasenia)
        {
            Contrasenia = contrasenia;
        }
        // PROPIEDADES
        public string Contrasenia
        {
            get
            {
                return _contrasenia;
            }
            set
            {
                ValidarContrasenia(value);
                _contrasenia = value;
            }
        }

        // MÉTODOS
        private void ValidarContrasenia(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("No ha introducido ninguna contraseña.");
            }

        }
    }
}
