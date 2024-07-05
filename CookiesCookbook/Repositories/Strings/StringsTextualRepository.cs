using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CookiesCookbook.Repositories.Strings
{
    public class StringsTextualRepository : IStringsRepository
    {
        private static readonly string Separator = Environment.NewLine;

        public List<string> Read(string filePath)
        {
            if (File.Exists(filePath))
            {
                var fileContents = File.ReadAllText(filePath);
                return fileContents.Split(new string[] { Separator }, StringSplitOptions.None).ToList();
            }
            return new List<string>(); 
        }

        public void Write(string filePath, List<string> strings)
        {
            File.WriteAllText(filePath, string.Join(Separator, strings));
        }
    }
}
