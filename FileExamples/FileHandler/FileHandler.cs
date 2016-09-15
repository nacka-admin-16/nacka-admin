using System.IO;

namespace FileExamples.FileHandler
{
    public static class FileHandler
    {
        public static FileInfo[] ListFiles(string directory)
        {
            var directoryInfo = new DirectoryInfo(@directory);
            var files = directoryInfo.GetFiles("*.txt");

            return files;
        }
    }
}