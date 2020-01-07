using System;
using System.Collections.Generic;
using System.IO;

namespace agibank
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PATH_ORIGIN = @".\data\in\";
         
                GetFile.getFileList(PATH_ORIGIN);
                WatcherFile.watch();
                Environment.Exit(0);   
               
        }
    }
}
