using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        static Random notaRandom;

         static Alumno()
        {
            notaRandom = new Random();
            
        }

        public void CalcularFinal()
        {
           
            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                notaFinal = notaRandom.Next(4,10);
                //metodo random: si se cumple la condicion, asigna una nota random entre el rango 4-10
            }
            else
            {
               notaFinal = -1;//ojo con "='" y "a= -2"
            }

        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }//metodo publico p/ asignar las notas q obtuve por parametro a los this
        //ojo, this es cada objeto instanciado

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("\n");
            retorno.AppendFormat("Alumno: {0}\n", this.apellido);
            retorno.AppendFormat("Legajo: {0}\n", this.legajo);
            retorno.AppendFormat("Nota1: {0} y nota2: {1}\n", this.nota1, this.nota2);
            //se puede hacer con cw pero esto es un poco mejor...
            CalcularFinal();//llamo al metodo
            if (notaFinal !=-1)
            {
                retorno.AppendFormat("Nota final: {0}", this.notaFinal);
            }
            else
            {
                retorno.AppendFormat("Alumno desaprobado");
            }
            return retorno.ToString();
        }
    }
}
