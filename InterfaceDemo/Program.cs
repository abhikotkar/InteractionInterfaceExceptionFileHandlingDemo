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
      //  StreamWriter sw = new StreamWriter(@"D:\Shaurya Interaction\add.txt");
        public int Addition(int a, int b)
        {
            return a + b;
            
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }
    }

    class Result
    {
        static void Main(string[] args)
        {
            StreamWriter sw = null;
            try
            {
                Console.WriteLine("Enter two numbers:");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Calculate c = new Calculate();
                sw = new StreamWriter(@"D:\Shaurya Interaction\add.txt");
                sw.WriteLine("Addition:" +(c.Addition(a,b)).ToString());
                sw.WriteLine("Multiplication:" + (c.Multiplication(a , b)).ToString());
               
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sw.Close();
            }
           
        }
    }

}
