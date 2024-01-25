using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionarios
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cargo { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string? nome, string? cargo, double salario) 
        {
            Id = id;
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }

        public override string ToString()
        {
            return $"Id: {Id}, nome: {Nome}, cargo: {Cargo}, salário: {Salario}.";
        }
    }
}
