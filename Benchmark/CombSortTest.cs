using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using System.IO;
using Sort;

namespace Benchmark
{
    public class CombSortTest
    {
        string path = @"D:\\Семестровая_работа_АИСД_(CombSort)\data.txt";
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


        [Benchmark]
        public void TestCombSortWith100Elements()
        {
            GenerateData(path, 100);
            CombSort.MakeCombSort(ReadData(path));
        }

        [Benchmark]
        public void TestCombSortWith100ElementsV2()
        {
            GenerateData(path, 100);
            CombSort.MakeCombSort(ReadData(path));
        }
        [Benchmark]
        public void TestCombSortWith100ElementsV3()
        {
            GenerateData(path, 100);
            CombSort.MakeCombSort(ReadData(path));
        }
        [Benchmark]
        public void TestCombSortWith100ElementsV4()
        {
            GenerateData(path, 100);
            CombSort.MakeCombSort(ReadData(path));
        }
        [Benchmark]
        public void TestCombSortWith100ElementsV5()
        {
            GenerateData(path, 100);
            CombSort.MakeCombSort(ReadData(path));
        }


        [Benchmark]
        public void TestCombSortWith1000Elements()
        {
            GenerateData(path, 1000);
            var data = ReadData(path);
            CombSort.MakeCombSort(data);
        }
        [Benchmark]
        public void TestCombSortWith1000ElementsV2()
        {
            GenerateData(path, 1000);
            var data = ReadData(path);
            CombSort.MakeCombSort(data);
        }
        [Benchmark]
        public void TestCombSortWith1000ElementsV3()
        {
            GenerateData(path, 1000);
            var data = ReadData(path);
            CombSort.MakeCombSort(data);
        }
        [Benchmark]
        public void TestCombSortWith1000ElementsV4()
        {
            GenerateData(path, 1000);
            var data = ReadData(path);
            CombSort.MakeCombSort(data);
        }
        public void TestCombSortWith1000ElementsV5()
        {
            GenerateData(path, 1000);
            var data = ReadData(path);
            CombSort.MakeCombSort(data);
        }
        [Benchmark]
        public void TestCombSortWith5000Elements()
        {
            GenerateData(path, 5000);
            var data = ReadData(path);
            CombSort.MakeCombSort(data);
        }
        [Benchmark]
        public void TestCombSortWith5000ElementsV2()
        {
            GenerateData(path, 5000);
            var data = ReadData(path);
            CombSort.MakeCombSort(data);
        }
        [Benchmark]
        public void TestCombSortWith5000ElementsV3()
        {
            GenerateData(path, 5000);
            var data = ReadData(path);
            CombSort.MakeCombSort(data);
        }
        [Benchmark]
        public void TestCombSortWith5000ElementsV4()
        {
            GenerateData(path, 5000);
            var data = ReadData(path);
            CombSort.MakeCombSort(data);
        }
        [Benchmark]
        public void TestCombSortWith5000ElementsV5()
        {
            GenerateData(path, 5000);
            var data = ReadData(path);
            CombSort.MakeCombSort(data);
        }
        [Benchmark]
        public void TestCombSortWith10000Elements()
        {
            GenerateData(path, 10000);
            var data = ReadData(path);
            CombSort.MakeCombSort(data);
        }
        [Benchmark]
        public void TestCombSortWith10000ElementsV2()
        {
            GenerateData(path, 10000);
            var data = ReadData(path);
            CombSort.MakeCombSort(data);
        }
        [Benchmark]
        public void TestCombSortWith10000ElementsV3()
        {
            GenerateData(path, 10000);
            var data = ReadData(path);
            CombSort.MakeCombSort(data);
        }
        [Benchmark]
        public void TestCombSortWith10000ElementsV4()
        {
            GenerateData(path, 10000);
            var data = ReadData(path);
            CombSort.MakeCombSort(data);
        }
        [Benchmark]
        public void TestCombSortWith10000ElementsV5()
        {
            GenerateData(path, 10000);
            var data = ReadData(path);
            CombSort.MakeCombSort(data);
        }

    }
}
