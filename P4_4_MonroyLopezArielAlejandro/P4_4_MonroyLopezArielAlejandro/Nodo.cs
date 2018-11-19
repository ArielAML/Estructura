using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_4_MonroyLopezArielAlejandro
{
    public class Nodo
    {
        //Propiedades de los nodos
        public string valor { get; set; }
        public int espacioMatriz { get; set; }
        
        public Nodo(string valor, int espacioMatriz) //constructor
        {
            this.espacioMatriz = espacioMatriz;
            this.valor = valor;
        }
        
    }
}
