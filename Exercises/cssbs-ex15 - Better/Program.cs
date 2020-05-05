using System;


namespace cssbs_ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a word or sentence to encrypt: ");
            var input = Console.ReadLine();
            var crypt = new Encrypter(input);
            Console.WriteLine("We gonna crack this here password");
            var BF = new BruteCracker(input, crypt.ToString());
            Console.WriteLine($"We cracked your password. It was: {BF.Crack()}");
        }
        //AbCDEFGHIJKLMnOPQRStuVWXYZ
    }
}
