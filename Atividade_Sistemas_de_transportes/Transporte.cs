
namespace Atividade_Sistemas_de_transportes
{
    public abstract class Transporte
    {
        public abstract double CalcularTempoViagem();

        public string iniciarViagem()
        {
            return
                $"Viagem iniciada...";
        }
    }
}