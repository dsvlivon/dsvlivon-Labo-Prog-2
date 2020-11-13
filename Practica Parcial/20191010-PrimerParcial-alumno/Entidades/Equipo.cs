using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaxJugadores = 5;


        private Tecnico directorTecnico;
        private List<Jugador> jugadores;

        private int espaciosTotales;
        private static Equipo singleton;


        public Tecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud())
                {
                    directorTecnico = value;
                }
            }
        }
        public List<Jugador> Jugadores
        {
            get
            {
                return this.jugadores;
            }
        }

        private Equipo(int espacios)
        {
            this.jugadores = new List<Jugador>();
            this.espaciosTotales = espacios;
        }

        public static Equipo GetEquipo(int espacios)
        {
            if (singleton == null)
            {
                singleton = new Equipo(espacios);
            }
            else
            {
                singleton.espaciosTotales = espacios;
            }
            return singleton;
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();

            if (e.directorTecnico is null)
            {
                sb.AppendLine("Sin DT asignado");
            }
            else
            {
                sb.AppendFormat($"DT: {e.directorTecnico.Mostrar()}");
            }

            foreach (Jugador jugador in e.jugadores)
            {
                sb.AppendFormat($"Jugador: {jugador.Mostrar()}");
            }
            return sb.ToString();
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            foreach (Jugador jugador in e.jugadores)
            {
                if (jugador == j)
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
            int basex = 0;
            int alero = 0;
            int alapivot = 0;
            int pivot = 0;
            int escolta = 0;

            foreach (Jugador item in equipo.jugadores)
            {
                switch (item.Posiciones)
                {
                    case Posicion.Base:
                        basex++;
                        break;
                    case Posicion.Alero:
                        alero++;
                        break;
                    case Posicion.Escolta:
                        alapivot++;
                        break;
                    case Posicion.AlaPivot:
                        pivot++;
                        break;
                    case Posicion.Pivot:
                        escolta++;
                        break;
                    default:
                        break;
                }
            }
            if (!(equipo.directorTecnico is null))
            {
                if (Equipo.cantidadMaxJugadores == equipo.jugadores.Count())
                {
                    if (basex == 1 && escolta == 1 && pivot == 1 && alero == 1 && alapivot == 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
