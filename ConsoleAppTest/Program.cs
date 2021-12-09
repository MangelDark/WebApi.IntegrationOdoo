using System;

namespace ConsoleAppTest
{
    class Program
    {
        static  void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var result = new OdooProducts();
           var data =  result.Can_create_product();
            Console.WriteLine(data.GetAwaiter());
            Console.ReadLine();
        }
    }
}
