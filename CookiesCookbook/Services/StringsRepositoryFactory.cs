using CookiesCookbook.Repositories.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook.Services
{
    public static class StringsRepositoryFactory
    {
        public static IStringsRepository CreateRepository(FileFormat format)
        {
            switch (format)
            {
                case FileFormat.Json:
                    return new StringsJsonRepository();
                case FileFormat.Txt:
                    return new StringsTextualRepository();
                default:
                    throw new NotSupportedException("Unsupported file format");
            }
        }
    }
}
