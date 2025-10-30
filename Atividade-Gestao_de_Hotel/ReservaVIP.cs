
namespace Atividade_Gestao_de_Hotel
{
    public class ReservaVIP : Reserva
    {
         //*CRIANDO ATRIBUTO EXTRA
        public double Desconto {get; set;}

        //* CRIANDO CONSTRUTOR
        public ReservaVIP(Hospede HospedeConstrutor, Quarto QuartoConstrutor, int DiasConstrutor, double DescontoConstrutor) : base(HospedeConstrutor, QuartoConstrutor, DiasConstrutor) // ":base" -Forma de herdar construtores, colocando na ordem que foi colocado no construtor
        { 
            Desconto = DescontoConstrutor;
            // Não precisa escrever os outros construtores, pois já foi herdado exatamente da mesma forma
        }

        //* SOBSCREVENDO MÉTODOS
        public override double CalcularTotal()
        {
            double ValorSemDesconto = QuartoReserva.PrecoDiaria * Dias;
            double ValorComDesconto = ValorSemDesconto * (1 - (Desconto / 100)); // Valor sem desconto multiplicado pela porcentagem (em decimal) que sobrará após desconto
                                                                                 // O 1 serve como o número inteiro que após subtração sobrará apenas o decimal q precisa multiplicar para desconto
            return ValorComDesconto;
        }

        public override string ResumoReserva()
        {
            return
                $"\nReserva VIP de: {HospedeReserva.Nome}\nQuarto: {QuartoReserva.NumeroQuarto} ({QuartoReserva.TipoQuarto}) \nDesconto aplicado: {Desconto}%\nValor Total: {CalcularTotal():F2} por {Dias} dias.";
        }
    }
}