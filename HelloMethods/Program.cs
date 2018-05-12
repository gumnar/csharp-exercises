using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter choice:\nfr\nen\nsp\n");

            string userInput = Console.ReadLine();
            string message = Message.GetMessage(userInput);
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
