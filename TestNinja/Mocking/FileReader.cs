using System.IO;

namespace TestNinja.Mocking
{
    public class FileReader
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
