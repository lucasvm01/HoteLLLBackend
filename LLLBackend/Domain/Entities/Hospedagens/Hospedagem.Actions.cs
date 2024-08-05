using HoteLLLBackend.Domain.Models.Pessoas;
using HoteLLLBackend.Domain.Models.Quartos;
using HoteLLLBackend.Domain.Entities.Pessoas;
using HoteLLLBackend.Domain.Entities.Quartos;

namespace HoteLLLBackend.Domain.Entities.Hospedagens
{
    public partial class Hospedagem
    {
        public Pessoa AdicionarHospede(PessoaNovaModel model)
        {
            var hospede = new Pessoa(model);
            _hospedes.Add(hospede);

            return hospede;
        }

        public void RemoverHospede(long pessoaId)
        {
            var hospedeRemover = Hospedes.First(h => h. == pessoaId);
        }

        public Quarto AdicionarQuarto(QuartoNovoModel model)
        {
            var quarto = new Quarto(model);
            _quartos.Add(quarto);

            return quarto;
        }
    }
}
