using System;
using System.Text;
using System.Threading.Tasks;

namespace cssbs_ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }
        private static void Start()
        {
            Console.WriteLine("Give me a password to crack");
            var pass = Console.ReadLine();
            bool BF = new BruteCracker(pass).Crack();
            if (BF) Console.WriteLine("Ha! Cracked it");
            else Console.WriteLine("Ok, You got me");
        }
    }
}
