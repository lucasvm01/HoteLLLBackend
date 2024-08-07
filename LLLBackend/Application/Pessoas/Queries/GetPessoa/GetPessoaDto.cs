using HoteLLLBackend.Domain.Entities.Pessoas;

namespace HoteLLLBackend.Application.Pessoas.Queries.GetPessoa
{
    public class GetPessoaDto
    {
        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public DateTime DataNascimento { get; set; }

        public TipoCadastroPessoa TipoCadastro { get; set; }

        public DateTime DataRegistro { get; set; }

        public bool IsAtiva { get; set; }
    }
}
