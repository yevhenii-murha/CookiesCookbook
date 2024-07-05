using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook.Services
{
    public class FileMetadata
    {
        public FileFormat Format { get; private set; }
        public string FileName { get; private set; }
        public string FilePath { get; private set; }

        public FileMetadata(FileFormat format, string fileName)
        {
            Format = format;
            FileName = fileName;

            if (Format == FileFormat.Json)
                FilePath = FileName + ".json";
            else if (Format == FileFormat.Txt)
                FilePath = FileName + ".txt";
        }
    }
}
