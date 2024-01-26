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
            Console.Write("Digite a quantidade de funcionários deseja cadastrar: ");
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

        public static void NovoFuncionario(Cadastro cadastro)
        {
            Console.Clear();

            int qtdFuncionarios = Operacoes.ObterQuantidadeFuncionarios();

            for (int i = 1; i <= qtdFuncionarios; i++)
            {
                cadastro.AddFuncionario(Operacoes.PreencherFuncionario(i));
            }

            Console.WriteLine("\nFuncionário(s) adicionados com sucesso!");
            Console.Write("\nPressione qualquer tecla para ir ao menu ");
            Console.ReadKey();
            MenuCrud(cadastro);
        }

        public static void DeletarFuncionario(Cadastro cadastro)
        {
            Console.Clear();
            Console.WriteLine("Digite abaixo o Id do funcionário que deseja remover:\n");
            foreach (var funcionario in cadastro)
            {
                Console.WriteLine($"-> Id:{funcionario.Id}, {funcionario.Nome}");           
            }
            Console.Write("\nResposta: ");
            int resposta = int.Parse(Console.ReadLine());

            Funcionario funcionarioParaRemover = cadastro.Funcionarios.FirstOrDefault(f => f.Id == resposta);

            if (funcionarioParaRemover != null)
            {
                cadastro.RemoveFuncionario(funcionarioParaRemover);
                Console.WriteLine($"Funcionário com Id {resposta} removido com sucesso!");
                RetornarAoMenu(cadastro);
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado!");
                RetornarAoMenu(cadastro);
            }


        }

        public static void AlterarFuncionario(Cadastro cadastro)
        {
            Console.Clear();
            Console.WriteLine("Digite abaixo o Id do funcionário que deseja alterar:\n");

            foreach (var funcionario in cadastro)
            {
                Console.WriteLine($"-> Id: {funcionario.Id}, {funcionario.Nome}");
            }

            Console.Write("\nResposta: ");
            int resposta = int.Parse(Console.ReadLine());

            Funcionario funcionarioParaAlterar = cadastro.Funcionarios.FirstOrDefault(f => f.Id == resposta);

            if (funcionarioParaAlterar != null)
            {
                Console.Clear();
                Console.WriteLine("Escolha o que deseja alterar:");
                Console.WriteLine("1 - Nome");
                Console.WriteLine("2 - Cargo");
                Console.WriteLine("3 - Salário");

                Console.Write("\nResposta: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Novo Nome: ");
                        funcionarioParaAlterar.Nome = Console.ReadLine();
                        Console.WriteLine("Nome alterado com sucesso!");
                        RetornarAoMenu(cadastro);
                        break;
                    case 2:
                        Console.Write("Novo Cargo: ");
                        funcionarioParaAlterar.Cargo = Console.ReadLine();
                        Console.WriteLine("Cargo alterado com sucesso!");
                        RetornarAoMenu(cadastro);
                        break;
                    case 3:
                        Console.Write("Novo Salário: ");
                        funcionarioParaAlterar.Salario = double.Parse(Console.ReadLine());
                        Console.WriteLine("Salário alterado com sucesso!");
                        RetornarAoMenu(cadastro);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        RetornarAoMenu(cadastro);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado!");
                RetornarAoMenu(cadastro); ;
            }
        }

        public static void ExibirFuncionarios(Cadastro cadastro)
        {
            Console.Clear();

            Console.WriteLine("Aqui está a lista de funcionários:\n");
            int i = 1;
            foreach (var funcionario in cadastro)
            {
                Console.WriteLine($"{i}) {funcionario}");
                i++;
            }
            RetornarAoMenu(cadastro); ;
        }

        public static void MenuCrud(Cadastro cadastro)
        {
            Console.Clear();

            Console.WriteLine("Selecione alguma das opções para prosseguir:\n");
            Console.WriteLine("1- Adicionar novo funcionário a lista");
            Console.WriteLine("2- Remover funcionário da lista");
            Console.WriteLine("3- Exibir lista");
            Console.WriteLine("4- Alterar dado de um funcionário");
            Console.WriteLine("5- Encerrar o programa");
            Console.Write("\nDigite aqui a sua resposta: ");
            int resposta = int.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 1:
                    NovoFuncionario(cadastro);
                    break;
                case 2:
                    DeletarFuncionario(cadastro);         
                    break;
                case 3:
                    ExibirFuncionarios(cadastro);
                    break;
                case 4:
                    AlterarFuncionario(cadastro);
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Por favor digite um número válido!");
                    RetornarAoMenu(cadastro);
                    break;
            }
        }
        public static void RetornarAoMenu(Cadastro cadastro)
        {
            Console.Write("\nPressione qualquer tecla para retornar ao menu ");
            Console.ReadKey();
            MenuCrud(cadastro);
        }
    }
}

