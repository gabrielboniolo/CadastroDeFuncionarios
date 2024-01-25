using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionarios
{
    internal class Operacoes
    {
        public static int ObterQuantidadeFuncionarios()
        {
            Console.Write("Para começar, digite por favor a quantidade desejada de quantos funcionários deseja cadastrar: ");
            int qtdFuncionarios = int.Parse(Console.ReadLine());
            return qtdFuncionarios;
        }

        public static Funcionario PreencherFuncionario(int numeroFuncionario)
        {
            Console.WriteLine($"\nFuncionário #{numeroFuncionario}");
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Cargo: ");
            string cargo = Console.ReadLine();
            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine());

            Funcionario funcionario = new(id, nome, cargo, salario);
            return funcionario;
        }
    }
}

