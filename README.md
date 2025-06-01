# 🚗 CPark - Sistema de Estacionamento

Projeto desenvolvido como parte do **Desafio de Fundamentos da Trilha .NET da DIO**.  
Um sistema de estacionamento simples, interativo e funcional — com direito a animação ASCII e validações robustas.

---

## 📜 Descrição

O **CPark** é um sistema de terminal que simula o funcionamento de um estacionamento, permitindo:

- ✅ Cadastrar veículos
- ✅ Remover veículos com cálculo de cobrança
- ✅ Listar veículos estacionados
- ✅ Interface amigável com validações e mensagens interativas

---

## 📋 Requisitos Atendidos

### ✔️ Menu interativo com as opções:

- Cadastrar veículo
- Remover veículo
- Listar veículos
- Encerrar

### ✔️ Classe `Estacionamento` com os atributos e métodos:

- `precoInicial: decimal` — valor fixo inicial cobrado
- `precoPorHora: decimal` — valor por hora adicional
- `veiculos: List<(string placa, DateTime dataHoraEntrada)>` — armazena placa e hora da entrada

### ✔️ Métodos implementados:

- `AdicionarVeiculo()` — adiciona veículo com validação de placa
- `RemoverVeiculo()` — calcula valor com base no tempo informado
- `ListarVeiculos()` — exibe placas e horário de entrada

### ✔️ Validações:

- Entrada de valores decimais com cultura `InvariantCulture`
- Checagem de placas duplicadas
- Verificação de placas malformadas
- Cálculo com arredondamento de horas (sempre para cima)

---

## 💻 Tecnologias

- C#
- .NET Console App
- .NET SDK 6.0+ ou superior
- UTF-8 Encoding + ConsoleColor para experiência interativa

---

## 🧩 Execução

### Requisitos:

- .NET SDK instalado (versão 6.0 ou superior)
- Editor de código (Visual Studio, VS Code, JetBrains Rider etc.)

### Clonar o projeto:

```bash
git clone https://github.com/MBCapello/trilha-net-fundamentos-desafio
cd trilha-net-fundamentos-desafio/DesafioFundamentos
```

### Compilar e executar:

```bash
dotnet run
```

---

## 🧠 Extras e Diferenciais

- 🎨 Animação em ASCII no início
- 🧪 Validações robustas de entrada
- 🕒 Registro de data e hora da entrada
- 🔁 Arredondamento automático das horas para cálculo
- 🧹 Encerramento animado e amigável
- 🇧🇷 Suporte a acentuação (UTF-8)

---

## 📷 Demonstração (CLI)

```bash
 ██████  ██████   █████  ██████  ██   ██ 
██       ██   ██ ██   ██ ██   ██ ██  ██  
██       ██████  ███████ ██████  █████  
██       ██      ██   ██ ██   ██ ██   ██ 
 ██████  ██      ██   ██ ██   ██ ██   ██ 
     🚘 Bem-vindo ao sistema CPark
O estacionamento onde o código nunca dá ré 😎
```

---

## 📁 Estrutura

```bash
DesafioFundamentos/
│
├── Program.cs                 # Interface e controle do menu
├── Models/
│   └── Estacionamento.cs     # Lógica principal do sistema
├── README.md                 # Documentação do projeto
├── .gitignore                # Arquivos ignorados pelo git
```

---

## 🧑‍💻 Autor

Desenvolvido por **Marcelo Capello**  
GitHub: [@MBCapello](https://github.com/MBCapello)

---

## 🏁 Considerações Finais

Este projeto consolida os conhecimentos fundamentais em C#, estrutura de classes, listas genéricas, entrada/saída de dados e lógica de programação.  
Ideal para quem está começando na trilha .NET!
