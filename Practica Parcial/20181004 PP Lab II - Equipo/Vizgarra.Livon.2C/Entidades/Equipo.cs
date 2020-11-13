using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaxJugadores=6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public string Nombre { get { return this.nombre; } }
        public DirectorTecnico DirectorTecnico 
        { 
            set 
            {
                if(value.ValidarAptitud())
                {
                    directorTecnico = value;
                }                    
            } 
        }

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre):this()
        {
            this.nombre = nombre;
        }
        
        public static explicit operator string (Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Equipo: {e.Nombre}");
            if (e.directorTecnico is null)
            {
                sb.AppendLine("Sin DT asignado");
            }
            else
            {
                sb.AppendFormat($"Dt: {e.directorTecnico.Mostrar()}");
            }

            foreach(Jugador jugador in e.jugadores)
            {
                sb.AppendFormat($"Jugador: {jugador.Mostrar()}");
            }
            return sb.ToString();
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            foreach (Jugador jugador in e.jugadores)
            {
                if (jugador==j)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (!(e is null) && !(j is null))
            {
                if (!(e == j))
                {
                    if (Equipo.cantidadMaxJugadores > e.jugadores.Count && j.ValidarAptitud())
                        e.jugadores.Add(j);
                }
            }
            return e;
        }
        public static bool ValidarEquipo(Equipo equipo)
        {
            int arquero = 0;
            int defensor = 0;
            int central = 0;
            int delantero = 0;

            foreach (Jugador item in equipo.jugadores)
            {
                switch (item.Posiciones)
                {
                    case Posicion.Arquero:
                        arquero++;
                        break;
                    case Posicion.Defensor:
                        defensor++;
                        break;
                    case Posicion.Central:
                        central++;
                        break;
                    case Posicion.Delantero:
                        delantero++;
                        break;
                    default:
                        break;
                }
            }
            if (!(equipo.directorTecnico is null))
            {
                if (Equipo.cantidadMaxJugadores == equipo.jugadores.Count())
                {
                    if (arquero == 1 && delantero > 0 && central > 0 && delantero > 0)
                    { 
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
