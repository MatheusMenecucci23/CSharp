using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Comparadore
{
    //adicionando a interface ICOMPARER<tipo das váriaveis que serão comparadas>
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {

            return x.Agencia.CompareTo(y.Agencia);

            //o código de cima já compara e retorna os valores corretos
            //if (x.Agencia < y.Agencia)
            //{
            //    return -1;
            //}
            //if (x.Agencia == y.Agencia)
            //{
            //    return 0;
            //}
            //return 1;
        }
    }
}
