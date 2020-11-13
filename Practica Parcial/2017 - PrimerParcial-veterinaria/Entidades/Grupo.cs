using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        private string nombre;
        private static TipoManada tipo;

        public enum TipoManada
        { Unica, Mixta }
        private List<Mascota> manada;


        public TipoManada Tipo { set { tipo = value; } }


        #region "Constructores"
        /*Constructores:
        - De clase que inicializará el tipo como Única.
        - Por defecto privado, será el único lugar donde se inicialice la lista.
        - Otro recibirá nombre.
        - El último recibirá nombre y tipo.
        Una sola propiedad de sólo escritura para el tipo.*/

        private Grupo()
        {
            this.manada = new List<Mascota>();
        }
        static Grupo()
        {
            tipo = TipoManada.Unica;
        }
        public Grupo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo)
            : this(nombre)
        {
            this.Tipo = tipo;
        }
        #endregion

        public static bool operator ==(Grupo e, Mascota j)
        {
            foreach (Mascota mascota in e.manada)
            {
                if (mascota == j)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Grupo a, Mascota b)
        {
            return !(a == b);
        }
        public static Grupo operator +(Grupo a, Mascota b)
        {
            if (a != b)
            {
                a.manada.Add(b);
            }
            return a;
        }

        public static Grupo operator -(Grupo a, Mascota b)
        {
            for (int i = 0; i < a.manada.Count; i++)
            {
                a.manada.RemoveAt(i);
            }
            return a;
        }

        public static implicit operator string(Grupo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("**Rio Unica**");
            sb.Append("\nIntegrantes: ");

            foreach (Mascota integrante in e.manada)
            {
                sb.Append(integrante.ToString());
            }

            return sb.ToString();
        }            
    }
}
