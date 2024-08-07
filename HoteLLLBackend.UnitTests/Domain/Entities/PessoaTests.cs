using FluentAssertions;
using HoteLLLBackend.Domain.Entities.Pessoas;

namespace HoteLLLBackend.UnitTests.Domain.Entities
{
    public class Tests
    {

        [Test]
        public void DeveCadastrarPessoaComSucesso()
        {
            var model = PessoaFactory.GetPessoaNovaModel();

            var pessoa = new Pessoa(model);

            pessoa.Should().BeEquivalentTo(
                model,
                opt => opt.ExcludingMissingMembers()
            );
            pessoa.IsAtiva.Should().BeTrue();
            pessoa.Nome.Should().Be("Lucas");
        }
    }
}