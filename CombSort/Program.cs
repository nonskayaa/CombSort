using System.IO;
using static System.Net.WebRequestMethods;

namespace Sort
{
    public class Program
    {
        //метод генерации данных 
        public static void GenerateData(string path, int count)
        {
            string file_path = path + $"\\data_{count}.txt";
            StreamWriter sw = new StreamWriter(file_path, false);
            Random random = new Random();
            for (int j = 0; j < count; j++)
                sw.Write($" {random.Next(-500, 500)} ");
            sw.Close();
        }
        //метод считывания данных 
        public static int[] ReadData(string path)
        {
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            var tempArray = line
           .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
           .Select(n => int.Parse(n)).ToArray();
            sr.Close();
            return tempArray;
        }
        public static void Main(string[] args)
        {
            string path = @"D:\\Семестровая_работа_АИСД_(CombSort)";

            //генерация наборов
            for (int i = 100; i <= 10000; i += 150)
            {
                CombSort.countIterations = 0;
                GenerateData(path, i);
                string file_path = path + $"\\data_{i}.txt";
                var testArray = ReadData(file_path);

                //измерение времени
                var watch = System.Diagnostics.Stopwatch.StartNew();
                CombSort.MakeCombSort(testArray);
                watch.Stop();
                var elapsedMs = watch.Elapsed.TotalMilliseconds;

                Console.WriteLine($"КОЛИЧЕСТВО ЭЛЕМЕНТОВ : {i} \t ИТЕРАЦИЙ : {CombSort.countIterations} \t ВРЕМЯ : {elapsedMs}");
            }
        }

    }
}