using System;

namespace Interfaces
{
    public class FileLogger : ILogger
    {
        public string WriteLog()
        {
            return "Dosyaya Loglandı.";
        }
    }
}