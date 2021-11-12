using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoe
    {
        //não precisamos passar o primeiro argumento na chamada, pois esse argumento já é passado quando uma lista chama o método
         //this é obrigatório
        public static void AdicionarVarios<T> (this List<T> lista, params T[] itens)
        {
            foreach(T item in itens)
            {
                lista.Add(item);
            }
        }
    }
}
