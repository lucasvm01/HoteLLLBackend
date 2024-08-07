using HoteLLLBackend.Domain.Models.Quartos;

namespace HoteLLLBackend.Domain.Entities.Quartos
{
    public partial class Quarto : BaseEntity<long>
    {
        public Quarto(QuartoNovoModel model)
        {
            Tamanho = model.Tamanho;
            IsOcupado = false;
            IsReservado = false;
            IsAtivo = true;
        }


        private Quarto()
        {
            // Necessário para o EntityFramework
        }

        public TamanhoQuarto Tamanho { get; private set; }

        public bool IsOcupado { get; private set; }

        public bool IsReservado { get; private set; }

        public bool IsAtivo { get; private set; }
    }
}
