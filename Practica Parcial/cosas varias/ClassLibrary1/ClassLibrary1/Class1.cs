using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public string legajo;
        public string empresa;
        public string materia;
        public DateTime fecha;

        public void PedirCertificadoExamen(string legajo, DateTime fecha, string empresa, string materia)
        {
            this.legajo = legajo;
            this.empresa = empresa;
            this.materia = materia;
            this.fecha = fecha;
        }

        private void PedirCertificadoExamen()
        {

        }

        /*public string PedirCertificadoExamen()
        {

        }*/

        public void PedirCertificadoExamen(string legajo, string empresa, string materia, DateTime fecha)
        {

        }
    }

}
