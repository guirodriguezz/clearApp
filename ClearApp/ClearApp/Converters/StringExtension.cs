using System.Linq;

namespace clearApp.Extensions
{
    public static class StringExtension
    {
        public static string OnlyNumbers(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return null;

            return new string(text.Where(char.IsDigit).ToArray());
        }
    }
}
