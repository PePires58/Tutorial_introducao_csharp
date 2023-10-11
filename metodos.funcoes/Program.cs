using metodos_funcoes.Entidades;
using metodos_funcoes.Servicos;

ProdutoService produtoService = new();

List<Produto> produtosParaAdicionar = new();

for (int i = 0; i < 10; i++)
{
    int idProduto = i + 1;
    produtosParaAdicionar.Add(new(idProduto, $"Produto {idProduto}", idProduto * 25));
}

produtoService.CadastrarProdutosEmLote(produtosParaAdicionar.ToArray());

Produto produtoConsultado = produtoService.BuscaProdutoPeloID(5);

produtoConsultado.ImprimirDados();


