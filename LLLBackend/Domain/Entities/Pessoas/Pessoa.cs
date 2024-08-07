using HoteLLLBackend.Domain.Entities.Hospedagens;
using HoteLLLBackend.Domain.Models.Pessoas;

namespace HoteLLLBackend.Domain.Entities.Pessoas
{
    public partial class Pessoa : BaseEntity<long>
    {
        public Pessoa(PessoaNovaModel model)
        { 
            Nome = model.Nome;
            CPF = model.CPF;
            Email = model.Email;
            Telefone = model.Telefone;
            DataNascimento = model.DataNascimento;
            TipoCadastro = model.TipoCadastro;
            DataRegistro = DateTime.Now;
            IsAtiva = true;
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

        public bool IsAtiva { get; private set; }

        public IReadOnlyCollection<Hospedagem> Hospedagens => _hospedagens.AsReadOnly();
        private readonly List<Hospedagem> _hospedagens = new();
    }
}
