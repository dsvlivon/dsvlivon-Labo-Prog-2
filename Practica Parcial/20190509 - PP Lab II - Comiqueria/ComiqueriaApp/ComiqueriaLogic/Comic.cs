using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic:Producto
    {
        private string autor;
        private TipoComic tipoComic;

        public enum TipoComic
        {
            Occidental,Oriental            
        }

        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipoComic)
            :base(descripcion, stock, precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }

        public string Autor { get;}
        public TipoComic Tipo{ get;}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.ToString());
            sb.AppendFormat($"Autor:{this.Autor}");
            sb.AppendFormat($"Tipo:{this.Tipo}");

            return sb.ToString();
        }
    }
}
