namespace Exercicio10_Eletronicos.Models;

public class Eletronico
{
    public Id int { get; set; }
    public Nome string { get; set; }
    public Marca string { get; set; }
    public Categoria string { get; set; }
    public Preco decimal { get; set; }
    public Estoque int { get; set; }
}