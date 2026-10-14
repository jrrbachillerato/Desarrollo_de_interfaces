using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaClases
{
    public class EntryNombreUsuario : Entry
    {
        // CONSTANTES
        const byte MIN_NOMBRE = 5;
        const byte MAX_NOMBRE = 15;
        const byte TAM_CONTRASENIA = 10;

        // MIEMBROS
        private string _nombreUsuario;

        // CONSTRUCTORES
        public EntryNombreUsuario(string nombreUsuario)
        {
            NombreUsuario = nombreUsuario;
        }
        // PROPIEDADES
        public string NombreUsuario
        {
            get
            {
                return _nombreUsuario;
            }
            set
            {
                ValidarUsuario(value);
                value = _nombreUsuario;
            }
        }

        // MÉTODOS
        private void ValidarUsuario(string nombre)
        {
            if (String.IsNullOrEmpty(nombre))
            {
                throw new ArgumentException("No ha introducido ningún nombre");
            }

            if(nombre.Length < MIN_NOMBRE)
            {
                throw new ArgumentException($"La longitud mínima permitida es de {MIN_NOMBRE} caracteres.");
            }

            if(nombre.Length > MAX_NOMBRE)
            {
                throw new ArgumentException($"La longitud máxima permitida es de {MAX_NOMBRE} caracteres.");
            }

            for(int i = 0; i<MAX_NOMBRE; i++)
            {
                if (!char.IsLetter(nombre[i])){
                    throw new ArgumentException("El nombre solo puede contener letras");
                }
            }
        }

        public override string ToString()
        {
            string cadena = "";

            cadena += $"Usuario: {NombreUsuario}";
            return cadena;
        }
    }
}
