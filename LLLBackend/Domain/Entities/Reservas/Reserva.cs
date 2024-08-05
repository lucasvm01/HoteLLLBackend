using LLLBackend.Domain.Entities.Pessoas;
using LLLBackend.Domain.Entities.Quartos;

namespace HoteLLLBackend.Domain.Entities.Reservas
{
    public partial class Reserva
    {
        public Reserva()
        {
            // Necessário para o EntityFramework
        }

        public DateTime DataHospedagem {  get; set; }

        public IReadOnlyCollection<Pessoa> Hospedes => _hospedes.AsReadOnly();
        private readonly List<Pessoa> _hospedes = new();

        public IReadOnlyCollection<Quarto> Quartos => _quartos.AsReadOnly();
        private readonly List<Quarto> _quartos = new();
    }
}
