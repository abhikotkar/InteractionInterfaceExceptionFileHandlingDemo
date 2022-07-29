using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public interface ICalculate
    {
        public int Addition(int a, int b);

        public int Multiplication(int a, int b);
    }

    public class Calculate : ICalculate
    {
        public int Addition(int a, int b)
        {
            return (a + b);
        }

        public int Multiplication(int a, int b)
        {
            return (a * b);
        }
    }

    class Result
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> aa = new List<int>();
                Console.WriteLine("Enter two numbers:");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Calculate c = new Calculate();
                aa.Add(c.Addition(a, b));
                aa.Add(c.Multiplication(a, b));
                FileStream fs = new FileStream(@"D:\Shaurya Interaction\AddMul", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(List<int>));
                xs.Serialize(fs, aa);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}
