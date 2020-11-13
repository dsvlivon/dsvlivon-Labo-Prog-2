using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContadorPalabras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
            {
                Dictionary<string, int> diccionario = new Dictionary<string, int>();
            //instanciamos un nuevo objeto "diccionario" del tipo Dictionary
            
            string texto = richTextBox.Text;
            string[] arrayPalabras = texto.Split(' ');
            //El método String.Split crea una matriz de subcadenas dividiendo la cadena de entrada en función de uno o más delimitadores
            //osea que crear un string con cada palabra q encuentra
            for (int i = 0; i < arrayPalabras.Length; i++)
            {
                if (!diccionario.ContainsKey(arrayPalabras[i]))
                {
                    diccionario.Add(arrayPalabras[i], 1);
                    //sino la encuentra, es decir  q es nueva, la agrega al diccionario y le inicializa el valor numérico en 1
                }
                else
                {
                    //pregunta si en cada posición continene la palabra indicada
                    diccionario[arrayPalabras[i]] = ++diccionario[arrayPalabras[i]];
                    //y le asigna a esa posicion, la q contiene la palabra ++ al valor numerico                  
                }
            }
            MessageBox.Show(mensajeTop(diccionario));
        }
        private static string mensajeTop(Dictionary<string,int> diccionario)
        {
            List<KeyValuePair<string, int>> listaValues = new List<KeyValuePair<string, int>>(diccionario.ToList());
            // instanciamos un nuevo objeto "listaValues" del tipo List con el "metodo" keyValuePair 
            listaValues.Sort(comparar);//llamo al metodo de ordenamiento
            int top = 0;
            StringBuilder mensaje = new StringBuilder("");
            foreach (KeyValuePair<string, int> entrada in listaValues)
            {
                mensaje.AppendFormat("{0}\t{1}\n", entrada.Key, entrada.Value);
                top++;
                if (top > 2)
                { 
                    break;
                }
            }
            return mensaje.ToString();
        }
        private static int comparar(KeyValuePair<string,int> clave1,KeyValuePair<string,int> clave2)
        {
            return clave2.Value + clave1.Value;
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
