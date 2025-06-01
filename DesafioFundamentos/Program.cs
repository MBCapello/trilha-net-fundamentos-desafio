using DesafioFundamentos.Models;
using System.Globalization;
using System;
using System.Threading;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.ForegroundColor = ConsoleColor.Green;

string[] logo = new string[]
{
    @"                                         ",
    @"                                         ",
    @"                                         ",
    @" ██████  ██████   █████  ██████  ██   ██ ",
    @"██       ██   ██ ██   ██ ██   ██ ██  ██  ",
    @"██       ██████  ███████ ██████  █████   ",
    @"██       ██      ██   ██ ██   ██ ██   ██  ",
    @" ██████  ██      ██   ██ ██   ██ ██   ██  ",
    @"                                         ",
    @"     🚘 Bem-vindo ao sistema CPark",
    @"O estacionamento onde o código nunca dá ré 😎"
};

foreach (string linha in logo)
{
    Console.WriteLine(linha);
    Thread.Sleep(150);
}

Console.ResetColor();
Thread.Sleep(800);
Console.WriteLine("\nPressione qualquer tecla para iniciar...");
Console.ReadKey();

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

// Validação do preço inicial
Console.ForegroundColor = ConsoleColor.Yellow;
while (true)
{
    Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\nDigite o preço inicial:");
    string input = Console.ReadLine().Replace(',', '.');
    if (decimal.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out precoInicial) && precoInicial >= 0)
        break;
    Console.WriteLine("Valor inválido! Digite um número decimal maior ou igual a zero.");
}

// Validação do preço por hora
while (true)
{
    Console.WriteLine("Agora digite o preço por hora:");
    string input = Console.ReadLine().Replace(',', '.');
    if (decimal.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out precoPorHora) && precoPorHora >= 0)
        break;
    Console.WriteLine("Valor inválido! Digite um número decimal maior ou igual a zero.");
}

Console.ResetColor();

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

static void Encerramento()
{
    Console.Clear();
    string[] frases = new string[]
    {
            "Encerrando o CPark...",
            "Desligando motores 🚗💨",
            "Estacionamento fechado.",
            "Obrigado por usar o CPark!",
            "Até a próxima!"
    };

    foreach (var frase in frases)
    {
        Console.WriteLine(frase);
        Thread.Sleep(1200);
    }
}
Encerramento();
Console.WriteLine("O programa se encerrou");
