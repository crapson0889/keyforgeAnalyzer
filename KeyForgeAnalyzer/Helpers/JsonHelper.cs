using System;
namespace KeyForgeAnalyzer.Helpers
{
    public static class JsonHelper
    {
        public static string GetJsonObject(this string body, string jsonIdentifier)
        {
            // Get data from page
            var start = body.IndexOf(jsonIdentifier, StringComparison.CurrentCulture);
            var end = start + 1;
            var bracketCount = 1;

            while (bracketCount != 0 || end > body.Length)
            {
                if (body[end] == '}')
                {
                    bracketCount--;
                }
                if (body[end] == '{')
                {
                    bracketCount++;
                }

                end++;
            }

            return body.Substring(start, end - start);
        }
    }
}
