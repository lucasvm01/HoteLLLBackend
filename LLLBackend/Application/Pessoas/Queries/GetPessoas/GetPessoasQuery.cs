using HoteLLLBackend.Application.Pessoas.Queries.GetPessoa;
using HoteLLLBackend.Domain.Interfaces;
using HoteLLLBackend.Infra.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace HoteLLLBackend.Application.Pessoas.Queries.GetPessoas
{
    public class GetPessoasQuery : IRequest<List<GetPessoaDto>>
    {
    }

    public class GetPessoasQueryHandler(ApplicationDbContext context) : IRequestHandler<GetPessoasQuery, List<GetPessoaDto>>
    {
        public async Task<List<GetPessoaDto>> Handle(GetPessoasQuery request, CancellationToken cancellationToken)
        {
            var pessoas = await context.Pessoas.ToListAsync(cancellationToken);

            var pessoasDto = new List<GetPessoaDto>();

            foreach (var pessoa in pessoas)
            {
                pessoasDto.Add(new GetPessoaDto{
                    Nome = pessoa.Nome,
                    CPF = pessoa.CPF,
                    Email = pessoa.Email,
                    Telefone = pessoa.Telefone,
                    DataNascimento =  pessoa.DataNascimento,
                    TipoCadastro = pessoa.TipoCadastro,
                    DataRegistro = pessoa.DataRegistro,
                    IsAtiva = pessoa.IsAtiva,
                });
            }

            return pessoasDto;
        }
    }
}
