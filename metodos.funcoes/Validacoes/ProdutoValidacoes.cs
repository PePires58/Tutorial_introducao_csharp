using metodos_funcoes.Entidades;

namespace metodos_funcoes.Validacoes
{
    public class ProdutoValidacoes
    {
        public bool ProdutoEhValido(Produto produto)
        {
            if (produto.ID <= 0)
                return false;
            if (string.IsNullOrEmpty(produto.Nome))
                return false;
            if (produto.Valor < 0)
                return false;

            return true;
        }
    }
}