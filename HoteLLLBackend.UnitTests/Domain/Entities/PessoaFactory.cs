using HoteLLLBackend.Domain.Entities.Pessoas;
using HoteLLLBackend.Domain.Models.Pessoas;

namespace HoteLLLBackend.UnitTests.Domain.Entities
{
    public static class PessoaFactory
    {
        public static PessoaNovaModel GetPessoaNovaModel()
        {
            return new()
            {
                Nome = "Lucas",
                CPF = "12345678911",
                Email = "lucasvm01@gmail.com",
                Telefone = "41991299119",
                TipoCadastro = TipoCadastroPessoa.Cliente,
                DataNascimento = DateTime.Now,
            };
        }
    }
}
