using HoteLLLBackend.Domain.Models.Reservas;
using HoteLLLBackend.Domain.Entities.Pessoas;
using HoteLLLBackend.Domain.Entities.Quartos;

namespace HoteLLLBackend.Domain.Entities.Hospedagens
{
    public partial class Hospedagem
    {
        public Hospedagem(HospedagemNovaModel model)
        {
            DataReserva = model.DataReserva;
            IsAtiva = model.IsAtiva;
        }

        private Hospedagem()
        {
            // Necessário para o EntityFramework
        }

        public DateTime? DataReserva { get; private set; }

        public bool IsAtiva { get; private set; }

        public long FuncionarioId { get; private set; }

        public IReadOnlyCollection<Pessoa> Hospedes => _hospedes.AsReadOnly();
        private readonly List<Pessoa> _hospedes = new();

        public IReadOnlyCollection<Quarto> Quartos => _quartos.AsReadOnly();
        private readonly List<Quarto> _quartos = new();
    }
}
