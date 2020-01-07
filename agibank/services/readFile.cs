using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace agibank
{
    class ReadFile
    {
        public static List<string> read(string folder, string file)
        {
            string path = $"{folder}\\{file}";
            using (StreamReader reader = new StreamReader(path))
            {
                string lines = reader.ReadToEnd();
                return getAllFileLines(lines);
            }

        }

        public static List<string> getFilesNameInDirectoryFiles(string path)
        {
            var itens = Directory.GetFiles(path);
            List<string> filesNames = new List<string>();

            foreach (var file in itens)
            {
                filesNames.Add(Path.GetFileName(file));
            }

            return filesNames;
        }

        public static List<string> getAllFileLines(string file)
        {
            return file.Split("\n").ToList();
        }
    }
}