using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boligrafos
{
    public class Boligrafo
    {
        public short cantidadTintaMaxima=100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            //ConsoleColor aux;
            //aux = this.color;
            return this.color;
        }//Getter basico 

        public short GetTinta()
        {
            //short aux;
            //aux = this.tinta;
            return this.tinta; 
        }//Getter basico 

        private void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }//Este es el metodo q llama al setter

        private void SetTinta(short tinta)
        {
            int carga = GetTinta() + tinta;
            //obtengo la cant. actual d tinta del objeto instanciado y lo sumo al valor obtenido x referencia

            if (carga <= cantidadTintaMaxima && carga >= 0)
            {
                //verifico q no se pase de los limites
                this.tinta = (short)(carga);//y establezco el nuevo valor p el objeto instanciado
            }
            else
            {
                Console.WriteLine("valores incorrectos");
                this.tinta = 0;//si no "quito el cartucho"
            }
        }
        /*/
        El método Pintar(short, out string) restará la tinta gastada (reutilizar código SetTinta), 
        sin poder quedar el nivel en negativo, avisando si pudo pintar (nivel de tinta mayor a 0). 
        También informará mediante el out string tantos "*" como haya podido "gastar" del nivel de tinta.
        O sea, si nivel de tinta es 10 y gasto es 2 valdrá "**" y si nivel de tinta es 3 y gasto es 10 "***".
        /*/
        public bool Pintar(short gasto, out string dibujo)
        {
            StringBuilder aux = new StringBuilder();
            
            if (this.GetTinta() > 0)//siempre del objeto instanciado
            {            
                if (gasto>=this.GetTinta())
                {
                    SetTinta((short)(0));
                    string caca = new String ('*', (int)(this.GetTinta()));
                    aux.Append(caca);
                }
                else
                {
                    SetTinta((short) (this.GetTinta() - gasto));
                    string caca = new String('*', gasto);
                    aux.Append(caca);
                }
                dibujo = aux.ToString();
                return true;
            }
            else
            {
                dibujo = aux.ToString();
                Console.WriteLine("no tiene tinta");
                return false;
            }
        }
    }
}
