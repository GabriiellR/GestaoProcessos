using System.ComponentModel;

namespace GestaoProcessos.Infraestrutura.CrossCutting.Extensions
{
    public static class EnumExtensions
    {
        //Obtem a descrição de um enumerador.
        public static string GetDescription(this Enum value)
        {
            var array = (DescriptionAttribute[])value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (array.Length == 0)
            {
                return value.ToString();
            }

            return array[0].Description;
        }
    }
}
