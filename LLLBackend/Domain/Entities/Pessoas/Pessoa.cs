using HoteLLLBackend.Domain.Models.Pessoas;

namespace HoteLLLBackend.Domain.Entities.Pessoas
{
    public partial class Pessoa
    {
        public Pessoa(PessoaNovaModel model)
        { 
            Nome = model.Nome;
            CPF = model.CPF;
            Email = model.Email;
            Telefone = model.Telefone;
            DataNascimento = model.DataNascimento;
            TipoCadastro = new TipoCadastroPessoa(model.TipoCadastro);
            DataRegistro = DateTime.Now;
        }
        
        private Pessoa()
        { 
            // Necessário para o EntityFramework
        }

        public string Nome { get; private set; }

        public string CPF {  get; private set; }

        public string Email { get; private set; }

        public string Telefone { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public TipoCadastroPessoa TipoCadastro { get; private set; }

        public DateTime DataRegistro { get; private set; }
    }
}
