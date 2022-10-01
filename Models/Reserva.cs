namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Está suite não suporta a quantidade de hospedes desta reserva");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {   
            return Hospedes.Count();;
        }

        public decimal CalcularValorDiaria()
        {

            decimal valorDiaria = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valorDiaria = valorDiaria - (valorDiaria * 0.10M);
            }

           return valorDiaria;
        }
    }
}