using System;
using System.Collections.Generic;
using System.Linq;
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

        public void ExibirFuncionarios()
        {
            Console.Clear();

            Console.WriteLine("Aqui está a lista de funcionários:\n");
            int i = 1;
            foreach(var funcionario in Funcionarios)
            {
                Console.WriteLine($"{i}) {funcionario}");
                i++;
            }
        }
    }
}
