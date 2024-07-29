using System.ComponentModel;

namespace GestaoProcesso.Aprensentacao.Enumeradores
{
    public enum ResultType
    {
        [Description("Informações obtidas com sucesso.")]
        Get,

        [Description("Informações inseridas com sucesso.")]
        Post,

        [Description("Informações removidas com sucesso.")]
        Remove,

        [Description("Erro ao obter informações.")]
        ErrorGet,

        [Description("Erro ao inserir informações.")]
        ErrorPost,

        [Description("Erro ao remover informações.")]
        ErrorRemove
    }
}
