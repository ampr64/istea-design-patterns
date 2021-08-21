using System.Linq;
using System.Text;

namespace BikeBuilder.ExtensionMethods
{
    public static class StringExtensions
    {
        public static string ToSentence(this string str) => str[1..].Aggregate(new StringBuilder($"{str[0]}"), (nameBuilder, current) =>
            nameBuilder.Append(char.IsUpper(current) ? $" {char.ToLower(current)}" : current),
            result => result.ToString());
    }
}