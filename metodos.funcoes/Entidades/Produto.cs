namespace metodos_funcoes.Entidades
{
    public class Produto
    {
        public Produto(int id, string nome, decimal valor)
        {
            ID = id;
            Nome = nome;
            Valor = valor;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine($"ID do produto: {ID}");
            Console.WriteLine($"Nome do produto: {Nome}");
            Console.WriteLine($"Valor do produto: {Valor}");
            Console.WriteLine("=================");
        }
    }
}