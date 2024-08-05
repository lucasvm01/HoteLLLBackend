using HoteLLLBackend.Domain.Models.Quartos;

namespace HoteLLLBackend.Domain.Entities.Quartos
{
    public partial class Quarto
    {
        public Quarto(QuartoNovoModel model)
        {
            Tamanho = model.Tamanho;
            IsOcupado = model.IsOcupado;
        }


        private Quarto()
        {
            // Necessário para o EntityFramework
        }

        public int Tamanho { get; private set; }

        public bool IsOcupado { get; private set; }

        public bool IsReservado { get; private set; }
    }
}
