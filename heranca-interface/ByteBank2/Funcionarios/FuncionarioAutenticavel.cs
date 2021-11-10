using ByteBank2.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        //passando o cpf e salario dessa classe para a classe base funcionário
        public FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string Senha { get; set; }

   

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
