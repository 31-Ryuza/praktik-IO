using System;
using System.IO;

namespace Praktik_IO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file_test = @"/Users/rizaagustiansyah/Documents/Tugas XI Semester 2/KK3/Praktik File IO/Text_1.txt";
            StreamReader strReader = new StreamReader(file_test);
            string line;
            string text = "TJA";
            string path = @"/Users/rizaagustiansyah/Documents/Tugas XI Semester 2/KK3/Praktik File IO/Text_1.txt";
            string copypath = @"/Users/rizaagustiansyah/Documents/Tugas XI Semester 2/KK3/Praktik File IO/Hasil Copy/CopyText_1.txt";
            File.AppendAllText(file_test, text);
            File.Copy(path, copypath);
            File.Delete(path);
            while ((line = strReader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            strReader.Close();

            //Untuk membuat file
            //using (StreamWriter sw = File.CreateText(file_test))
            //{
            //    sw.WriteLine("RPL");
            //    sw.WriteLine("TKJ");
            //}
        }
    }
}
