using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador:Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public Jugador(string nombre, string apellido, int edad, int dni,float altura, float peso, Posicion posicion)
        : base(nombre, apellido, edad, dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }

        public float Altura{ get { return this.altura; } }
        public float Peso { get { return this.peso; } }
        public Posicion Posiciones { get { return this.posicion; } }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Nombre: {base.Mostrar()}");
            sb.AppendFormat($"Alt: {altura}");
            sb.AppendFormat($"Peso: {peso}");
            sb.AppendFormat($"Pos: {posicion}");

            return sb.ToString();
        }

        public override bool ValidarAptitud()
        {
            if(EstadoFisico()==true && this.Edad<=40)
            {
                return true;
            }
            return false;
        }

        public bool EstadoFisico()
        {
            float IMC;
            IMC = this.Peso/(this.Altura*2);

            if (IMC>18.5 && IMC<=25)
            { 
                return true;
            }
            return false;
        }


    }
}
