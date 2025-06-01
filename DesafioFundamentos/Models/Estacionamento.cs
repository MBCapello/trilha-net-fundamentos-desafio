using System.Globalization;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<(string placa, DateTime dataHoraEntrada)> veiculos = new();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        private bool VerificarSeVeiculoJaEstaEstacionado(string placa)
        {
            return veiculos.Any(v => v.placa.Equals(placa, StringComparison.OrdinalIgnoreCase));
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            // Verifica se a placa é válida
            if (string.IsNullOrWhiteSpace(placa) || !placa.All(c => char.IsLetterOrDigit(c) || c == '-'))
            {
                Console.WriteLine("Placa inválida. Por favor, insira uma placa válida.A placa deve conter apenas letras, números e hífens.");
                return;
            }

            // Verifica se a placa já está cadastrada
            if (VerificarSeVeiculoJaEstaEstacionado(placa))
            {
                Console.WriteLine("Desculpe, esse veículo já está estacionado aqui.");
            }
            else
            {
                // Adiciona a placa à lista de veículos
                veiculos.Add((placa, DateTime.Now));
                Console.WriteLine($"O veículo com placa {placa} foi adicionado com sucesso em {veiculos.Last().dataHoraEntrada.ToString("dd/MM/yyyy HH:mm")}");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (!VerificarSeVeiculoJaEstaEstacionado(placa))
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                return;
            }

            // Se o veículo existe, solicita o tempo de estadia
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            string tempoEstacionado = Console.ReadLine();

            // Tenta converter o tempo de estadia para inteiro
            if (!decimal.TryParse(tempoEstacionado.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal horasDecimal) || horasDecimal < 0)
            {
                Console.WriteLine("Tempo estacionado inválido. Por favor, insira um número válido e/ou positivo de horas. \nExemplo: 2.5 para 2 horas e 50 minutos ou 3 para 3 horas.");
                return;
            }

            // Calcula o valor total a pagar
            int horas = (int)Math.Ceiling(horasDecimal);    // Arredonda para cima as horas
            decimal valorTotal = precoInicial + (precoPorHora * horas);
            // Remove o veículo da lista
            veiculos.RemoveAll(v => v.placa.Equals(placa, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"O veículo {placa} foi removido e o preço total a pagar é de: R$ {valorTotal}");
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"Veículo placa - {veiculo.placa} (estacionado desde {veiculo.dataHoraEntrada.ToString("dd/MM/yyyy HH:mm")})");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
