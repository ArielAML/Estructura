using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_MonroyLopezArielAlejandro
{
    public class Arbol
    {
        //Elemento del arbol
        Nodo raiz;

        //Constructor del arbol
        public Arbol(Nodo raiz)
        {
            this.raiz = raiz;
        }

        public string aTexto() //Operacion que llama a la operacion de la clase Nodo
        {
            return raiz.aTexto();
        }

        public int aAltura() //Operacion que llama a la operacion de la clase Nodo
        {
            return raiz.aAltura();
        }

    }
}
