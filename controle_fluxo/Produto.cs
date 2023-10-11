namespace controle_fluxo
{
    internal class Produto
    {
        internal Produto(string nome)
        {
            Nome = nome;

        }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}