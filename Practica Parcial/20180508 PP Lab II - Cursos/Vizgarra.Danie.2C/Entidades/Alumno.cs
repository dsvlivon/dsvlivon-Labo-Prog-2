using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private Divisiones division;

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division) : base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }

        public string AnioDivision { get { return anio + "°" + this.division.ToString(); } }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.AnioDivision);
            sb.AppendLine(base.ExponerDatos());
            //sb.Append(string.Format($"{base.ExponerDatos()}")); es lo mismo
            //llamo al exponer datos d Persona, osea la base, q m escribe x consola nombre/apellido/documento
            return sb.ToString();
        }
        protected override bool ValidarDocumentacion(string doc)
        {
            bool valida = false;
            if (doc.Length != 9)
            {
                valida = false;
            }
            else
            {
                int numero;
                bool esNumerico;

                for (int i = 0; i < doc.Length; i++)
                {
                    esNumerico = int.TryParse(doc[i].ToString(), out numero);
                    if (!esNumerico)
                    {
                        if (doc[i] != '-')
                            valida = false;
                        break;
                    }
                    else
                    {
                        if (i != 2)
                        {
                            if (i != 7)
                                valida = false;
                            break;
                        }
                    }
                }
            }
            return valida;
        }
    }
}
