using HoteLLLBackend.Domain.Models.Pessoas;

namespace LLLBackend.Domain.Entities.Pessoas
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
            DataRegistro = DateTime.Now;        
        }
        
        public Pessoa()
        { 
            // Necessário para o EntityFramework
        }

        public string Nome { get; set; }

        public string CPF {  get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public DateTime DataNascimento { get; set; }

        public DateTime DataRegistro { get; set; }
    }
}
