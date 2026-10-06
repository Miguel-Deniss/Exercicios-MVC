namespace Exercicio13_SistemaPedidos.Models;

public class Pedido
{
    public Id int { get; set; }
    public Cliente string { get; set; }
    public Produto string { get; set; }
    public Quantidade int { get; set; }
    public PrecoUnitario decimal { get; set; }
    public Status string { get; set; }
    public Total decimal { get; set; }
}