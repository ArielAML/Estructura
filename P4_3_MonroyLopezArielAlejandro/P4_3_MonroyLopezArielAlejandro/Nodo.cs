using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_3_MonroyLopezArielAlejandro
{
    public class Nodo
    {
        //Propiedades de los Nodos
        public string letra;
        Nodo padre;
        List<Nodo> hijos;
        public int altura = 0;
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

        public List<Nodo> getHijos() //Almacena los valores que estan dentro de la lista del nodo a una lista dentro de la clase nodo para usarlo en esta
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

        public string aTexto() //Utiliza un constructor de cadena para imprimir la representacion del arbol
        {
            StringBuilder bString = new StringBuilder();
            bString.Append(this.getletra());
            if (this.esPadre())
            {
                bString.Append("(");
                foreach (Nodo item in this.getHijos())
                {
                    bString.Append(item.aTexto());//Aqui se utiliza la recursividad para que realize el mismo proceso con los hijos del nodo
                    bString.Append(", ");
                }
                bString.Remove(bString.Length - 2, 2);//remueve ciertos espacion dentro del string
                bString.Append(")");
            }
            return bString.ToString();
        }

        public int aAltura() //Metodo que utiliza condiciones y recursividad para calcular la altura del arbol (y por consecuente el nivel, que es altura-1)
        {
            
            if (this.getHijos() == null) //Si el nodo no tiene hijos, devuelve la altura actual
            {
                return altura;
            }
            else //De no ser asi, ve cada nodo en la lista de hijos del nodo actual y se vuelve a ejecutar la operacion para ver si es padre o no
            {
                foreach (Nodo item in this.getHijos())
                {
                        item.aAltura();
                        altura++;
                }
                return altura;
            }
        }
    }
}
