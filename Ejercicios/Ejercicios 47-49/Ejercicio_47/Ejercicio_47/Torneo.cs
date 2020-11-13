using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        public List<T> lista;
        public string nombre;

        public Torneo(string nombre)
        {
            this.lista = new List<T>();
            this.nombre = nombre;
        }
        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach (T item in torneo.lista)
            {
                if (item == equipo)
                { 
                    return true;
                }
            }
            return false;
        }


        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }
        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            if (torneo != equipo)//como tengo el == sobrecargado puedo hacer esto
            {
                torneo.lista.Add(equipo);
                return true;
            }
            return false;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"{this.nombre}"));
            foreach (T item in this.lista)
            {
                sb.AppendLine(item.Ficha());
                /*como es T item, dbd T:Equipo, puedo hacer item.Ficha()
                q es un metodo d la clase */
            }
            return sb.ToString();
        }
        private string CalcularPartido(T e1, T e2)
        //dos elementos del tipo T, que deberán ser del tipo Equipo o sus herencias
        {
            Random random = new Random();//esto no lo sabia
            int resultado1 = random.Next(0,100);
            int resultado2 = random.Next(0, 100);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"[{e1.nombre}] [{resultado1}] - [{resultado2}] [{e2.nombre}]"));
            return sb.ToString();
        }
        public string JugarPartido()
        /*La propiedad pública JugarPartido tomará dos equipos de la lista 
         al azar y calculará el resultado del partido a través del método CalcularPartido.*/
        {
            Random random = new Random();
            T equipo1 = this.lista[random.Next(this.lista.Count)];
            T equipo2 = this.lista[random.Next(this.lista.Count)];

            return this.CalcularPartido(equipo1, equipo2);
        }
    }
}
