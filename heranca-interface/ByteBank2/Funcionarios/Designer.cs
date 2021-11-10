using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2.Funcionarios
{
    class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf,3000)
        {
        }
        public override void AumentarSalario()
        {
   
            Salario *= 1.11;
        }

        //Sobreescrevendo o método da classe herdada(funcionário)
        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }
    }
}
