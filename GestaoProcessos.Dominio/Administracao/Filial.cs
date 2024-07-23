namespace GestaoProcessos.Dominio.Administracao
{
    public class Filial : BaseModel
    {
        public string Nome { get; set; } = string.Empty;
        public string Logradouro { get; set;} = string.Empty;
        public string Bairro { get;set;} = string.Empty;
        public string Localidade { get; set;} = string.Empty;   
        public string UF { get; set;} = string.Empty;   
        public int Numero { get;set;}
        public string Cep { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public virtual List<Usuario>? Usuarios { get; set; }
    }
}
