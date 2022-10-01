using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa cliente1 = new Pessoa(nome: "Carlos Henrique");
Pessoa cliente2 = new Pessoa(nome: "Fernanda Souza");

hospedes.Add(cliente1);
hospedes.Add(cliente2);

// Cria a suíte
Suite suitePremium = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 130);


// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suitePremium);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");