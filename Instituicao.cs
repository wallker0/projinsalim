namespace ProjetoInsegurancaAlimentar.Models;

public class Instituicao
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public List<Programa> Programas { get; set; }
}
