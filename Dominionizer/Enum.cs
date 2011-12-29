namespace Dominionizer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Enum<T>
    {
        public static IEnumerable<string> GetNames()
        {
            var type = typeof(T);

            if (!type.IsEnum)
                throw new ArgumentException(String.Format("Type '{0}' is not an enum", type.Name));

            return (from field in type.GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)
                    where field.IsLiteral
                    select field.Name).ToList();
        }
    }
}