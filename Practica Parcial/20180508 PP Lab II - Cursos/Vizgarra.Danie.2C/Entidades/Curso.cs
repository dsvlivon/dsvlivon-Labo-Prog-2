using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        private Curso()//constructor privado!
        {
            this.alumnos = new List<Alumno>();
        }
        //este va como public OJO
        public Curso(short anio, Divisiones division, Profesor profesor) : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public string AnioDivision//esto es muy flashero.... ojo xq no lo explica, t lo tenes q imaginar
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(anio);
                sb.Append(" ° ");
                sb.Append(division);
                return sb.ToString();
            }
        }

        public static explicit operator string(Curso curso) //"EL OPERADOR EXPLICITO"
        {
            //esto podria ser tranquilamente un metodo...
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format($"{curso.AnioDivision}"));
            sb.AppendLine(string.Format($"{curso.profesor.ExponerDatos()}"));
            sb.AppendLine("Alumnos");
            foreach (Alumno item in curso.alumnos)
            {
                sb.Append(item.ExponerDatos().ToString());
            }
            return sb.ToString();
        }

        public static bool operator ==(Curso c, Alumno a)
        {
            //compara q el alumno sea d la division del curso
            if (c.AnioDivision == a.AnioDivision)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }

        public static /*bool*/Curso operator +(Curso c, Alumno a)
        {
            //no es bool xq obvio, necesita q le devuelva un curso
            //if (!(curso is null) && !(alumno is null))... Sergio ahi valida esto q esta muy bien
            if (c.AnioDivision == a.AnioDivision)
            {
                c.alumnos.Add(a);
            }
            return c;
        }
    }

}
