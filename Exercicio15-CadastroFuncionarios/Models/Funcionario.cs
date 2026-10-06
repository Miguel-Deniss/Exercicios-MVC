namespace Exercicio15_CadastroFuncionarios.Models;

public class Funcionario
{
    public Id int { get; set; }
    public Nome string { get; set; }
    public Cargo string { get; set; }
    public Departamento string { get; set; }
    public Salario decimal { get; set; }
    public Ativo bool { get; set; }
}