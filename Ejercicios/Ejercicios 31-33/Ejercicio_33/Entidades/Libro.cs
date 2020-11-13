using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }
        public string this[int indice]
        {
            get 
            {
                if (indice < paginas.Count && indice > 0)
                {
                    ////El indexador leerá la página pedida, siempre y cuando el subíndice se encuentre dentro de un rango correcto, .
                    return paginas[indice];
                }
                else
                {
                    //sino retornará un string vacio “”
                    return string.Empty;
                }
            }
            set 
            {
                //En el set, la asignará si ésta ya existe.
                if (indice >= 0)
                {
                    if (indice >= paginas.Count)
                    {
                        //Si el índice es superior al máximo existente, agregará una nueva página
                        paginas.Add(value);
                        }
                    else if (indice < paginas.Count)
                    {
                        this.paginas[indice] = value;
                    }
                }
            }
        }
    }
}
