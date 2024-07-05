using System.Collections.Generic;

namespace CookiesCookbook.Repositories.Strings
{
    public interface IStringsRepository
    {
        List<string> Read(string filePath);
        void Write(string filePath, List<string> strings);
    }
}
