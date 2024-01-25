namespace CadastroFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Bem-vindo ao Sistema de Cadastro de Funcionários -----\n");

            int qtdFuncionarios = Operacoes.ObterQuantidadeFuncionarios();

            Cadastro cadastro = new();
            
            for(int i = 1; i <= qtdFuncionarios; i++)
            {
                cadastro.AddFuncionario(Operacoes.PreencherFuncionario(i));
            }

            cadastro.ExibirFuncionarios();   
        }
    }
}