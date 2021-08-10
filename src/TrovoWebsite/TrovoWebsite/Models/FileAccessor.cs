using System;
using System.IO;

namespace TrovoWebsite.Models
{
    public class FileAccessor
    {
        public string Access(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}