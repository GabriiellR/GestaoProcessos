namespace GestaoProcessos.Infraestrutura.CrossCutting.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNull(this string? value)
        {
            return string.IsNullOrEmpty(value);
        }
        public static bool IsNotNull(this string? value)
        {
            return !string.IsNullOrEmpty(value);
        }
    }
}