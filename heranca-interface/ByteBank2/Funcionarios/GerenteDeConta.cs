using ByteBank2.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        //chamando o construtor do funcionário a passando o cpf e o salário padrão de 4000
        public GerenteDeConta(string cpf) : base(cpf, 4000)
        {
        }
        public override void AumentarSalario()
        {
            
            Salario *= 1.05;
        }

        //Sobreescrevendo o método da classe herdada(funcionário)
        public override double GetBonificacao()
        {
            //chamando o get bonificação do funcionário
            return Salario * 0.25;
        }
    }
}

