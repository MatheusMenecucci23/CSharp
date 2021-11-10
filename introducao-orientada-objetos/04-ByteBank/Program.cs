using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine("Saldo atual: "+contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(500);

            Console.WriteLine(resultadoSaque);
            Console.WriteLine("Saldo após o saque: "+contaDoBruno.saldo);

            contaDoBruno.Depositar(500);
            Console.WriteLine("Saldo após o depósito: "+contaDoBruno.saldo);


            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";


            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);
            
            Console.WriteLine("Saldo do bruno: "+ contaDoBruno.saldo);
            Console.WriteLine("Saldo Gabriela: "+ contaDaGabriela.saldo);
            Console.WriteLine("Resultado transferencia: "+resultadoTransferencia);

            bool resultadoTransferencia2 = contaDaGabriela.Transferir(100, contaDoBruno);

            Console.WriteLine("Saldo do bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine("Resultado transferencia: " + resultadoTransferencia);



            Console.ReadLine();
        }
    }
}
