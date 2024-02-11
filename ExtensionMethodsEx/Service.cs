using System.Globalization;

namespace ExtensionMethodsEx
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> DistinctByCustom<T, TKey>(this IEnumerable<T> source, Func<T, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (T element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }
        public static string ToTitleCase(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            return char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }

        public static string ToTitleCaseNew(this string s) 
            => CultureInfo.InvariantCulture.TextInfo.ToTitleCase(s.ToLower());
    }
}
