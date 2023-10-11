using metodos_funcoes.Entidades;
using metodos_funcoes.Validacoes;

namespace metodos_funcoes.Servicos
{
    public class ProdutoService
    {
        public ProdutoService()
        {
            Produtos = new();
        }

        private List<Produto> Produtos { get; set; }

        public void CadastrarProdutosEmLote(params Produto[] produtos)
        {
            for (int i = 0; i < produtos.Length; i++)
                CadastrarProduto(produtos[i]);
        }

        public Produto BuscaProdutoPeloID(int ID)
        {
            if (ID <= 0)
                return new(0, string.Empty, 0);
            return Produtos.FirstOrDefault(produto => produto.ID == ID);
        }


        private void CadastrarProduto(Produto produto)
        {
            ProdutoValidacoes validacoes = new();
            if (validacoes.ProdutoEhValido(produto))
                Produtos.Add(produto);
        }
    }
}