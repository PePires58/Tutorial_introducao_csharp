Credenciais credenciais = new()
{
    Email = "123@gmail.com",
    Senha = "pedrao123"
};

Credenciais credenciaisBancoDados = new()
{
    Email = "123@gmail.com",
    Senha = "pedrao123"
};

bool usuarioPodeLogar = credenciaisBancoDados.Email == credenciais.Email &&
    credenciaisBancoDados.Senha == credenciais.Senha;

Console.WriteLine(usuarioPodeLogar);