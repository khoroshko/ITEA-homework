using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Text.RegularExpressions;

namespace _8HomeworkITEA
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            string subpath = @"program\Dir";
            for (int i = 0; i < 50; i++)
            {
                string path1 = @"C:\SomeDir";
                DirectoryInfo dir = new DirectoryInfo(path1);
                string name = subpath + i + 1;
                dir.CreateSubdirectory(name);
            }

            if (Directory.Exists(subpath))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(subpath);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(subpath);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }

            try
            {
                DirectoryInfo dirInf = new DirectoryInfo(subpath);
                dirInf.Delete(true);
                Console.WriteLine("Каталог удален");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //2

            string path = @"C:\SomeDir2";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            Console.WriteLine("Введите строку для записи в файл:");
            string text = Console.ReadLine();

            using (FileStream fstream = new FileStream($"{path}\note.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Текст записан в файл");
            }

            using (FileStream fstream = File.OpenRead($"{path}\note.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"Текст из файла: {textFromFile}");
            }

            Console.ReadLine();

            //3

            Regex file = new Regex(@".*\.txt$");
            DirectoryInfo dr = new DirectoryInfo(@"C:\");
            Search(dr, file);

            string readtext = ReadAllText(@"C:\note.txt");

        }

        static void Search(DirectoryInfo dr, Regex file)
        {
            FileInfo[] fi = dr.GetFiles();
            foreach (FileInfo info in fi)
            {
                if (file.IsMatch(info.Name))
                {
                    Console.WriteLine("{0,-20} | {1}", info.Directory.Name, info.Name);
                }
            }
            DirectoryInfo[] dirs = dr.GetDirectories();
            foreach (DirectoryInfo directoryInfo in dirs)
            {
                Search(directoryInfo, file);
            }
        }

        public static string ReadAllText(string filePath)
        {
            using (FileStream stream = File.OpenRead(filePath))
            {
                var encoding = new UTF8Encoding(true);
                var reader = new StreamReader(stream, encoding);
                return reader.ReadToEnd();
            }
        }

        public static void Compress(string sourceFile, string compressedFile)
        {
            using (FileStream sourceStream = new FileStream(sourceFile, FileMode.OpenOrCreate))
            {
                using (FileStream targetStream = File.Create(compressedFile))
                {
                    using (GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress))
                    {
                        sourceStream.CopyTo(compressionStream); 
                        Console.WriteLine("Сжатие файла {0} завершено. Исходный размер: {1}  сжатый размер: {2}.",
                            sourceFile, sourceStream.Length.ToString(), targetStream.Length.ToString());
                    }
                }
            }
        }
    }
}
