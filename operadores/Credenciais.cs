public class Credenciais
{
    public Credenciais()
    {
        Email = string.Empty;
        Senha = string.Empty;
    }

    public Credenciais(string email, string senha)
    {
        Email = email;
        Senha = senha;
    }

    public string Email { get; set; }
    public string Senha { get; set; }
}