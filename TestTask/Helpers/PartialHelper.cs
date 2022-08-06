using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace TestTask.Helpers
{
    public static class PartialHelper
    {
        /// <summary>
        /// получает значения атрибута "Description"
        /// </summary>
        /// <typeparam name="TEnum">Тип перечесления</typeparam>
        /// <param name="EnumValue">Значение перечесления</param>
        public static string GetDescription<TEnum>(this TEnum EnumValue) where TEnum : struct
        {
            return EnumValue.GetType()
                        .GetMember(EnumValue.ToString())
                        .First()
                        .GetCustomAttribute<DescriptionAttribute>()?
                        .Description ?? string.Empty;
        }
    }
}
