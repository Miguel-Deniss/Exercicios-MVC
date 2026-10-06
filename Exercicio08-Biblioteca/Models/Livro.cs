namespace Exercicio08_Biblioteca.Models;

public class Livro
{
    public Id int { get; set; }
    public Titulo string { get; set; }
    public Autor string { get; set; }
    public Ano int { get; set; }
    public Disponivel bool { get; set; }
}