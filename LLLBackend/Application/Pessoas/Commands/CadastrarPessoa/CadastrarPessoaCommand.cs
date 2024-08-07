using HoteLLLBackend.Domain.Entities.Pessoas;
using HoteLLLBackend.Domain.Models.Pessoas;
using HoteLLLBackend.Infra.Data;
using MediatR;

namespace HoteLLLBackend.Application.Pessoas.Commands.CadastrarPessoa
{
    public class CadastrarPessoaCommand : IRequest<Pessoa>
    {
        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public DateTime DataNascimento { get; set; }

        public TipoCadastroPessoa TipoCadastro { get; set; }
    }

    public class CadastrarPessoaCommandHandler(ApplicationDbContext context) : IRequestHandler<CadastrarPessoaCommand, Pessoa>
    {
        public async Task<Pessoa> Handle(CadastrarPessoaCommand request, CancellationToken cancellationToken)
        {
            var model = new PessoaNovaModel
            {
                Nome = request.Nome,
                CPF = request.CPF,
                Email = request.Email,
                Telefone = request.Telefone,
                DataNascimento = request.DataNascimento,
                TipoCadastro = request.TipoCadastro,
            };

            var pessoaCadastrada = new Pessoa(model);

            await context.AddAsync(pessoaCadastrada);

            await context.SaveChangesAsync();

            return pessoaCadastrada;
        }
    }
}
