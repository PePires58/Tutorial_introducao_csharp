/*
    1 - Falar com atendente
    2 - Cancelar plano
    3 - Contratar plano
    qualquer outra - opção não encontrada
*/

string opcaoEscolhida = "2";

switch (opcaoEscolhida)
{
    case "1":
        Console.WriteLine("Falar com atendente");
        break;
    case "2":
        Console.WriteLine("Cancelar plano");
        break;
    case "3":
        Console.WriteLine("Contratar plano");
        break;
    default:
        Console.WriteLine("Opção não encontrada");
        break;
}