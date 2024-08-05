using HoteLLLBackend.Domain.Models.Pessoas;

namespace HoteLLLBackend.Domain.Entities.Pessoas
{
    public class TipoCadastroPessoa
    {
        public TipoCadastroPessoa(TipoCadastroPessoaModel model)
        {

            IsCliente = model.IsCliente;
            IsFornecedor = model.IsFornecedor;
            IsFuncionario = model.IsFuncionario;
            IsTecnico = model.IsTecnico;
        }

        private TipoCadastroPessoa()
        {
        }

        public bool IsCliente { get; private set; }

        public bool IsFornecedor { get; private set; }

        public bool IsFuncionario { get; private set; }

        public bool IsTecnico { get; private set; }

    }
}
