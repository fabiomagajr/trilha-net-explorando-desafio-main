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
            if (hospedes.Count > Suite.Capacidade){
                Console.WriteLine("Quantidade excedida de hospedes.");
            }
            else
            {
                Hospedes = hospedes;
            }
           
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            Console.WriteLine($"Quantidade de hospedes: {Suite.Capacidade}");
            return 0;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = 0;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (true)
            {
                valor = 0;
            }

            return valor;
        }
    }
}