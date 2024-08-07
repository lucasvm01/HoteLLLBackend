using HoteLLLBackend.Domain.Entities.Pessoas;
using System;

namespace HoteLLLBackend.Domain.Models.Pessoas
{
    public class PessoaEdicaoModel
    {
        public string Email { get; set; }

        public string Telefone { get; set; }

        public TipoCadastroPessoa TipoCadastro { get; set; }
    }
}
