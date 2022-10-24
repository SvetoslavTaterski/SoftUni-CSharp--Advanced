using System.IO;
using System;

namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            DirectoryInfo folderInfo = new DirectoryInfo(folderPath);
            FileInfo[] files = folderInfo.GetFiles("*", SearchOption.AllDirectories);
            decimal sum = 0;

            foreach (FileInfo file in files)
            {
                sum += file.Length;
            }

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                writer.Write(sum / 1024);
            }
        }
    }
}
