namespace Exercicio14_SistemaCursos.Models;

public class Curso
{
    public Id int { get; set; }
    public Nome string { get; set; }
    public CargaHoraria int { get; set; }
    public Modalidade string { get; set; }
    public Vagas int { get; set; }
    public Valor decimal { get; set; }
}