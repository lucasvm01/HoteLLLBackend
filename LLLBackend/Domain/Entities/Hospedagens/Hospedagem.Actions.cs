using HoteLLLBackend.Domain.Models.Pessoas;
using HoteLLLBackend.Domain.Models.Quartos;
using HoteLLLBackend.Domain.Entities.Pessoas;
using HoteLLLBackend.Domain.Entities.Quartos;

namespace HoteLLLBackend.Domain.Entities.Hospedagens
{
    public partial class Hospedagem
    {
        //public void EditarHospedagem()
        //{

        //}

        //public Hospedagem CriarReserva(ReservaNovaModel model)
        //{

        //}

        //public Hospedagem EditarReserva()
        //{

        //}

        //public bool CheckIn()
        //{

        //}

        //public bool CancelarHospedagem()
        //{

        //}

        //public bool CheckOut()
        //{

        //}

        //public Pessoa AdicionarHospede(PessoaModel model)
        //{
        //    var hospede = new Pessoa(model);
        //    _hospedes.Add(hospede);

        //    return hospede;
        //}

        //private void RemoverHospede(long pessoaId)
        //{
        //    var hospedeRemover = Hospedes.First(h => h. == pessoaId);
        //}

        private Quarto AdicionarQuarto(QuartoNovoModel model)
        {
            var quarto = new Quarto(model);
            _quartos.Add(quarto);

            return quarto;
        }

        private void RemoverQuarto(long QuartoId)
        {
            var quartoRemover = Quartos.First();
        }

    }
}
