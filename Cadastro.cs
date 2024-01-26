using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionarios
{
    internal class Cadastro
    {
        public List<Funcionario> Funcionarios { get; private set; }

        public Cadastro()
        {
            Funcionarios = new();
        }

        public void AddFuncionario(Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
        }

        public void RemoveFuncionario(Funcionario funcionario)
        {
            Funcionarios.Remove(funcionario);
        }

        public IEnumerator<Funcionario> GetEnumerator()
        {
            return Funcionarios.GetEnumerator();
        }
    }
}
