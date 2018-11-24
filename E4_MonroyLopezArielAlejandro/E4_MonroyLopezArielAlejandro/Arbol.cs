using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_MonroyLopezArielAlejandro
{
    class Arbol
    {
        //Elemento del arbol
        Nodo raiz;

        //Constructor del arbol
        public Arbol(Nodo raiz)
        {
            this.raiz = raiz;
        }

        public string aPreOrden() //Operacion que llama a la operacion de la clase Nodo
        {
            return raiz.aPreOrden();
        }
    }
}
