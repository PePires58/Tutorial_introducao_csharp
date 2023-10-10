namespace controle_fluxo
{
    public class Produto
    {
        public Produto(string nome)
        {
            Nome = nome;

        }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}