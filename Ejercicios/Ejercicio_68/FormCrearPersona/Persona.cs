using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCrearPersona
{
    public delegate void DelegadoString(string msg);
    public class Persona
    {
        private string nombre;
        private string apellido;
        public event DelegadoString EventoString;
        public Persona(string nombre, string apellido)
        {
            this.nombre= string.Empty;
            this.apellido = string.Empty;
        }
        public string Nombre
        {
            get 
            { 
                return nombre; 
            }
            set 
            { 
                nombre = value; 
            }
        }
        public string Apellido
        {
            get 
            { 
                return apellido; 
            }
            set 
            { 
                apellido = value; 
            }
        }

        public string Mostrar()
        {
            return this.Apellido + "," + this.Nombre +".";
        }

    }
   
}
