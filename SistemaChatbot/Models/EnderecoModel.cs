namespace SistemaChatbot.Models
{
    public class EnderecoModel
    {
        public string Cep { get; set; } = string.Empty;
        public string Logradouro { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Localidade { get; set; } = string.Empty; // Cidade
        public string Uf { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty; // Campo incremental extra
    }
}