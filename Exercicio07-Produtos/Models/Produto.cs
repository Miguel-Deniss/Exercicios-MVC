namespace Exercicio07_Produtos.Models;

public class Produto
{
    public Id int { get; set; }
    public Nome string { get; set; }
    public Categoria string { get; set; }
    public Estoque int { get; set; }
    public Preco decimal { get; set; }
}