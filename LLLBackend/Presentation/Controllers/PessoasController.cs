using HoteLLLBackend.Application.Pessoas.Commands.CadastrarPessoa;
using HoteLLLBackend.Application.Pessoas.Queries.GetPessoa;
using HoteLLLBackend.Application.Pessoas.Queries.GetPessoas;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace HoteLLLBackend.Presentation.Controllers;

public class PessoasController : ApiController
{
    [HttpPost]
    [SwaggerOperation("Cadastra uma nova pessoa.")]
    public async Task<IResult> PostCadastrarPessoaAsync([FromBody] CadastrarPessoaCommand command)
    {
        var result = await Mediator.Send(command);
        return Results.Created("pessoa/", result);
    }

    [HttpGet("{pessoaId:long}")]
    [SwaggerOperation("Retorna a pessoa pelo identificador.")]
    public async Task<ActionResult> GetPessoaAsync([FromRoute] GetPessoaQuery query)
    {
        var pessoa = await Mediator.Send(query);
        return Ok(pessoa);
    }

    [HttpGet]
    [SwaggerOperation("Retorna todas as pessoas.")]
    public async Task<ActionResult> GetPessoasAsync([FromRoute] GetPessoasQuery query)
    {
        var pessoas = await Mediator.Send(query);
        return Ok(pessoas);
    }
}
