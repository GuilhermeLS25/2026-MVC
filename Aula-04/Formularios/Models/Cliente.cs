namespace MVC2026;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string UF { get; set; }
    public string CEP { get; set; }
    public string CPF { get; set; }
    public string Email { get; set; }
    public string Celular { get; set; }
    public DateOnly DataNascimento { get; set; }
    public string Observacao { get; set; }
}
