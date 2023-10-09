internal class Pessoa
{
    string _nome;
    string _sobrenome;

    public Pessoa(string nome, string sobrenome)
    {
        _nome = nome;
        _sobrenome = sobrenome;
    }

    public string NomeCompleto => string.Format("{0} {1}", _nome, _sobrenome);
}