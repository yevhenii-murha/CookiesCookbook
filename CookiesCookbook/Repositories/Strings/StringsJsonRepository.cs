using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CookiesCookbook.Repositories.Strings
{
    public class StringsJsonRepository : IStringsRepository
    {
        public List<string> Read(string filePath)
        {
            if (File.Exists(filePath))
            {
                var fileContents = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<string>>(fileContents);
            }
            return new List<string>();
        }

        public void Write(string filePath, List<string> strings)
        {
            File.WriteAllText(filePath, JsonSerializer.Serialize(strings));
        }
    }
}
