using HoteLLLBackend.Domain.Entities.Pessoas;
using HoteLLLBackend.Infra.Data;
using MediatR;

namespace HoteLLLBackend.Application.Pessoas.Queries.GetPessoa
{
    public class GetPessoaQuery : IRequest<GetPessoaDto>
    {
        public long PessoaId { get; set; }
    }

    public class GetPessoaQueryHandler(ApplicationDbContext context) : IRequestHandler<GetPessoaQuery, GetPessoaDto>
    {

        public async Task<GetPessoaDto> Handle(GetPessoaQuery request,CancellationToken cancellationToken)
        {
            var pessoa = await context.FindAsync<Pessoa>(request.PessoaId, cancellationToken);

            var pessoaDto = new GetPessoaDto
            {
                Nome = pessoa.Nome,
                CPF = pessoa.CPF,
                Email = pessoa.Email,
                Telefone = pessoa.Telefone,
                DataNascimento = pessoa.DataNascimento,
                TipoCadastro = pessoa.TipoCadastro,
                DataRegistro = pessoa.DataRegistro,
                IsAtiva = pessoa.IsAtiva,
            };

            return pessoaDto;
        }
    }
}
