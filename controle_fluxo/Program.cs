using controle_fluxo;

Produto[] produtos = new Produto[] {
    new("Produto 1"){
        Ativo = true
    },
    new("Produto 2"){
        Ativo = false
    },
    new("Produto 3"){
        Ativo = false
    },
    new("Produto 4"){
        Ativo = true
    }
};

Produto[] produtosAtivos = new Produto[produtos.Length];

for (int i = 0; i < produtos.Length; i++)
{
    if (produtos[i].Ativo)
    {
        produtosAtivos[i] = produtos[i];
    }
    Console.WriteLine($"Nome: {produtos[i].Nome} - Ativo: {produtos[i].Ativo}");
}

int quantidadeProdutosAtivos = 0;
for (int i = 0; i < produtosAtivos.Length; i++)
{
    if (produtosAtivos[i] != null && produtosAtivos[i].Ativo)
        quantidadeProdutosAtivos++;
}

Console.WriteLine(quantidadeProdutosAtivos);
