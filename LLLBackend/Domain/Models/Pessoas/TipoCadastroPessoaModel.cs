namespace HoteLLLBackend.Domain.Models.Pessoas
{
    public class TipoCadastroPessoaModel
    {
        public bool IsCliente { get; set; }

        public bool IsFornecedor { get; set; }

        public bool IsFuncionario { get; set; }

        public bool IsTecnico { get; set; }
    }
}
