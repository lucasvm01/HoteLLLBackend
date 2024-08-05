using HoteLLLBackend.Domain.Models.Quartos;

namespace LLLBackend.Domain.Entities.Quartos
{
    public partial class Quarto
    {
        public Quarto(QuartoNovoModel model)
        {

        }


        public Quarto()
        {
            // Necessário para o EntityFramework
        }

        public int Tamanho { get; set; }

        public bool IsOcupado { get; set; }
    }
}
