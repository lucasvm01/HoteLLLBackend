using HoteLLLBackend.Domain.Models.Pessoas;

namespace HoteLLLBackend.Domain.Entities.Pessoas
{
    public partial class Pessoa
    {
        public void EditarPessoa(PessoaEdicaoModel model)
        {
            Email = model.Email;
            Telefone = model.Telefone;
            TipoCadastro = model.TipoCadastro;
        }

        public void AtivarPessoa()
        {
            IsAtiva = true;
        }

        public void InativarPessoa()
        {
            IsAtiva = false;
        }

    }
}
