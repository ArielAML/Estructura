using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_MonroyLopezArielAlejandro
{
    class Nodo
    {
        //Propiedades de los Nodos
        public string letra;
        Nodo padre;
        List<Nodo> hijos;

        //Constructor del nodo
        public Nodo(string letra, Nodo padre)
        {
            this.letra = letra;
            this.padre = padre;
            hijos = new List<Nodo>(); //Lista que almacena los nodos hijos
        }

        //public void setletra(string letra)
        //{
        //    this.letra = letra;
        //}

        public string getletra() //Toma el valor de la letra de la raiz
        {
            return letra;
        }

        public void agregarHijo(Nodo hijo) //Metodo para agregar un Nodo a la lista de otro nodo antecesor
        {
            hijos.Add(hijo);
        }

        public List<Nodo> getHijos() //Almacena los valores que estan dentro de la lista del nodo
        {
            return this.hijos;
        }

        public bool esPadre() //Operacion que determina si el nodo es padre o no
        {
            if (hijos.Count == 0)
                return false;
            else
                return true;
        }

        public Nodo getPadre()//Obtiene las propiedades del nodo padre
        {
            return this.padre;
        }

        public string aPreOrden() //Utiliza un constructor de cadena para imprimir la representacion del arbol en postorden
        {
            StringBuilder bString = new StringBuilder();
            bString.Append(this.getletra());
            if (this.esPadre())
            {
                bString.Append("(");
                foreach (Nodo item in this.getHijos())
                {
                    bString.Append(item.aPreOrden());//Aqui se utiliza la recursividad para que realize el mismo proceso con los hijos del nodo
                    bString.Append(", ");
                }
                bString.Remove(bString.Length - 2, 2);
                bString.Append(")");
            }
            return bString.ToString();
        }
    }
}
