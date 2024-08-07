using HoteLLLBackend.Domain.Entities.Pessoas;
using System;

namespace HoteLLLBackend.Domain.Models.Pessoas
{
    public class PessoaNovaModel
    {
        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public DateTime DataNascimento { get; set; }

        public TipoCadastroPessoa TipoCadastro { get; set; }
    }
}
