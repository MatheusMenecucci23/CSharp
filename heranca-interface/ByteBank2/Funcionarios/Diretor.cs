using ByteBank2.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        //passando para a classe base o cpf e o salário padrão do diretor de 5000
        public Diretor(string cpf) : base(cpf, 5000)
        {
        }
   
        public override void AumentarSalario()
        {
            //Salario = Salario + (Salario * 0.1);
            //Salario = Salario * 1.1;
            Salario *= 1.15;
        }

        

        //Sobreescrevendo o método da classe herdada(funcionário)
        public override double GetBonificacao()
        {
            
            return Salario * 0.5 ;
        }
    }
}
