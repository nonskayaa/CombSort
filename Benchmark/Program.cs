using Benchmark;
using BenchmarkDotNet.Running;
class Program
{
    //метод для генерации входных данных
    public static void GenerateData(string path, int count)
    {
        StreamWriter sw = new StreamWriter(path, false);
        Random random = new Random();
        for (int j = 0; j < count; j++)
            sw.Write($" {random.Next(-500, 500)} ");
        sw.Close();
    }
    public static int[] ReadData(string path)
    {
        StreamReader sr = new StreamReader(path);
        var listArrays = new List<int[]>();
        string line = sr.ReadLine();
        var tempArray = line
       .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
       .Select(n => int.Parse(n)).ToArray();
        sr.Close();
        return tempArray;
    }
    public static void Main(string[] args)
    {
        string path = @"D:\\Семестровая_работа_АИСД_(CombSort)\data.txt";

        BenchmarkRunner.Run<CombSortTest>();
    }
}