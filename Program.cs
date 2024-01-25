namespace CadastroFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Bem-vindo ao Sistema de Cadastro de Funcionários -----\n");

            Console.Write("Para começar, digite por favor a quantidade desejada de quantos funcionários deseja cadastrar: ");
            int qtdFuncionarios = int.Parse(Console.ReadLine());

            Cadastro cadastro = new Cadastro();

            for (int i = 1; i <= qtdFuncionarios; i++)
            {
                Console.WriteLine($"\nFuncionário #{i}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Cargo: ");
                string cargo = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());

                Funcionario funcionario = new(id, nome, cargo, salario);
                cadastro.AddFuncionario(funcionario);
            }
            Console.Clear();
            Console.WriteLine("Aqui está a lista de funcionários:\n");
            cadastro.ExibirFuncionarios();
            
        }
    }
}