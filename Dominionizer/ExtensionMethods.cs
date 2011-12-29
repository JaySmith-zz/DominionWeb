namespace Dominionizer
{
    using System.Text.RegularExpressions;

    public static class ExtensionMethods
    {
        public static string CamelCaseToProperSpace(string value)
        {
            return Regex.Replace(value, "([A-Z]{1,2}|[0-9]+)", " $1").TrimStart();
        }
    }
}