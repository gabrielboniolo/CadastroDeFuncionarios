namespace CadastroFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Bem-vindo ao Sistema de Cadastro de Funcionários -----\n");
            Console.Write("Aperte qualquer tecla para começar ");
            Console.ReadKey();

            try
            {
                Cadastro cadastro = new();
                Operacoes.NovoFuncionario(cadastro);
                Operacoes.MenuCrud(cadastro);
            }

            catch (Exception ex)
            {
                Console.Write($"Ocorreu um erro: {ex.Message}");
                Console.ReadKey();
            }
            
            
        }
    }
}