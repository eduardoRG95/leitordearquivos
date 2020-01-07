using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace agibank
{
    class GetFile
    {
        public static void getFileList(string path) {
         var files = ReadFile.getFilesNameInDirectoryFiles(path);
                foreach (var file in files)
                {
                    var lines = ReadFile.read(path, file);
                    if(lines[0] != ""){
                        ExtractFile.createLists(lines, file);
                    }
                }   
                System.Console.WriteLine("\nArquivos lidos com sucesso");
        }
    }
}