﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string nombre;
        private int dni;
        private int edad;

        public Persona(string nombre, string apellido,  int edad, int dni)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
            this.edad = edad;
        }

        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        public int Dni { get { return this.dni; } }
        public int Edad { get { return this.edad; } }


        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Nombre: {nombre}");
            sb.AppendFormat($"Nombre: {apellido}");
            sb.AppendFormat($"Nombre: {dni}");
            sb.AppendFormat($"Nombre: {edad}");

            return sb.ToString();
        }

        public abstract bool ValidarAptitud();
    }
}
