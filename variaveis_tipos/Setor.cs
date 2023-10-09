public class Setor
{
    public int Numero { get; set; }

    private string? _nome;
    public string Nome
    {
        get
        {
            return string.IsNullOrEmpty(_nome) ? "Outros" : _nome;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
                _nome = string.Empty;
            else
            {
                if (value.Length > 50)
                    throw new ArgumentOutOfRangeException(nameof(value), "O nome do setor deve ter até 50 caracteres");

                _nome = value;
            }
        }
    }
}