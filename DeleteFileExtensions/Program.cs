using System;
using System.IO;

namespace DeleteFileExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入文件夹路径:");
            string path = Console.ReadLine();

            while (!Directory.Exists(path))
            {
                Console.WriteLine("路径不存在！重新输入");
                path = Console.ReadLine();
            }


            var files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                if (file.EndsWith(".下载"))
                {
                    string newFilePath = file.TrimEnd(".下载".ToCharArray());
                    File.Move(file, newFilePath);
                    //Directory.Delete(file);
                }
            }
            Console.WriteLine("完成");
            Console.ReadLine();
        }

        
    }
}
