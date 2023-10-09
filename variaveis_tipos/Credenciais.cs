public class Credenciais
{

    /// <summary>
    /// Construtor para se criar uma credêncial
    /// </summary>
    /// <param name="email">E-mail utilizado para login</param>
    /// <param name="senha">Senha utilziada para login</param>
    public Credenciais(string email, string senha)
    {
        Email = email;
        Senha = senha;
    }

    /// <summary>
    /// E-mail utilizado para o login
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Senha utilizada para o login
    /// </summary>
    public string Senha { get; set; }
}