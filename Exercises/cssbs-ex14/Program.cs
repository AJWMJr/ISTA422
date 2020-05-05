using System;
using System.IO;
using System.Text.RegularExpressions;

namespace cssbs_ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a word or sentence to encrypt: ");
            var input = Console.ReadLine();
            var crypt = new Encrypter(input);
            Console.WriteLine(crypt);
        }
        //AbCDEFGHIJKLMnOPQRStuVWXYZ
    }
}
