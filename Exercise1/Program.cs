using System;
using System.Text.RegularExpressions;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var peole = new People()
            {
             Name = "Marry",
             Gender = true,
             Age = 25
            };
            Console.WriteLine("Simple Properties Demo");
            Console.WriteLine("Person details:"+peole.ToString());
            peole.Age = 35;
            Console.WriteLine("Person details (apter incrementingage age):"+peole.ToString());
        }
        
    }
}