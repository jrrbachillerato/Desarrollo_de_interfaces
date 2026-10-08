using System;
using System.Collections.Generic;
using System.Text;

namespace BotonesEspeciales
{
    public class MiBoton : Button
    {
        // ENUMERACIÓN
        private enum EstadoBoton : byte { Azul, Verde , Rojo}

        // CAMPOS
        private EstadoBoton _estado;

        // CONSTRUCTORES
        public MiBoton() : base()
        {
            // Inicializacíón de aspectos de diseño del botón.
            BackgroundColor = Colors.Blue;
            _estado = EstadoBoton.Azul;

            // Suscripción de eventos
            Clicked += MiBoton_Click;
        }

        public MiBoton(string texto) : this()
        {
            _estado = EstadoBoton.Azul;
            Text = texto;
        }

        // MÉTODOS PRIVADOS
        private void MiBoton_Click(object? sender, EventArgs e)
        {
            switch (_estado)
            {
                case EstadoBoton.Azul:
                    BackgroundColor = Colors.Green;
                    _estado = EstadoBoton.Verde;
                    break;
                case EstadoBoton.Verde:
                    BackgroundColor= Colors.Red;
                    _estado = EstadoBoton.Rojo;
                    break;
                case EstadoBoton.Rojo:
                    BackgroundColor = Colors.Blue;
                    _estado = EstadoBoton.Azul;
                    break;                  
            }
        }
    }
}
